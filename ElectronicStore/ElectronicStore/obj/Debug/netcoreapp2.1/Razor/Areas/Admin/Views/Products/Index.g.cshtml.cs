#pragma checksum "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f5bcbe659f65821b32eb82f02797bc389e4890d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f5bcbe659f65821b32eb82f02797bc389e4890d", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9abd6fbc28e37e17d77965cfae964e8075c00fc3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ElectronicStore.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 198, true);
            WriteLiteral("\r\n<br /> <br />\r\n<div>\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\">Products List</h2>\r\n        </div>\r\n        <div class=\"col-5 text-right\">\r\n            ");
            EndContext();
            BeginContext(345, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f03a56afcd8e4463b7ea500634c9ac56", async() => {
                BeginContext(389, 46, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp; New Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(439, 312, true);
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
            BeginContext(752, 32, false);
#line 26 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(784, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(890, 34, false);
#line 29 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Images));

#line default
#line hidden
            EndContext();
            BeginContext(924, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(1030, 32, false);
#line 32 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(1168, 33, false);
#line 35 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(1307, 42, false);
#line 38 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.PromotionPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(1455, 43, false);
#line 41 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.ProductCategory));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(1604, 34, false);
#line 44 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Brands));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(1744, 39, false);
#line 47 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1783, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(1889, 40, false);
#line 50 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1929, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(2035, 34, false);
#line 53 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2069, 105, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(2175, 38, false);
#line 56 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.ShowOnHome));

#line default
#line hidden
            EndContext();
            BeginContext(2213, 114, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n");
            EndContext();
#line 61 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2392, 98, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(2491, 31, false);
#line 65 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2522, 109, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2631, "\"", 2649, 1);
#line 68 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 2637, item.Images, 2637, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2650, 191, true);
            WriteLiteral(" width=\"25%\" style=\"border-radius:5px; border: 1px solid #bbb9b9;\" alt=\"Card Image\" />\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(2842, 31, false);
#line 71 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Code));

#line default
#line hidden
            EndContext();
            BeginContext(2873, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(2979, 32, false);
#line 74 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3011, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(3117, 41, false);
#line 77 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.PromotionPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3158, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(3264, 47, false);
#line 80 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.ProductCategory.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3311, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(3417, 38, false);
#line 83 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Brands.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3455, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(3561, 38, false);
#line 86 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3599, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(3705, 39, false);
#line 89 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.ModifiedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3744, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(3850, 33, false);
#line 92 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3883, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(3989, 37, false);
#line 95 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(m => item.ShowOnHome));

#line default
#line hidden
            EndContext();
            BeginContext(4026, 105, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align:center\">\r\n                        ");
            EndContext();
            BeginContext(4131, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8cb10b4196f4058997c3ac3c6ebf95d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 98 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Convert.ToInt32(item.Id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4203, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 101 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Products\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4274, 64, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ElectronicStore.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
