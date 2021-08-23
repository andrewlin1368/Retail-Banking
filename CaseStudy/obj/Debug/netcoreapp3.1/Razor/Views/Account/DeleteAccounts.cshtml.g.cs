#pragma checksum "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Account\DeleteAccounts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1fae52e2b7ae966a8bfb0390547b259e08a0f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_DeleteAccounts), @"mvc.1.0.view", @"/Views/Account/DeleteAccounts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1fae52e2b7ae966a8bfb0390547b259e08a0f8", @"/Views/Account/DeleteAccounts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b912b7d8c758ad7e2dbc5ab40c55a7a67d618261", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_DeleteAccounts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Account>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Account\DeleteAccounts.cshtml"
  
    ViewData["Title"] = "DeleteAccounts";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center"">Delete an Account</h1>

<style>
    div {
        background: white;
        background: linear-gradient(to right,#f6ebe6,#aee1f9);
    }
    table, tr, td, th {
        margin-left: auto;
        margin-right: auto;
        padding: 10px;
        border: 1px solid black;
    }
</style>

<table>
    <tr>
        <th>Customer ID</th>
        <th>Account ID</th>
        <th>Account Type</th>
        <th>Account Balance</th>
        <th>Delete</th>
    </tr>
");
#nullable restore
#line 30 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Account\DeleteAccounts.cshtml"
     foreach (Account account in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Account\DeleteAccounts.cshtml"
           Write(account.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Account\DeleteAccounts.cshtml"
           Write(account.AccountID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Account\DeleteAccounts.cshtml"
           Write(account.AccountType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>$");
#nullable restore
#line 36 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Account\DeleteAccounts.cshtml"
            Write(account.AccountBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Account\DeleteAccounts.cshtml"
           Write(Html.ActionLink("Confirm Delete", "ConfirmDelete", new { AccountID = account.AccountID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Account\DeleteAccounts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div style=\"text-align:center\">\r\n    ");
#nullable restore
#line 42 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Account\DeleteAccounts.cshtml"
Write(Html.ActionLink("CANCEL", "Delete"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Account>> Html { get; private set; }
    }
}
#pragma warning restore 1591