#pragma checksum "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5ee71405f7354d81e3856a9907a7c5ca795f0f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Shipper_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Shipper/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Shipper/Views/Home/Details.cshtml", typeof(AspNetCore.Areas_Shipper_Views_Home_Details))]
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
#line 1 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\_ViewImports.cshtml"
using ElectronicStore;

#line default
#line hidden
#line 2 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\_ViewImports.cshtml"
using ElectronicStore.Models;

#line default
#line hidden
#line 2 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
using ElectronicStore.Extensions;

#line default
#line hidden
#line 3 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
using ElectronicStore.Data;

#line default
#line hidden
#line 4 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
using ElectronicStore.Ultilities;

#line default
#line hidden
#line 5 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5ee71405f7354d81e3856a9907a7c5ca795f0f4", @"/Areas/Shipper/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9abd6fbc28e37e17d77965cfae964e8075c00fc3", @"/Areas/Shipper/Views/_ViewImports.cshtml")]
    public class Areas_Shipper_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ElectronicStore.Models.ViewModels.ShipperForOrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("billName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("billTime"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shipper/Shared/_Layout.cshtml";
    double sum = 0;
    double total = 0;
    double shippingFee = 500000;

#line default
#line hidden
#line 13 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
  
    var _db = (ApplicationDbContext)ViewData["DbContext"];
    var productList = _db.ProductSelectedForOrders.Include(p => p.Products).Include(p => p.Orders).Where(p => p.OrderId == Model.Orders.Id).ToList();


#line default
#line hidden
            BeginContext(601, 464, true);
            WriteLiteral(@"<br />
<br />
<h2>Order Details</h2>
<div class=""container row"">
    <div class=""col-lg-8"">
        <h4 class=""text-dark"">SHIPPING ADDRESS</h4>

        <hr />
        <div class=""row"">
            <div class=""col-4"">
                <label class=""text-dark"">Customer Name:</label>
            </div>
            <div class=""col-8 text-left"">
                <label style=""font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif"">");
            EndContext();
            BeginContext(1066, 31, false);
#line 31 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                                                                       Write(Model.Orders.Customers.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1097, 337, true);
            WriteLiteral(@" </label>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-4"">
                <label class=""text-dark"">Address:</label>
            </div>
            <div class=""col-8 text-left"">
                <label style=""font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif"">");
            EndContext();
            BeginContext(1435, 38, false);
#line 39 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                                                                       Write(Model.Orders.Customers.ShippingAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1473, 336, true);
            WriteLiteral(@"</label>

            </div>
        </div>
        <div class=""row"">
            <div class=""col-4"">
                <label class=""text-dark"">Phone:</label>
            </div>
            <div class=""col-8 text-left"">
                <label style=""font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif"">");
            EndContext();
            BeginContext(1810, 34, false);
#line 48 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                                                                       Write(Model.Orders.Customers.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1844, 460, true);
            WriteLiteral(@"</label>
            </div>
        </div>
        <hr />
        <h4 class=""text-dark"">SHIPPING METHODS</h4>
        <hr />
        <div class=""row"">
            <div class=""col-2"">
                <input type=""checkbox"" class=""checkbox"" checked disabled />
            </div>
            <div class=""col-10 text-left"">
                <label style=""font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif""><b>Standard</b>(VND ");
            EndContext();
            BeginContext(2305, 24, false);
#line 59 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                                                                                           Write(Model.Orders.ShippingFee);

#line default
#line hidden
            EndContext();
            BeginContext(2329, 625, true);
            WriteLiteral(@")</label>
            </div>
        </div>
        <br />
        <br />
        <div class=""row"">
            <div class=""col-2"">
            </div>
            <div class=""col-10 text-right"">
                <a href='javascript:history.go(-1)' class=""btn btn-primary"">Back to List</a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <h4 class=""text-dark"">ORDER SUMMARY</h4>
        <hr />
        <div class=""row"">
            <div class=""col-4"">
                <label class=""text-dark"">Order Name:</label>
            </div>
            <div class=""col-8 text-left"">
");
            EndContext();
            BeginContext(3122, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3138, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22e92302b2c14bf7b932046da9c5f55a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 81 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Orders.BillName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3236, 223, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                <label class=\"text-dark\">Order Time:</label>\r\n            </div>\r\n            <div class=\"col-8 text-left\">\r\n");
            EndContext();
            BeginContext(3630, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3646, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cce33562d3084316a5030020fd229674", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 90 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Orders.CreatedDate);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3747, 450, true);
            WriteLiteral(@"
            </div>
        </div>
        <hr />

        <div class=""row"">
            <table class=""table table-striped"">
                <tr class=""table-dark"">
                    <th style=""text-align:center"">PRODUCTS</th>
                    <th></th>
                    <th></th>
                    <th style=""text-align:center"">QUANTITY</th>
                    <th style=""text-align:center"">PRICE</th>
                </tr>
");
            EndContext();
#line 104 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                 for (int i = 0; i < productList.Count; i++)
                {

#line default
#line hidden
            BeginContext(4278, 81, true);
            WriteLiteral("                    <tr>\r\n                        <td style=\"text-align:center;\">");
            EndContext();
            BeginContext(4360, 28, false);
#line 107 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                  Write(productList[i].Products.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4388, 132, true);
            WriteLiteral("</td>\r\n                        <td></td>\r\n                        <td></td>\r\n                        <td style=\"text-align:center;\">");
            EndContext();
            BeginContext(4521, 30, false);
#line 110 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                  Write(productList[i].ProductQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(4551, 64, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center;\">\r\n");
            EndContext();
#line 112 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                             if (@productList[i].Products.PromotionPrice > 0)
                            {
                                

#line default
#line hidden
            BeginContext(4758, 61, false);
#line 114 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(c => @productList[i].Products.PromotionPrice));

#line default
#line hidden
            EndContext();
#line 114 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                                                              ;
                                sum += @productList[i].Products.PromotionPrice * @productList[i].ProductQuantity;
                            }
                            else
                            {
                                

#line default
#line hidden
            BeginContext(5066, 52, false);
#line 119 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                           Write(Html.DisplayFor(c => @productList[i].Products.Price));

#line default
#line hidden
            EndContext();
#line 119 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                                                     ;
                                sum += @productList[i].Products.Price * @productList[i].ProductQuantity;
                            }

#line default
#line hidden
            BeginContext(5258, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 124 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(5335, 360, true);
            WriteLiteral(@"            </table>
        </div>
        <hr />
        <div class=""row"">
            <div class=""col-4"">
                <label class=""text-dark"">Subtotal:</label>
            </div>
            <div class=""col-8"" style=""text-align:right"">
                <label style=""font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif"">");
            EndContext();
            BeginContext(5696, 3, false);
#line 133 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                                                                       Write(sum);

#line default
#line hidden
            EndContext();
            BeginContext(5699, 244, true);
            WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                <label class=\"text-dark\">Shipping:</label>\r\n            </div>\r\n            <div class=\"col-8\" style=\"text-align:right\">\r\n");
            EndContext();
            BeginContext(6113, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(6129, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0023f1f38444e8f827cc56f90749ebf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 142 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Orders.ShippingFee);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#line 142 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                                                                                         WriteLiteral(Model.Orders.ShippingFee);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6275, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 145 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
          
            total = sum + shippingFee;
        

#line default
#line hidden
            BeginContext(6376, 200, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                <label class=\"text-dark\">OrderTotal:</label>\r\n            </div>\r\n            <div class=\"col-8\" style=\"text-align:right\">\r\n");
            EndContext();
            BeginContext(6742, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(6758, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "029083f83646406f9daf1bd4c05efe3f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 154 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Orders.TotalPrice);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#line 154 "D:\Coding\ASP.NET\Backup\ElectronicStore1707\ElectronicStore\ElectronicStore\Areas\Shipper\Views\Home\Details.cshtml"
                                                                                                                        WriteLiteral(Model.Orders.TotalPrice);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6902, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ElectronicStore.Models.ViewModels.ShipperForOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591