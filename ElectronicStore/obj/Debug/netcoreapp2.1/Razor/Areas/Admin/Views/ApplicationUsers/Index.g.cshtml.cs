#pragma checksum "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6e62ef81dd7afbc6f3a2d99c5050ec27a6934b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ApplicationUsers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ApplicationUsers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ApplicationUsers/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ApplicationUsers_Index))]
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
#line 1 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\_ViewImports.cshtml"
using ElectronicStore;

#line default
#line hidden
#line 2 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\_ViewImports.cshtml"
using ElectronicStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd6e62ef81dd7afbc6f3a2d99c5050ec27a6934b", @"/Areas/Admin/Views/ApplicationUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9abd6fbc28e37e17d77965cfae964e8075c00fc3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ApplicationUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ElectronicStore.Models.ApplicationUsers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/CreateAdminUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 195, true);
            WriteLiteral("\r\n<br /> <br />\r\n<div>\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\">Users List</h2>\r\n        </div>\r\n        <div class=\"col-5 text-right\">\r\n            ");
            EndContext();
            BeginContext(350, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08b55a3ebe6040b3ab0da9ac3b88478f", async() => {
                BeginContext(430, 43, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp; New User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(477, 312, true);
            WriteLiteral(@"
        </div>
        <div class=""col-1"">

        </div>
    </div>
    <br />
    <div class=""container-fluid"">
        <div>
            <table class=""table table-striped border"">
                <tr class=""table-info"">
                    <th style=""text-align:center"">
                        ");
            EndContext();
            BeginContext(790, 36, false);
#line 26 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(826, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(932, 33, false);
#line 29 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(965, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(1071, 39, false);
#line 32 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(1216, 35, false);
#line 35 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 310, true);
            WriteLiteral(@"
                    </th>
                    <th style=""text-align:center"">
                        Role
                    </th>
                    <th>
                        Disabled
                    </th>
                    <th></th>
                    <th></th>
                </tr>
");
            EndContext();
#line 46 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1626, 98, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(1725, 35, false);
#line 50 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                   Write(Html.DisplayFor(m => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1760, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(1982, 76, true);
            WriteLiteral("                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(2059, 32, false);
#line 56 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(2197, 38, false);
#line 59 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                   Write(Html.DisplayFor(m => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2235, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(2341, 34, false);
#line 62 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2375, 81, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n");
            EndContext();
#line 65 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                         if (item.IsSupperAdmin)
                        {

#line default
#line hidden
            BeginContext(2533, 50, true);
            WriteLiteral("                            <label>Admin</label>\r\n");
            EndContext();
#line 68 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2667, 52, true);
            WriteLiteral("                            <label>Shipper</label>\r\n");
            EndContext();
#line 72 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2746, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 75 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                         if (item.LockoutEnd != null && item.LockoutEnd > DateTime.Now)
                        {

#line default
#line hidden
            BeginContext(2915, 53, true);
            WriteLiteral("                            <label>Disabled</label>\r\n");
            EndContext();
#line 78 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2995, 84, true);
            WriteLiteral("                    </td>\r\n                    <td></td>\r\n                    <td>\r\n");
            EndContext();
#line 82 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                         if (item.LockoutEnd == null || item.LockoutEnd < DateTime.Now)
                        {


#line default
#line hidden
            BeginContext(3197, 67, true);
            WriteLiteral("                            <a type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3264, "\"", 3301, 1);
#line 85 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
WriteAttributeValue("", 3271, Url.Action("Delete/"+item.Id), 3271, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3302, 39, true);
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i></a>\r\n");
            EndContext();
#line 86 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3368, 52, true);
            WriteLiteral("                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 90 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\ApplicationUsers\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3439, 60, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ElectronicStore.Models.ApplicationUsers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
