<<<<<<< HEAD
#pragma checksum "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Product\RegisterProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e59263c71d9a9f728717ee370753662ece7dfcf"
=======
#pragma checksum "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4afc34237df845c8827546fc25550e61c9a8bc"
>>>>>>> 869305445963bf2b0ba4e942332bd3f7eba7da6a
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_RegisterProduct), @"mvc.1.0.view", @"/Views/Product/RegisterProduct.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\_ViewImports.cshtml"
using MyResourcesApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\_ViewImports.cshtml"
using MyResourcesApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e59263c71d9a9f728717ee370753662ece7dfcf", @"/Views/Product/RegisterProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2d5291f3ec8e5bd46baab07d99df654e7239b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_RegisterProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyResourcesApp.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary my-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
  
    ViewData["Title"] = "Register Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n<p>\r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e59263c71d9a9f728717ee370753662ece7dfcf4708", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a4afc34237df845c8827546fc25550e61c9a8bc4733", async() => {
>>>>>>> 869305445963bf2b0ba4e942332bd3f7eba7da6a
                WriteLiteral("<i class=\"fas fa-plus mr-1\"></i>Add New Product");
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
            WriteLiteral("\r\n\r\n</p>\r\n\r\n\r\n<table class=\"table table-hover\" id=\"dataTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.productName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.PricePerUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 38 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
         foreach (var item in Model)
        {
            using (Html.BeginForm("DeleteProductInfo", "Product", new { productName = item.productName }))
            {
=======
#line 38 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
 foreach (var item in Model)
{
    using (Html.BeginForm("DeleteProductInfo", "Product", new { productName = item.productName }))
    {
>>>>>>> 869305445963bf2b0ba4e942332bd3f7eba7da6a

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 44 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
                   Write(Html.DisplayFor(modelItem => item.productName));
=======
#line 44 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
           Write(Html.DisplayFor(modelItem => item.productName));
>>>>>>> 869305445963bf2b0ba4e942332bd3f7eba7da6a

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 47 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PricePerUnit));
=======
#line 47 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
           Write(Html.DisplayFor(modelItem => item.PricePerUnit));
>>>>>>> 869305445963bf2b0ba4e942332bd3f7eba7da6a

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 50 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TransportRate));
=======
#line 50 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportRate));
>>>>>>> 869305445963bf2b0ba4e942332bd3f7eba7da6a

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 53 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
                   Write(Html.ActionLink("Edit", "EditProductInfo", new { productName = item.productName }, new { @class = "btn btn-primary" }));
=======
#line 53 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
           Write(Html.ActionLink("Edit", "EditProductInfo", new { productName = item.productName }, new { @class = "btn btn-primary" }));
>>>>>>> 869305445963bf2b0ba4e942332bd3f7eba7da6a

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
<<<<<<< HEAD
#line 54 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
                   Write(Html.ActionLink("Details", "ViewProductInfo", new { productName = item.productName }, new { @class = "btn btn-primary" }));
=======
#line 54 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
           Write(Html.ActionLink("Details", "ViewProductInfo", new { productName = item.productName }, new { @class = "btn btn-primary" }));
>>>>>>> 869305445963bf2b0ba4e942332bd3f7eba7da6a

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1999, "\"", 2103, 14);
            WriteAttributeValue("", 2009, "return", 2009, 6, true);
            WriteAttributeValue(" ", 2015, "confirm(\'Are", 2016, 13, true);
            WriteAttributeValue(" ", 2028, "you", 2029, 4, true);
            WriteAttributeValue(" ", 2032, "sure", 2033, 5, true);
            WriteAttributeValue(" ", 2037, "you", 2038, 4, true);
            WriteAttributeValue(" ", 2041, "wanted", 2042, 7, true);
            WriteAttributeValue(" ", 2048, "to", 2049, 3, true);
            WriteAttributeValue(" ", 2051, "delete", 2052, 7, true);
            WriteAttributeValue(" ", 2058, "product", 2059, 8, true);
            WriteAttributeValue(" ", 2066, "recorde", 2067, 8, true);
            WriteAttributeValue(" ", 2074, "with", 2075, 5, true);
            WriteAttributeValue(" ", 2079, "ID=", 2080, 4, true);
#nullable restore
<<<<<<< HEAD
#line 55 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
WriteAttributeValue(" ", 2083, item.productName, 2084, 17, false);
=======
#line 55 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
WriteAttributeValue(" ", 1919, item.productName, 1920, 17, false);
>>>>>>> 869305445963bf2b0ba4e942332bd3f7eba7da6a

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2101, "\')", 2101, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 59 "C:\Users\USER\Desktop\c# Programming\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
            }
        }
=======
#line 59 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\Product\RegisterProduct.cshtml"
    }
}
>>>>>>> 869305445963bf2b0ba4e942332bd3f7eba7da6a

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyResourcesApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
