#pragma checksum "/Users/anisouddai/Desktop/WebSecurity/Views/Shared/Components/UserDashboard/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87b6176b23d74a8eb75317a53cc80a7f072b7417"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserDashboard/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/UserDashboard/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_UserDashboard_Default))]
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
#line 1 "/Users/anisouddai/Desktop/WebSecurity/Views/Shared/Components/UserDashboard/Default.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/anisouddai/Desktop/WebSecurity/Views/_ViewImports.cshtml"
using WebSecurity;

#line default
#line hidden
#line 2 "/Users/anisouddai/Desktop/WebSecurity/Views/Shared/Components/UserDashboard/Default.cshtml"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b6176b23d74a8eb75317a53cc80a7f072b7417", @"/Views/Shared/Components/UserDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"734e7ddaedefaad293f19d8df704083117c7bd7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdl-button mdl-js-button mdl-button--accent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JournalEntries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(63, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(166, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(190, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 9 "/Users/anisouddai/Desktop/WebSecurity/Views/Shared/Components/UserDashboard/Default.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(230, 38, true);
            WriteLiteral("    <div class=\"mdl-grid\">\n    </div>\n");
            EndContext();
            BeginContext(269, 134, true);
            WriteLiteral("    <div class=\"mdl-grid\">\n        <div class=\"mdl-cell mdl-cell--4-col-desktop mdl-cell--4-offset-desktop\">\n            <h1>Bonjour, ");
            EndContext();
            BeginContext(404, 15, false);
#line 16 "/Users/anisouddai/Desktop/WebSecurity/Views/Shared/Components/UserDashboard/Default.cshtml"
                    Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(419, 50, true);
            WriteLiteral("!</h1>\n            <hr>\n        </div>\n    </div>\n");
            EndContext();
            BeginContext(470, 49, true);
            WriteLiteral("    <div class=\"mdl-grid\" id=\"content-wrapper\">\n\n");
            EndContext();
#line 23 "/Users/anisouddai/Desktop/WebSecurity/Views/Shared/Components/UserDashboard/Default.cshtml"
         if (User.IsInRole("Administrator"))
        {

#line default
#line hidden
            BeginContext(574, 148, true);
            WriteLiteral("            <div class=\"mdl-cell mdl-cell--4-col-desktop mdl-cell--2-offset-desktop\">\n                <h3>Journal d\'entrées</h3>\n                <p>");
            EndContext();
            BeginContext(722, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b56d8c2d6274c908c291e141d5ba7e6", async() => {
                BeginContext(829, 90, true);
                WriteLiteral("<i class=\"fa fa-chevron-circle-right fa-fw\"></i> Afficher le journal d\'entrées des clients");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(923, 24, true);
            WriteLiteral("</p>\n            </div>\n");
            EndContext();
#line 29 "/Users/anisouddai/Desktop/WebSecurity/Views/Shared/Components/UserDashboard/Default.cshtml"
        }

#line default
#line hidden
            BeginContext(957, 9, true);
            WriteLiteral("        \n");
            EndContext();
#line 31 "/Users/anisouddai/Desktop/WebSecurity/Views/Shared/Components/UserDashboard/Default.cshtml"
         if (User.IsInRole("ResidentialCustomerAgent") || User.IsInRole("BusinessCustomerAgent") || User.IsInRole("Administrator"))
        {

#line default
#line hidden
            BeginContext(1108, 138, true);
            WriteLiteral("            <div class=\"mdl-cell mdl-cell--4-col-desktop mdl-cell--2-offset-desktop\">\n                <h3>Clients</h3>\n                <p>");
            EndContext();
            BeginContext(1246, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c9ccd13c4f443b6a01a59f5d5af47e2", async() => {
                BeginContext(1343, 79, true);
                WriteLiteral("<i class=\"fa fa-chevron-circle-right fa-fw\"></i> Consulter la liste des clients");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1426, 24, true);
            WriteLiteral("</p>\n            </div>\n");
            EndContext();
#line 37 "/Users/anisouddai/Desktop/WebSecurity/Views/Shared/Components/UserDashboard/Default.cshtml"
        }

#line default
#line hidden
            BeginContext(1460, 156, true);
            WriteLiteral("        \n\n\n        <div class=\"mdl-cell mdl-cell--4-col-desktop mdl-cell--2-offset-desktop\">\n            <h3>Changez votre mot de passe</h3>\n            <p>");
            EndContext();
            BeginContext(1616, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f50abdd35876497d885948ee51396da6", async() => {
                BeginContext(1723, 81, true);
                WriteLiteral("<i class=\"fa fa-chevron-circle-right fa-fw\"></i> Créez et changez de mot de passe");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1808, 32, true);
            WriteLiteral("</p>\n        </div>\n\n    </div>\n");
            EndContext();
#line 47 "/Users/anisouddai/Desktop/WebSecurity/Views/Shared/Components/UserDashboard/Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
