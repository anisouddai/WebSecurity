#pragma checksum "/Users/anisouddai/Desktop/WebSecurity/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a86d08ae38562a272e402b55b57f2787fd534f95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a86d08ae38562a272e402b55b57f2787fd534f95", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"734e7ddaedefaad293f19d8df704083117c7bd7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/anisouddai/Desktop/WebSecurity/Views/Home/Dashboard.cshtml"
   
    ViewData["Title"] = "Accueil"; 

#line default
#line hidden
            BeginContext(145, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 8 "/Users/anisouddai/Desktop/WebSecurity/Views/Home/Dashboard.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    

#line default
#line hidden
            BeginContext(190, 44, false);
#line 10 "/Users/anisouddai/Desktop/WebSecurity/Views/Home/Dashboard.cshtml"
Write(await Component.InvokeAsync("UserDashboard"));

#line default
#line hidden
            EndContext();
#line 10 "/Users/anisouddai/Desktop/WebSecurity/Views/Home/Dashboard.cshtml"
                                                 
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
