#pragma checksum "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b75b4a7260d031801f8af2330b5098819dff8b10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ElectronicStore.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__ManageNav), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_ManageNav.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Manage/_ManageNav.cshtml", typeof(ElectronicStore.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__ManageNav))]
namespace ElectronicStore.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\_ViewImports.cshtml"
using ElectronicStore.Areas.Identity;

#line default
#line hidden
#line 1 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ElectronicStore.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using ElectronicStore.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b75b4a7260d031801f8af2330b5098819dff8b10", @"/Areas/Identity/Pages/Account/Manage/_ManageNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3073c545da683377888d467207f861bb06b4dc1c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ffdd7fc6c546ea307ee4c6df109f62daf73a12", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72bde5cde123085f95bdba4b4ca724cac7c5960", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__ManageNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("orders"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
  
    var hasExternalLogins = (await SignInManager.GetExternalAuthenticationSchemesAsync()).Any();

#line default
#line hidden
            BeginContext(156, 47, true);
            WriteLiteral("<ul class=\"nav nav-pills nav-stacked\">\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 203, "\"", 253, 1);
#line 6 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 211, ManageNavPages.IndexNavClass(ViewContext), 211, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(254, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 257, "\"", 325, 1);
#line 6 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 264, Url.Page("/Account/Manage/Index", new { area = "Identity" }), 264, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(326, 27, true);
            WriteLiteral(" >Profile</a></li>\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 353, "\"", 405, 1);
#line 7 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 361, ManageNavPages.YourOrdersClass(ViewContext), 361, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(406, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(407, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd9f640174c74097adb9b8adf097e0c8", async() => {
                BeginContext(500, 11, true);
                WriteLiteral("Your Orders");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            BeginContext(515, 14, true);
            WriteLiteral("</li>\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 529, "\"", 588, 1);
#line 8 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 537, ManageNavPages.ChangePasswordNavClass(ViewContext), 537, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(589, 24, true);
            WriteLiteral("><a id=\"change-password\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 613, "\"", 690, 1);
#line 8 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 620, Url.Page("/Account/Manage/ChangePassword", new { area = "Identity" }), 620, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(691, 20, true);
            WriteLiteral(">Password</a></li>\r\n");
            EndContext();
#line 9 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
     if (hasExternalLogins)
    {

#line default
#line hidden
            BeginContext(747, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 758, "\"", 817, 1);
#line 11 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 766, ManageNavPages.ExternalLoginsNavClass(ViewContext), 766, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(818, 23, true);
            WriteLiteral("><a id=\"external-login\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 841, "\"", 918, 1);
#line 11 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 848, Url.Page("/Account/Manage/ExternalLogins", new { area = "Identity" }), 848, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(919, 27, true);
            WriteLiteral(">External logins</a></li>\r\n");
            EndContext();
#line 12 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
    }

#line default
#line hidden
            BeginContext(953, 7, true);
            WriteLiteral("    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 960, "\"", 1028, 1);
#line 13 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 968, ManageNavPages.TwoFactorAuthenticationNavClass(ViewContext), 968, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1029, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1032, "\"", 1118, 1);
#line 13 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 1039, Url.Page("/Account/Manage/TwoFactorAuthentication", new { area = "Identity" }), 1039, 79, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1119, 44, true);
            WriteLiteral(">Two-factor authentication</a></li>\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1163, "\"", 1220, 1);
#line 14 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 1171, ManageNavPages.PersonalDataNavClass(ViewContext), 1171, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1221, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1224, "\"", 1299, 1);
#line 14 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Identity\Pages\Account\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 1231, Url.Page("/Account/Manage/PersonalData", new { area = "Identity" }), 1231, 68, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1300, 32, true);
            WriteLiteral(">Personal data</a></li>\r\n</ul>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1349, 191, true);
                WriteLiteral(" \r\n    <script>\r\n        $(\"#orders\").on(\'click\', function () {\r\n            $(\'#orders\').removeClass(\'active\');\r\n            $(\"#oders\").addClass(\'active\');\r\n            });\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
