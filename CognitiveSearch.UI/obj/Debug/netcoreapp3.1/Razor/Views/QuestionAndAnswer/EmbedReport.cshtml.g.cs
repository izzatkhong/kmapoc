#pragma checksum "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d89835ff8750c2177557c50a8a66b2bda0db74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuestionAndAnswer_EmbedReport), @"mvc.1.0.view", @"/Views/QuestionAndAnswer/EmbedReport.cshtml")]
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
#line 1 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\_ViewImports.cshtml"
using CognitiveSearch.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\_ViewImports.cshtml"
using CognitiveSearch.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d89835ff8750c2177557c50a8a66b2bda0db74", @"/Views/QuestionAndAnswer/EmbedReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1c8ddb33f15e20aee94317c529990ec82e9754", @"/Views/_ViewImports.cshtml")]
    public class Views_QuestionAndAnswer_EmbedReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/powerbi.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!-- Copyright (c) Microsoft Corporation. All rights reserved.\r\n     Licensed under the MIT License. -->\r\n\r\n");
#nullable restore
#line 4 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml"
  
    ViewData["Title"] = "Question And Answer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script src=\"https://npmcdn.com/es6-promise@3.2.1\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88d89835ff8750c2177557c50a8a66b2bda0db744104", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml"
 if (!string.IsNullOrEmpty(Model.ErrorMessage))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"errorWrapper\">\r\n        <h2>\r\n            Error\r\n        </h2>\r\n        <pre>\r\n            ");
#nullable restore
#line 18 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml"
       Write(Model.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </pre>\r\n    </div>");
#nullable restore
#line 20 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml"
          return;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml"
Write(Html.Partial("LiveDemoLink"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script>\r\n    // Read embed application token from Model\r\n    var accessToken = \"");
#nullable restore
#line 27 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml"
                  Write(Model.EmbedToken.Token);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\r\n    // Read embed URL from Model\r\n    var embedUrl = \"");
#nullable restore
#line 30 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml"
               Write(Html.Raw(Model.EmbedUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\r\n    // Read report Id from Model\r\n    var embedReportId = \"");
#nullable restore
#line 33 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml"
                    Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";

    // Get models. models contains enums that can be used.
    var models = window['powerbi-client'].models;

    // Embed configuration used to describe the what and how to embed.
    // This object is used when calling powerbi.embed.
    // This also includes settings and options such as filters.
    // You can find more information at https://github.com/Microsoft/PowerBI-JavaScript/wiki/Embed-Configuration-Details.
    var config = {
        type: 'report',
        tokenType: models.TokenType.Embed,
        accessToken: accessToken,
        embedUrl: embedUrl,
        id: embedReportId,
        permissions: models.Permissions.All,
        settings: {
            filterPaneEnabled: true,
            navContentPaneEnabled: true
        }
    };

    // Get a reference to the embedded report HTML element
    var reportContainer = $('#embedContainer')[0];

    if (""");
#nullable restore
#line 58 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml"
    Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" != \"\") {\r\n        $(\"#RLS\").prop(\'checked\', true);\r\n        $(\"#RLSdiv\").show();\r\n    }\r\n    else\r\n    {\r\n        $(\"#RLS\").prop(\'checked\', false);\r\n        $(\"#RLSdiv\").hide();\r\n    }\r\n\r\n    if (\"");
#nullable restore
#line 68 "C:\kmapoc2\azure-search-knowledge-mining\02 - Web UI Template\CognitiveSearch.UI\Views\QuestionAndAnswer\EmbedReport.cshtml"
    Write(Model.IsEffectiveIdentityRequired.GetValueOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" == ""True"") {
        $(""#noRLSdiv"").hide();
        $(""#RLS"").removeAttr(""disabled"");
        $(""#RLS"").change(function () {
            if ($(this).is("":checked"")) {
                $(""#RLSdiv"").show(300);
            } else {
                $(""#RLSdiv"").hide(200);
            }
        });
    }
    else
    {
        $(""#noRLSdiv"").show();
    }
    // Embed the report and display it within the div container.
    var report = powerbi.embed(reportContainer, config);
</script>

<!--<link rel=""stylesheet"" href=""~/lib/bootstrap/dist/css/bootstrap.css"" />
<div>
    <div class=""content"" style=""padding-top: 50px;"">
        <iframe width=""100%"" height=""720"" src=""https://app.powerbi.com/reportEmbed?reportId=f14555da-3c00-4601-9e1c-cda1da8f743c&autoAuth=true&ctid=cf36141c-ddd7-45a7-b073-111f66d0b30c&config=eyJjbHVzdGVyVXJsIjoiaHR0cHM6Ly93YWJpLXdlc3QtdXMtcmVkaXJlY3QuYW5hbHlzaXMud2luZG93cy5uZXQvIn0%3D"" frameborder=""0"" allowFullScreen=""true""></iframe>

    </div>
</div>-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
