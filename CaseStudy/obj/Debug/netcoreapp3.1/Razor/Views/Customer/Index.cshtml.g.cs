#pragma checksum "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3af8c72bb9181aeefc99002d52c968a750955d33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af8c72bb9181aeefc99002d52c968a750955d33", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b912b7d8c758ad7e2dbc5ab40c55a7a67d618261", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    div {\r\n        background: white;\r\n        background: linear-gradient(to right,#f6ebe6,#aee1f9);\r\n    }\r\n</style>\r\n\r\n<h1>Customers</h1>\r\n<table class=\"table table-active table-striped\">\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
     foreach (Customer c in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(c.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(c.SSNID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(c.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(c.AddressLine1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(c.AddressLine2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(c.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(c.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(c.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(Html.ActionLink("Update","UpdateCustomer", new { id = c.CustomerID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"
           Write(Html.ActionLink("Delete", "DeleteCustomer", new { id = c.CustomerID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
