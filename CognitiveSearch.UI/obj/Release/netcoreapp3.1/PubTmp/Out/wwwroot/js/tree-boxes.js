﻿function treeBoxes(treeData) {
    // Set the dimensions and margins of the diagram
    var margin = { top: 20, right: 90, bottom: 30, left: 90 },
        width = 960 - margin.left - margin.right,
        height = 500 - margin.top - margin.bottom;

    // append the svg object to the body of the page
    // appends a 'group' element to 'svg'
    // moves the 'group' element to the top left margin
    d3.select("#tree-test-id").remove();
    var svg = d3.select("#tree-container").append("svg")
        .attr("id","tree-test-id")
        .attr("width", width + margin.right + margin.left)
        .attr("height", height + margin.top + margin.bottom)
        .append("g")
        .attr("transform", "translate("
            + margin.left + "," + margin.top + ")");

    var i = 0,
        duration = 750,
        root;

    // declares a tree layout and assigns the size
    var treemap = d3.tree().size([height, width]);

    // Assigns parent, children, height, depth
    root = d3.hierarchy(treeData[0], function (d) { return d.children; });
    root.x0 = height / 2;
    root.y0 = 0;

    // Collapse after the second level
    root.children.forEach(collapse);

    update(root);

    // Collapse the node and all it's children
    function collapse(d) {
        if (!(d.data.type == "type1" || d.data.type == "type2" || d.data.type == "type3")) {
            if (d.children) {
                d._children = d.children
                d._children.forEach(collapse)
                d.children = null
            }
        }
    }

    function update(source) {

        // Assigns the x and y position for the nodes
        var treeData = treemap(root);

        // Compute the new tree layout.
        var nodes = treeData.descendants(),
            links = treeData.descendants().slice(1);

        // Normalize for fixed-depth.
        nodes.forEach(function (d) { d.y = d.depth * 180 });

        // ****************** Nodes section ***************************

        // Update the nodes...
        var node = svg.selectAll('g.node')
            .data(nodes, function (d) { return d.id || (d.id = ++i); });

        // Enter any new modes at the parent's previous position.
        var nodeEnter = node.enter().append('g')
            .attr('class', 'node')
            .attr("transform", function (d) {
                return "translate(" + source.y0 + "," + source.x0 + ")";
            })
            .on('click', click);

        // Add Circle for the nodes
        nodeEnter.append('circle')
            .attr('class', 'node')
            .attr('r', 1e-6)
            .style("fill", function (d) {
                var color = "";
                var blue = '#337ab7',
                    green = '#5cb85c',
                    yellow = '#f0ad4e',
                    purple = '#9467bd',
                    red = "#d81f2a",
                    lime = "#cbd34c",
                    lightblue = "#93bfeb";

                if (d.data.type == 'type1')
                    color = blue;
                if (d.data.type == 'type2')
                    color = green;
                if (d.data.type == 'type3')
                    color = yellow;
                if (d.data.type == 'type4')
                    color = purple;
                if (d.data.type == 'type5')
                    color = red;
                if (d.data.type == 'type6')
                    color = lime;
                if (d.data.type == 'type7')
                    color = lightblue;

                return color;
            });

        // Add labels for the nodes
        nodeEnter.append('text')
            .attr("dy", ".35em")
            .attr("x", function (d) {
                return d.children || d._children ? -13 : 13;
            })
            .attr("text-anchor", function (d) {
                return d.children || d._children ? "end" : "start";
            })
            .text(function (d) { return d.data.label.label; })
            .style("fill", "#fff")
            .on('mouseover', function (d) {
                
                $('#' + d.data.label.label).show();
            })
            .on('mouseout', function (d) {
                $('#' + d.data.label.label).hide();
            });

        // UPDATE
        var nodeUpdate = nodeEnter.merge(node);

        // Transition to the proper position for the node
        nodeUpdate.transition()
            .duration(duration)
            .attr("transform", function (d) {
                return "translate(" + d.y + "," + d.x + ")";
            });

        // Update the node attributes and style
        nodeUpdate.select('circle.node')
            .attr('r', 10)
            .style("fill", function (d) {
                var color = "";
                var blue = '#337ab7',
                    green = '#5cb85c',
                    yellow = '#f0ad4e',
                    purple = '#9467bd',
                    red = "#d81f2a",
                    lime = "#cbd34c",
                    lightblue = "#93bfeb";

                if (d.data.type == 'type1')
                    color = blue;
                if (d.data.type == 'type2')
                    color = green;
                if (d.data.type == 'type3')
                    color = yellow;
                if (d.data.type == 'type4')
                    color = purple;
                if (d.data.type == 'type5')
                    color = red;
                if (d.data.type == 'type6')
                    color = lime;
                if (d.data.type == 'type7')
                    color = lightblue;

                return color;
            })
            .attr('cursor', 'pointer')
            .on('mouseover', function (d) {
                if (d.data.type == "type1" || d.data.type == "type3") {
                    var searchString = "";
                    if (d.data.type == "type1") {
                        var child = d.data.children;
                        for (var i = 0; i < child.length; i++) {
                            var child2 = child[i].children;
                            for (var j = 0; j < child2.length; j++) {
                                if (child2[j].type == "type3") {
                                    if (searchString.length <= 0) {
                                        searchString += "'" + child2[j].label.label + "'";
                                    } else {
                                        searchString += ", '" + child2[j].label.label + "'";
                                    }
                                }
                            }
                        }
                    }

                    if (searchString.length > 0) {
                        searchString = "(" + searchString + ")";
                    }

                    $.get("/Chat/getFailureCount",
                        {
                            nodeName: d.data.label.label,
                            functionalLocation: searchString,
                            typeLevel: d.data.type,
                            chartType: "Pie"
                        },
                        function (data, status) {
                            if (data.length > 0) {
                                var obj = JSON.parse(data);
                                loopPieChart(obj);
                            }
                        }
                    ).fail(function () {
                        alert('Database Connection is hitting error.'); // or whatever
                    });

                    $.get("/Chat/getFailureCount",
                        {
                            nodeName: d.data.label.label,
                            functionalLocation: searchString,
                            typeLevel: d.data.type,
                            chartType: "Histogram"
                        },
                        function (data, status) {
                            if (data.length > 0) {
                                var obj = JSON.parse(data);
                                loopHistogram(obj);
                            }
                        }
                    ).fail(function () {
                        alert('Database Connection is hitting error.'); // or whatever
                    });

                    $.get("/Chat/getFailureCount",
                        {
                            nodeName: d.data.label.label,
                            functionalLocation: searchString,
                            typeLevel: d.data.type,
                            chartType: "Line"
                        },
                        function (data, status) {
                            if (data.length > 0) {
                                var obj = JSON.parse(data);
                                loopLineChart(obj);
                            }
                        }
                    ).fail(function () {
                        alert('Database Connection is hitting error.'); // or whatever
                    });

                    $.get("/Chat/getFailureCount",
                        {
                            nodeName: d.data.label.label,
                            functionalLocation: searchString,
                            typeLevel: d.data.type,
                            chartType: "Top3"
                        },
                        function (data, status) {
                            var pivotsHTML = '';
                            if (data.length > 0) {
                                var obj = JSON.parse(data);

                                pivotsHTML += "<h5>Top Recommendations:</h5>"; // + obj.length + " Failures:</h5>";
                                var j = 1;
                                for (var i = 0; i < obj.length; i++) {
                                    pivotsHTML += "<p>" + j + ") " + obj[i].ProblemID + " (" + obj[i].FailureCount + ")</p>";
                                    j++;
                                }
                            }
                            $('#top3-container').html(pivotsHTML);
                        }
                    ).fail(function () {
                        alert('Database Connection is hitting error.'); // or whatever
                    });
                }
            })
            .on('mouseout', function (d) {
                d3.select("#pie-chart-container-id").remove();
                d3.select("#histogram-container-id").remove();
                d3.select("#line-chart-container-id").remove(); 
                document.getElementById("top3-container").innerHTML = "";
            });


        // Remove any exiting nodes
        var nodeExit = node.exit().transition()
            .duration(duration)
            .attr("transform", function (d) {
                return "translate(" + source.y + "," + source.x + ")";
            })
            .remove();

        // On exit reduce the node circles size to 0
        nodeExit.select('circle')
            .attr('r', 1e-6);

        // On exit reduce the opacity of text labels
        nodeExit.select('text')
            .style('fill-opacity', 1e-6);

        // ****************** links section ***************************

        // Update the links...
        var link = svg.selectAll('path.link')
            .data(links, function (d) { return d.id; });

        // Enter any new links at the parent's previous position.
        var linkEnter = link.enter().insert('path', "g")
            .attr("class", "link")
            .attr('d', function (d) {
                var o = { x: source.x0, y: source.y0 }
                return diagonal(o, o)
            });

        // UPDATE
        var linkUpdate = linkEnter.merge(link);

        // Transition back to the parent element position
        linkUpdate.transition()
            .duration(duration)
            .attr('d', function (d) { return diagonal(d, d.parent) });

        // Remove any exiting links
        var linkExit = link.exit().transition()
            .duration(duration)
            .attr('d', function (d) {
                var o = { x: source.x, y: source.y }
                return diagonal(o, o)
            })
            .remove();

        // Store the old positions for transition.
        nodes.forEach(function (d) {
            d.x0 = d.x;
            d.y0 = d.y;
        });

        // Creates a curved (diagonal) path from parent to the child nodes
        function diagonal(s, d) {

            path = `M ${s.y} ${s.x}
            C ${(s.y + d.y) / 2} ${s.x},
              ${(s.y + d.y) / 2} ${d.x},
              ${d.y} ${d.x}`

            return path
        }

        // Toggle children on click.
        function click(d) {
            if (d.children) {
                d._children = d.children;
                d.children = null;
            } else {
                d.children = d._children;
                d._children = null;
            }
            update(d);
        }
    }

    $('#loading-spinner').hide();
}