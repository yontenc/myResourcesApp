#pragma checksum "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad1016306bdf656d92d74b7728f7698bc41efeb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlaceOrder_GetPendingOrderList), @"mvc.1.0.view", @"/Views/PlaceOrder/GetPendingOrderList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1016306bdf656d92d74b7728f7698bc41efeb7", @"/Views/PlaceOrder/GetPendingOrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2d5291f3ec8e5bd46baab07d99df654e7239b8", @"/Views/_ViewImports.cshtml")]
    public class Views_PlaceOrder_GetPendingOrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyResourcesApp.Models.PlaceOrder>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
  
    ViewData["Title"] = "Pending Order List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"hidden-row\">\r\n                ");
#nullable restore
#line 13 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"hidden-row\">\r\n                ");
#nullable restore
#line 16 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.CID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.productName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"hidden-row\">\r\n                ");
#nullable restore
#line 25 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.SiteID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.SiteName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"hidden-row\">\r\n                ");
#nullable restore
#line 34 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"hidden-row\">\r\n                ");
#nullable restore
#line 37 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.AdvanceBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.PriceAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderStatusName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"hidden-row\">\r\n                ");
#nullable restore
#line 46 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderStatusID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
 foreach (var item in Model)
{
    using (Html.BeginForm("ApproveOrder", "PlaceOrder", new { OrderID = item.OrderID }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"hidden-row\">\r\n                ");
#nullable restore
#line 58 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"hidden-row\">\r\n                ");
#nullable restore
#line 61 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.CID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.productName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"hidden-row\">\r\n                ");
#nullable restore
#line 70 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.SiteID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.SiteName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"hidden-row\">\r\n                ");
#nullable restore
#line 79 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"hidden-row\">\r\n                ");
#nullable restore
#line 82 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.AdvanceBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.PriceAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderStatusName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"hidden-row\">\r\n                ");
#nullable restore
#line 91 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderStatusID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <input type=\"submit\" value=\"Delivered\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3180, "\"", 3278, 13);
            WriteAttributeValue("", 3190, "return", 3190, 6, true);
            WriteAttributeValue(" ", 3196, "confirm(\'Are", 3197, 13, true);
            WriteAttributeValue(" ", 3209, "you", 3210, 4, true);
            WriteAttributeValue(" ", 3213, "sure", 3214, 5, true);
            WriteAttributeValue(" ", 3218, "you", 3219, 4, true);
            WriteAttributeValue(" ", 3222, "wanted", 3223, 7, true);
            WriteAttributeValue(" ", 3229, "to", 3230, 3, true);
            WriteAttributeValue(" ", 3232, "Delivered", 3233, 10, true);
            WriteAttributeValue(" ", 3242, "this", 3243, 5, true);
            WriteAttributeValue(" ", 3247, "Order", 3248, 6, true);
            WriteAttributeValue(" ", 3253, "To=", 3254, 4, true);
#nullable restore
#line 94 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
WriteAttributeValue(" ", 3257, item.CustomerName, 3258, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3276, "\')", 3276, 2, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("|\r\n                ");
#nullable restore
#line 96 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
           Write(Html.ActionLink("Cancel", "Delete", new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 99 "C:\Users\USER\source\repos\MyResourcesApp\MyResourcesApp\Views\PlaceOrder\GetPendingOrderList.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<style>\r\n    .visible-row {\r\n        display: normal;\r\n    }\r\n\r\n    .hidden-row {\r\n        display: none;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyResourcesApp.Models.PlaceOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591