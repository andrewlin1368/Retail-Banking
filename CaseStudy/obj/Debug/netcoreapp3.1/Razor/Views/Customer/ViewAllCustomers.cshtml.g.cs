#pragma checksum "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c29dc97a3a1f97e815eaf4cbe032f0fed4f6f4f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ViewAllCustomers), @"mvc.1.0.view", @"/Views/Customer/ViewAllCustomers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29dc97a3a1f97e815eaf4cbe032f0fed4f6f4f0", @"/Views/Customer/ViewAllCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b912b7d8c758ad7e2dbc5ab40c55a7a67d618261", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ViewAllCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
  
    ViewData["Title"] = "ViewAllCustomers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    div {
        background: white;
        background: linear-gradient(to right,#f6ebe6,#aee1f9);
    }
    h1{
        text-align:center;
    }

    table, th, td, tr{
        border: 1px solid black;
       
    }
</style>


<h1>All Customers</h1>
<style>
    div {
        background: white;
        background: linear-gradient(to right,#f6ebe6,#aee1f9);
    }
</style>
<table class=""table table-active table-striped"">
    <tr>
        <th>Customer ID</th>
        <th>SSN </th>
        <th>Name</th>
        <th>Age</th>
        <th>Address 1</th>
        <th>Address 2</th>
        <th>City</th>
        <th>State</th>
        <th>Status</th>
        <th>Update</th>
        <th>Delete</th>
    </tr>
");
#nullable restore
#line 44 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
     foreach (Customer c in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 47 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
   Write(c.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 48 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
   Write(c.SSNID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 49 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
   Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 50 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
   Write(c.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 51 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
   Write(c.AddressLine1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 52 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
   Write(c.AddressLine2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 53 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
   Write(c.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 54 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
   Write(c.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 55 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
   Write(c.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("    <td><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1256, "\"", 1383, 4);
            WriteAttributeValue("", 1266, "showInPopup(\'", 1266, 13, true);
#nullable restore
#line 57 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
WriteAttributeValue("", 1279, Url.Action("UpdateCustomer", "Customer", new { id = c.CustomerID }, Context.Request.Scheme), 1279, 92, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1371, "\',", 1371, 2, true);
            WriteAttributeValue(" ", 1373, "\'Update\')", 1374, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-random\"></i>Update</a></td>\r\n");
            WriteLiteral("    <td><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1566, "\"", 1693, 4);
            WriteAttributeValue("", 1576, "showInPopup(\'", 1576, 13, true);
#nullable restore
#line 59 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
WriteAttributeValue("", 1589, Url.Action("DeleteCustomer", "Customer", new { id = c.CustomerID }, Context.Request.Scheme), 1589, 92, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1681, "\',", 1681, 2, true);
            WriteAttributeValue(" ", 1683, "\'Delete\')", 1684, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-random\"></i>Delete</a></td>\r\n</tr>\r\n");
#nullable restore
#line 61 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
 if (ViewBag.Page > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 1889, "\"", 1959, 1);
#nullable restore
#line 68 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
WriteAttributeValue("", 1896, Url.Action("ViewAllCustomers", new {page = ViewBag.Page - 1 }), 1896, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\">&laquo; Prev</a>\r\n");
#nullable restore
#line 69 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
 if (ViewBag.Page < ViewBag.MaxPage)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 2055, "\"", 2126, 1);
#nullable restore
#line 73 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
WriteAttributeValue("", 2062, Url.Action("ViewAllCustomers", new {page = ViewBag.Page  + 1 }), 2062, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\">Next &raquo;</a>\r\n");
#nullable restore
#line 74 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Customer\ViewAllCustomers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
