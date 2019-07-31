#pragma checksum "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e47b81fcdb75436ffcce7d708675d557e390b5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Pending), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Pending.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Orders/Pending.cshtml", typeof(AspNetCore.Areas_Admin_Views_Orders_Pending))]
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
#line 2 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
using ElectronicStore.Data;

#line default
#line hidden
#line 3 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e47b81fcdb75436ffcce7d708675d557e390b5c", @"/Areas/Admin/Views/Orders/Pending.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9abd6fbc28e37e17d77965cfae964e8075c00fc3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Orders_Pending : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ElectronicStore.Models.ShipperAssignedForOrder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Admin/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(222, 1313, true);
            WriteLiteral(@"
<div>
    <div class=""row"">
        <div class=""col-6"">
            <h2 class=""text-info"">Orders List</h2>
        </div>
        <div class=""col-6"">

        </div>
    </div>
    <div class=""row"">
        <div>
            <table class=""table table-striped"">
                <tr>
                    <th style=""text-align:center"">
                        Shipper
                    </th>
                    <th style=""text-align:center"">
                        Order Name
                    </th>
                    <th style=""text-align:center"">
                        Created Date
                    </th>
                    <th style=""text-align:center"">
                        Customer Name
                    </th>
                    <th style=""text-align:center"">
                        Shipping Fee
                    </th>
                    <th style=""text-align:center"">
                        Total Price
                    </th>
                    <th style=""t");
            WriteLiteral(@"ext-align:center"">
                        Shipper Confirmation
                    </th>
                    <th style=""text-align:center"">
                        Status
                    </th>
                    <th></th>
                    <th></th>
                </tr>
");
            EndContext();
#line 49 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                 foreach (var item in Model)
                {
                    
                    

#line default
#line hidden
            BeginContext(1644, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 54 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                      
                        ApplicationDbContext db = (ApplicationDbContext)ViewData["DbContext"];
                        var CustomerName = (from u in db.ApplicationUsers
                                            join or in db.Orders on u.Id equals or.CustomerId
                                            where or.Id == item.OrderId
                                            select u.FullName);
                        var Orders = (from u in db.ApplicationUsers
                                      join or in db.Orders on u.Id equals or.CustomerId
                                      where or.Id == item.OrderId
                                      select or.ShipperConfirm);
                    

#line default
#line hidden
            BeginContext(2408, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 65 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                     if (!Orders.FirstOrDefault())
                    {

#line default
#line hidden
            BeginContext(2483, 84, true);
            WriteLiteral("                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(2568, 44, false);
#line 68 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Shippers.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2612, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(2730, 42, false);
#line 71 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.BillName));

#line default
#line hidden
            EndContext();
            BeginContext(2772, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(2890, 45, false);
#line 74 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2935, 119, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n\r\n                            ");
            EndContext();
            BeginContext(3055, 34, false);
#line 78 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(3089, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(3207, 45, false);
#line 81 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.ShippingFee));

#line default
#line hidden
            EndContext();
            BeginContext(3252, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(3370, 44, false);
#line 84 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3414, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(3532, 48, false);
#line 87 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.ShipperConfirm));

#line default
#line hidden
            EndContext();
            BeginContext(3580, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(3698, 40, false);
#line 90 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3738, 161, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"btn-group\" role=\"group\">\r\n                                ");
            EndContext();
            BeginContext(3899, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b20023e06c3486eb9fb01ff19139301", async() => {
                BeginContext(3995, 37, true);
                WriteLiteral("<i class=\"fas fa-clipboard-list\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4036, 69, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n");
            EndContext();
#line 97 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                    }
                    else if(item.Orders.ShipperConfirm && !item.Orders.Status)
                    {

#line default
#line hidden
            BeginContext(4231, 84, true);
            WriteLiteral("                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(4316, 44, false);
#line 101 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Shippers.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(4360, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(4478, 42, false);
#line 104 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.BillName));

#line default
#line hidden
            EndContext();
            BeginContext(4520, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(4638, 45, false);
#line 107 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(4683, 119, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n\r\n                            ");
            EndContext();
            BeginContext(4803, 34, false);
#line 111 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(4837, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(4955, 45, false);
#line 114 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.ShippingFee));

#line default
#line hidden
            EndContext();
            BeginContext(5000, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(5118, 44, false);
#line 117 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(5162, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(5280, 48, false);
#line 120 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.ShipperConfirm));

#line default
#line hidden
            EndContext();
            BeginContext(5328, 117, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
            EndContext();
            BeginContext(5446, 40, false);
#line 123 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                       Write(Html.DisplayFor(c => item.Orders.Status));

#line default
#line hidden
            EndContext();
            BeginContext(5486, 163, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <div class=\"btn-group\" role=\"group\">\r\n\r\n                                ");
            EndContext();
            BeginContext(5649, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb208432bd6043058dae60521a2d6338", async() => {
                BeginContext(5752, 38, true);
                WriteLiteral("<i class=\"fas fa-clipboard-check\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 128 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                                                                                                          WriteLiteral(item.Orders.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5794, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(5828, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4036fa0a7430413eb5263c18e8d31fc0", async() => {
                BeginContext(5924, 37, true);
                WriteLiteral("<i class=\"fas fa-clipboard-list\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 129 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5965, 69, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n");
            EndContext();
#line 132 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                    }

#line default
#line hidden
            BeginContext(6057, 25, true);
            WriteLiteral("\r\n                </tr>\r\n");
            EndContext();
#line 135 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Admin\Views\Orders\Pending.cshtml"
                }

#line default
#line hidden
            BeginContext(6101, 60, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ElectronicStore.Models.ShipperAssignedForOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591