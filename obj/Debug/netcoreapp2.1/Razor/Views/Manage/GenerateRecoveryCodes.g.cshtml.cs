#pragma checksum "/Users/Jay/Desktop/WebSecurity/Views/Manage/GenerateRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3439a57d4ad08cb2dd3f0883b8c7b257552ea74f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_GenerateRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/GenerateRecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/GenerateRecoveryCodes.cshtml", typeof(AspNetCore.Views_Manage_GenerateRecoveryCodes))]
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
#line 1 "/Users/Jay/Desktop/WebSecurity/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/Jay/Desktop/WebSecurity/Views/_ViewImports.cshtml"
using WebSecurity;

#line default
#line hidden
#line 3 "/Users/Jay/Desktop/WebSecurity/Views/_ViewImports.cshtml"
using WebSecurity.Models;

#line default
#line hidden
#line 4 "/Users/Jay/Desktop/WebSecurity/Views/_ViewImports.cshtml"
using WebSecurity.Models.AccountViewModels;

#line default
#line hidden
#line 1 "/Users/Jay/Desktop/WebSecurity/Views/Manage/GenerateRecoveryCodes.cshtml"
using WebSecurity.Models.ManageViewModels;

#line default
#line hidden
#line 1 "/Users/Jay/Desktop/WebSecurity/Views/Manage/_ViewImports.cshtml"
using WebSecurity.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3439a57d4ad08cb2dd3f0883b8c7b257552ea74f", @"/Views/Manage/GenerateRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"734e7ddaedefaad293f19d8df704083117c7bd7d", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be57db1c14b3eb3a2992542539560f7738b1c0e", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_GenerateRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSecurity.Models.ManageViewModels.GenerateRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/Jay/Desktop/WebSecurity/Views/Manage/GenerateRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Codes de récupération";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
            BeginContext(245, 186, true);
            WriteLiteral("\r\n<div class=\"mdl-grid\">\r\n<div class=\"mdl-cell mdl-cell--4-col-desktop mdl-cell--4-offset-desktop mdl-cell--6-col-tablet mdl-cell--1-offset-tablet mdl-cell--4-col-phone\">\r\n    \r\n    <h4>");
            EndContext();
            BeginContext(432, 17, false);
#line 11 "/Users/Jay/Desktop/WebSecurity/Views/Manage/GenerateRecoveryCodes.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(449, 472, true);
            WriteLiteral(@"</h4>
    <div class=""alert alert-warning"" role=""alert"">
        <p>
            <span class=""glyphicon glyphicon-warning-sign""></span>
            <strong>Veuillez précieusement conserver ces codes.</strong>
        </p>
        <p style=""color: red"">
            Si vous égarez votre appareil et ne disporez plus de ces codes de recouvrement, vous allez perdre tout accès à votre compte.
        </p>
    </div>
    
    <ul class=""demo-list-icon mdl-list"">
");
            EndContext();
#line 23 "/Users/Jay/Desktop/WebSecurity/Views/Manage/GenerateRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Count(); row += 2)
        {

#line default
#line hidden
            BeginContext(1005, 206, true);
            WriteLiteral("            <li class=\"mdl-list__item\">\r\n                <span class=\"mdl-list__item-primary-content\">\r\n                    <i class=\"material-icons mdl-list__item-icon\">lock</i>\r\n                    <code>");
            EndContext();
            BeginContext(1212, 24, false);
#line 28 "/Users/Jay/Desktop/WebSecurity/Views/Manage/GenerateRecoveryCodes.cshtml"
                     Write(Model.RecoveryCodes[row]);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 32, true);
            WriteLiteral("</code><text>&nbsp;</text><code>");
            EndContext();
            BeginContext(1269, 28, false);
#line 28 "/Users/Jay/Desktop/WebSecurity/Views/Manage/GenerateRecoveryCodes.cshtml"
                                                                              Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
            EndContext();
            BeginContext(1297, 68, true);
            WriteLiteral("</code><br/>\r\n        \r\n                </span>\r\n            </li>\r\n");
            EndContext();
#line 32 "/Users/Jay/Desktop/WebSecurity/Views/Manage/GenerateRecoveryCodes.cshtml"
        }

#line default
#line hidden
            BeginContext(1376, 35, true);
            WriteLiteral("        \r\n    </ul>\r\n</div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSecurity.Models.ManageViewModels.GenerateRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
