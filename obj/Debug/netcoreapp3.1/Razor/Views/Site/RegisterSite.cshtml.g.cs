#pragma checksum "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Site\RegisterSite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f05545223de8d5e30287041c3049221e53d6378"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Site_RegisterSite), @"mvc.1.0.view", @"/Views/Site/RegisterSite.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\_ViewImports.cshtml"
using MyResourcesApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\_ViewImports.cshtml"
using MyResourcesApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"200c748b596be0497bbb4c7b57722384280ee38b", @"/Views/Site/RegisterSite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4c9dd16152a354abfea8fb21655e024dbc0b7ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Site_RegisterSite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyResourcesApp.Models.Site>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary my-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnterNewSite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
  
    ViewData["Title"] = "Register Site";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f05545223de8d5e30287041c3049221e53d63784660", async() => {
                WriteLiteral("<i class=\"fas fa-plus mr-1\"></i>Add New Site");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n</p>\r\n<table class=\"table table-hover\" id=\"dataTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
           Write(Html.DisplayNameFor(model => model.SiteID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
           Write(Html.DisplayNameFor(model => model.SiteName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
           Write(Html.DisplayNameFor(model => model.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
         foreach (var item in Model)
        {

            using (Html.BeginForm("DeleteSiteInfo", "Site", new { siteId = item.SiteID }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SiteID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SiteName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CustomerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Distance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 51 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
                   Write(Html.ActionLink("Edit", "EditSiteInfo", new { siteId = item.SiteID }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 52 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
                   Write(Html.ActionLink("Details", "ViewSiteInfo", new { siteId = item.SiteID }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1869, "\"", 1964, 14);
            WriteAttributeValue("", 1879, "return", 1879, 6, true);
            WriteAttributeValue(" ", 1885, "confirm(\'Are", 1886, 13, true);
            WriteAttributeValue(" ", 1898, "you", 1899, 4, true);
            WriteAttributeValue(" ", 1902, "sure", 1903, 5, true);
            WriteAttributeValue(" ", 1907, "you", 1908, 4, true);
            WriteAttributeValue(" ", 1911, "wanted", 1912, 7, true);
            WriteAttributeValue(" ", 1918, "to", 1919, 3, true);
            WriteAttributeValue(" ", 1921, "delete", 1922, 7, true);
            WriteAttributeValue(" ", 1928, "site", 1929, 5, true);
            WriteAttributeValue(" ", 1933, "recode", 1934, 7, true);
            WriteAttributeValue(" ", 1940, "with", 1941, 5, true);
            WriteAttributeValue(" ", 1945, "ID=", 1946, 4, true);
#nullable restore
#line 53 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Site\RegisterSite.cshtml"
WriteAttributeValue(" ", 1934, item.SiteID, 1935, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1962, "\')", 1962, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Site\RegisterSite.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyResourcesApp.Models.Site>> Html { get; private set; }
    }
}
#pragma warning restore 1591
