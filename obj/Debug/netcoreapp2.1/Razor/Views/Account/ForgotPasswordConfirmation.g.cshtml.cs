#pragma checksum "/Users/anisouddai/Desktop/WebSecurity/Views/Account/ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "854dad954f62649fa227dded560c6be4e024e445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ForgotPasswordConfirmation), @"mvc.1.0.view", @"/Views/Account/ForgotPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ForgotPasswordConfirmation.cshtml", typeof(AspNetCore.Views_Account_ForgotPasswordConfirmation))]
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
#line 1 "/Users/anisouddai/Desktop/WebSecurity/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/anisouddai/Desktop/WebSecurity/Views/_ViewImports.cshtml"
using WebSecurity;

#line default
#line hidden
#line 3 "/Users/anisouddai/Desktop/WebSecurity/Views/_ViewImports.cshtml"
using WebSecurity.Models;

#line default
#line hidden
#line 4 "/Users/anisouddai/Desktop/WebSecurity/Views/_ViewImports.cshtml"
using WebSecurity.Models.AccountViewModels;

#line default
#line hidden
#line 5 "/Users/anisouddai/Desktop/WebSecurity/Views/_ViewImports.cshtml"
using WebSecurity.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"854dad954f62649fa227dded560c6be4e024e445", @"/Views/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"734e7ddaedefaad293f19d8df704083117c7bd7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/anisouddai/Desktop/WebSecurity/Views/Account/ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";

#line default
#line hidden
            BeginContext(64, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(71, 17, false);
#line 5 "/Users/anisouddai/Desktop/WebSecurity/Views/Account/ForgotPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(88, 80, true);
            WriteLiteral("</h2>\r\n<p>\r\n   Svp verifiez votre email pour changer votre mot de passe.\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591