﻿function loopHistogram(data) {
    var margin = { top: 20, right: 20, bottom: 30, left: 40 },
        width = 400 - margin.left - margin.right,
        height = 130 - margin.top - margin.bottom;

    // set the ranges
    var x = d3.scaleBand()
        .range([0, width])
        .padding(0.1);
    var y = d3.scaleLinear()
        .range([height, 0]);

    // append the svg object to the body of the page
    // append a 'group' element to 'svg'
    // moves the 'group' element to the top left margin
    d3.select("#histogram-container-id").remove();
    var svg = d3.select("#histogram-container").append("svg")
        .attr("id", "histogram-container-id")
        .attr("width", width + margin.left + margin.right)
        .attr("height", height + margin.top + margin.bottom)
        .append("g")
        .attr("transform",
            "translate(" + margin.left + "," + margin.top + ")");


    // format the data
    data.forEach(function (d) {
        d.FailureCount = +d.FailureCount;
    });

    // Scale the range of the data in the domains
    x.domain(data.map(function (d) { return d.ProblemID; }));
    y.domain([0, d3.max(data, function (d) { return d.FailureCount; })]);

    // append the rectangles for the bar chart
    svg.selectAll(".bar")
        .data(data)
        .enter().append("rect")
        .attr("class", "bar hist-bar")
        .attr("x", function (d) {
            let width = x.bandwidth();
            if (width > 30) {
                width = (width - 30) / 2;
                return x(d.ProblemID) + width;
            }
            return x(d.ProblemID);
        })
        .attr("width", function (d) {
            let width = x.bandwidth();
            if (width > 30) {
                width = 30
            }
            return width
        })
        .attr("y", function (d) { return y(d.FailureCount); })
        .attr("height", function (d) { return height - y(d.FailureCount); });

    // add the x Axis
    let xAxis = svg.append("g")
        .attr("transform", "translate(0," + height + ")")
        .append("g")
        .call(d3.axisBottom(x).ticks(10));
        /*.selectAll("text")
        .style("text-anchor", "end")
        .attr("dx", "-.8em")
        .attr("dy", ".15em")
        .attr("transform", "rotate(-65)");*/

    // add the y Axis
    let yAxis = svg.append("g")
        .call(d3.axisLeft(y).ticks(5));

    //yAxis.selectAll("line").style("stroke", "#cccccc")
    //yAxis.selectAll("path").style("stroke", "#cccccc")
    //yAxis.selectAll("text").style("fill", "#eeeeee").style("font-weight", "bold")
    //xAxis.selectAll("line").style("stroke", "#cccccc")
    //xAxis.selectAll("path").style("stroke", "#cccccc")
    //xAxis.selectAll("text").style("fill", "#eeeeee").style("font-weight", "bold").style("overflow","hidden")

    svg.append("text")
        .attr("x", (width / 2))
        .attr("y", "-5")
        .attr("text-anchor", "middle")
        .style("font-size", "16px")
        .style("fill", "#000")
        .style("text-decoration", "underline")
        .text("Bad Actors");

}