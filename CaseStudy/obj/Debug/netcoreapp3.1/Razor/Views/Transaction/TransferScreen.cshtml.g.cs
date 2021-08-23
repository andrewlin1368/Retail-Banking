#pragma checksum "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f97399f18f69fb5102bb0e969bac672f42bc7a77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_TransferScreen), @"mvc.1.0.view", @"/Views/Transaction/TransferScreen.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
using CaseStudy.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f97399f18f69fb5102bb0e969bac672f42bc7a77", @"/Views/Transaction/TransferScreen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b912b7d8c758ad7e2dbc5ab40c55a7a67d618261", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_TransferScreen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TransferViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
  
    ViewData["Title"] = "TransferScreen";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center"">Transfer Screen</h1>
<style>
    div {
        background: white;
        background: linear-gradient(to right,#f6ebe6,#aee1f9);
    }
    table, tr, td {
        margin-left: auto;
        margin-right: auto;
        padding: 10px;
        border: 1px solid black;
    }

    input[type=""submit""] {
        display: block;
        margin-left: auto;
        margin-right: auto;
    }
</style>
    <table>
        <tr>
            <td>
                Source account ID
            </td>
            <td>
                ");
#nullable restore
#line 33 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
           Write(Html.DisplayTextFor(a=>a.SourceAccountID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Target account ID\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
           Write(Html.DisplayTextFor(a => a.TargetAccountID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Source account initial balance\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
           Write(Html.DisplayTextFor(a => a.SourceCurrentBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Target account initial balance\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
           Write(Html.DisplayTextFor(a => a.TargetCurrentBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Source account updated balance\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
           Write(Html.DisplayTextFor(a => a.SourceUpdatedBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               \r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Target account updated balance\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
           Write(Html.DisplayTextFor(a => a.TargetUpdatedBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               \r\n            </td>\r\n        </tr>\r\n    </table>\r\n    <div style=\"color:green\">\r\n        <p style=\"text-align:center\">");
#nullable restore
#line 84 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
                                Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div style=\"color:red\">\r\n       <p style=\"text-align:center\">");
#nullable restore
#line 87 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
                               Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div style=\"text-align:center\">\r\n        ");
#nullable restore
#line 90 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
   Write(Html.ActionLink("Return to Transfer", "TransferAccount", new { SourceAccountID = Model.SourceAccountID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n<div style=\"text-align:center\">\r\n");
#nullable restore
#line 93 "C:\Users\Andrew\source\repos\CaseStudy\CaseStudy\Views\Transaction\TransferScreen.cshtml"
Write(Html.ActionLink("CANCEL","ViewAccountBySSNID","CashierTeller"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TransferViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591