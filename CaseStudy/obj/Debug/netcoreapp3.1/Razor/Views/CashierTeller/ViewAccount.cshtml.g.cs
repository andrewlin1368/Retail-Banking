#pragma checksum "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\CashierTeller\ViewAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1acf84c7a23b0168b4b208251c274a67a455954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CashierTeller_ViewAccount), @"mvc.1.0.view", @"/Views/CashierTeller/ViewAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1acf84c7a23b0168b4b208251c274a67a455954", @"/Views/CashierTeller/ViewAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b912b7d8c758ad7e2dbc5ab40c55a7a67d618261", @"/Views/_ViewImports.cshtml")]
    public class Views_CashierTeller_ViewAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Account>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\CashierTeller\ViewAccount.cshtml"
  
    ViewData["Title"] = "ViewAccount";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center"">Account Details</h1>

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

<table class=""table table-active table-striped"">
    <tr>
        <th>Customer ID</th>
        <th>Account ID</th>
        <th>Account Type</th>
        <th>Account Balance</th>
        <th>Deposit</th>
        <th>Withdraw</th>
        <th>Transfer</th>
    </tr>
    <tr>
        <td>");
#nullable restore
#line 34 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\CashierTeller\ViewAccount.cshtml"
       Write(Model.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\CashierTeller\ViewAccount.cshtml"
       Write(Model.AccountID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\CashierTeller\ViewAccount.cshtml"
       Write(Model.AccountType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>$");
#nullable restore
#line 37 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\CashierTeller\ViewAccount.cshtml"
        Write(Model.AccountBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\CashierTeller\ViewAccount.cshtml"
       Write(Html.ActionLink("Deposit", "Deposit", new { AccountID = Model.AccountID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 39 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\CashierTeller\ViewAccount.cshtml"
       Write(Html.ActionLink("Withdraw", "Withdraw", new { AccountID = Model.AccountID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 40 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\CashierTeller\ViewAccount.cshtml"
       Write(Html.ActionLink("Transfer","TransferAccount","Transaction", new { SourceAccountID = Model.AccountID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n<div style=\"text-align:center\">\r\n    ");
#nullable restore
#line 44 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\CashierTeller\ViewAccount.cshtml"
Write(Html.ActionLink("Back", "ViewAccountBySSNID"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
