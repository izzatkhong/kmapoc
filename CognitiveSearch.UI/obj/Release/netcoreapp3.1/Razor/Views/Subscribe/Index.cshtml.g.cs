#pragma checksum "C:\Ashley\Code\kmapoc\CognitiveSearch.UI\Views\Subscribe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a93dfbde9570905987a364eb8276722ee48685f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscribe_Index), @"mvc.1.0.view", @"/Views/Subscribe/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Ashley\Code\kmapoc\CognitiveSearch.UI\Views\_ViewImports.cshtml"
using CognitiveSearch.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ashley\Code\kmapoc\CognitiveSearch.UI\Views\_ViewImports.cshtml"
using CognitiveSearch.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a93dfbde9570905987a364eb8276722ee48685f7", @"/Views/Subscribe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1c8ddb33f15e20aee94317c529990ec82e9754", @"/Views/_ViewImports.cshtml")]
    public class Views_Subscribe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CognitiveSearch.UI.Models.SubscribeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Ashley\Code\kmapoc\CognitiveSearch.UI\Views\Subscribe\Index.cshtml"
  
    ViewData["Title"] = "Ratings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    subscriptions = ");
#nullable restore
#line 11 "C:\Ashley\Code\kmapoc\CognitiveSearch.UI\Views\Subscribe\Index.cshtml"
               Write(Html.Raw(Json.Serialize(Model.subscriptions)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    feedbacks = ");
#nullable restore
#line 12 "C:\Ashley\Code\kmapoc\CognitiveSearch.UI\Views\Subscribe\Index.cshtml"
           Write(Html.Raw(Json.Serialize(Model.feedbacks)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    currentPage = 0;

    function updateSubscriptionTable(query = null) {
        var table = $(""#subscriptions-table-body"")
        table.empty();
        rowsHtml = '';
        rowCount = 0;
        for (i in subscriptions) {
            subscription = subscriptions[i]
            if (query != null) {
                if (!subscription.query.includes(query)) {
                    continue
                }
            }
            let squery = subscription.query.replace(/\""/g, ""&quot;"");
            console.log(squery);
            rowCount += 1
            //var starsDoms = ''
            //for (let i = 0; i < 5; i++) {
            //    if (feedback.rating > i) {
            //        starsDoms += `<span class=""fa fa-star ratings-star-checked""></span>`
            //    }
            //    else {
            //        starsDoms += `<span class=""fa fa-star""></span>`
            //    }
            //}

            //var ratingContent = `<td class=""ratings-table-column-align"">");
            WriteLiteral(@"${starsDoms}</td>`
            //if (feedback.feedbackRating > 1) {
            //    ratingContent = `<td class=""ratings-table-column-align ratings-table-thumbs-up""></td>`
            //}
            //else {
            //    //ratingContent = `<td class=""ratings-table-column-align ratings-table-thumbs-down"" onclick=""tdclick();""></td>`
            //    ratingContent = `<td class=""ratings-table-column-align ratings-table-thumbs-down"" onclick=""remove('${feedback.userID}', '${feedback.documentName}', '${feedback.query}');""></td>`
            //}
            //<td class=""ratings-table-column-align"">${feedbacks[i].query}</td>
            rowsHtml += `<tr class=""ratings-table-rows"">
                                <th scope=""row"">${rowCount}</th>
                                <td>${subscription.query}</td>
                                <td class=""ratings-table-column-align ratings-table-delete"" onclick=""remove('${squery}');""><span class=""fa fa-trash""></span></td>
                            </tr");
            WriteLiteral(@">`
        }
        table.html(rowsHtml);
    }

    function updateRatingsTable(query = null) {
        var table = $(""#ratings-table-body"")
        table.empty();
        rowsHtml = '';
        rowCount = 0;
        for (i in feedbacks) {
            feedback = feedbacks[i]
            if (query != null) {
                if (!feedback.query.includes(query)) {
                    continue
                }
            }
            rowCount += 1

            var ratingContent = '';
            if (feedback.rating > 1) {
                ratingContent = `<td class=""ratings-table-column-align ratings-table-thumbs-up""></td>`
            }
            else {
                //ratingContent = `<td class=""ratings-table-column-align ratings-table-thumbs-down"" onclick=""tdclick();""></td>`
                ratingContent = `<td class=""ratings-table-column-align ratings-table-thumbs-down"");""></td>`
            }
            rowsHtml += `<tr class=""ratings-table-rows"">
                        ");
            WriteLiteral(@"        <th scope=""row"">${rowCount}</th>
                                <td>${feedback.document}</td>
                                <td>${feedback.query}</td>
                                ${ratingContent}
                                <td class=""ratings-table-column-align ratings-table-delete"" onclick=""removeRating('${feedback.id}');""><span class=""fa fa-trash""></span></td>
                            </tr>`
        }
        table.html(rowsHtml);
    }

    function remove(query) {
        $.post(""/Subscribe/Unsubscribe"",
            {
                query: query,
            },
            function (data, status) {
                if (status == ""success"") {
                    subscriptions = data
                    updateSubscriptionTable()
                }
            }
        );
    };

    function removeRating(id) {
        $.post(""/Subscribe/DeleteRating"",
            {
                id: id,
            },
            function (data, status) {
               ");
            WriteLiteral(@" if (status == ""success"") {
                    feedbacks = data
                    updateRatingsTable()
                }
            }
        );
    };

    function handleFilter() {
        var input = $(""#rating-filter-input"").val();
        updateTable(input)
    }

    $(function () {
        updateSubscriptionTable()
        updateRatingsTable()
    });
</script>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a93dfbde9570905987a364eb8276722ee48685f79426", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div>
    <div class=""content ratings-content"">
        <div style=""overflow-y:scroll; height:40vh;"">
            <table class=""table"">
                <thead class=""ratings-table-header"">
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Query</th>
                        <th class=""ratings-table-column-align"" scope=""col""></th>
                    </tr>
                </thead>
                <tbody id=""subscriptions-table-body"">
                </tbody>
            </table>
        </div>
    </div>
    <div class=""content ratings-content"">
        <div style=""overflow-y:scroll; height:40vh;"">
            <table class=""table"">
                <thead class=""ratings-table-header"">
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Document</th>
                        <th scope=""col"">Query</th>
                        <th class=""ratings-table-column-align"" style");
            WriteLiteral(@"=""width:50px"" scope=""col"">Rating</th>
                        <th class=""ratings-table-column-align"" style=""width:50px"" scope=""col"">Delete</th>
                    </tr>
                </thead>
                <tbody id=""ratings-table-body"">
                </tbody>
            </table>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CognitiveSearch.UI.Models.SubscribeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
