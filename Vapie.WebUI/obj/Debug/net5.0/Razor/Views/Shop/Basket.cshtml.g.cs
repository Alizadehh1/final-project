#pragma checksum "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aa4d38b883de98c04d37dbe38627108394993e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Basket), @"mvc.1.0.view", @"/Views/Shop/Basket.cshtml")]
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
#line 1 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\_ViewImports.cshtml"
using Vapie.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\_ViewImports.cshtml"
using Vapie.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\_ViewImports.cshtml"
using Vapie.WebUI.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\_ViewImports.cshtml"
using Vapie.WebUI.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\_ViewImports.cshtml"
using Vapie.WebUI.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\_ViewImports.cshtml"
using Vapie.WebUI.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\_ViewImports.cshtml"
using Vapie.WebUI.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\_ViewImports.cshtml"
using Vapie.WebUI.AppCode.Modules.ProfileModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aa4d38b883de98c04d37dbe38627108394993e0", @"/Views/Shop/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"125fed54020bbc083de127e5474ec48233b6911f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("me-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #FDC040;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "singleproduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary me-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
  
    ViewData["Title"] = "Basket";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header breadcrumb-wrap\">\r\n    <div class=\"container\">\r\n        <div class=\"breadcrumb\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa4d38b883de98c04d37dbe38627108394993e08065", async() => {
                WriteLiteral("<i class=\"fa-solid fa-house me-1\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa4d38b883de98c04d37dbe38627108394993e09559", async() => {
                WriteLiteral("<i style=\"color: #FDC040;\" class=\"fa-solid fa-basket-shopping me-1\"></i>Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            > <i class=""fa-solid fa-cart-shopping""></i> Cart
        </div>
    </div>
    <div class=""col-12 mt-3 text-center text-uppercase"">
        <h2>Shopping Cart</h2>
    </div>
</div>
<div class=""col-12 bg-white py-3 mb-3"">
    <div class=""row"">
        <div class=""col-lg-6 col-md-8 col-sm-10 mx-auto table-responsive"">
");
#nullable restore
#line 21 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
             if (Model.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""d-flex flex-column justify-content-center align-items-center"">
                    <i class=""emptyBasket fa-solid fa-cart-shopping""></i>
                    <h1 class=""emptyBasketText"">Your Cart is empty</h1>
                </div>
");
#nullable restore
#line 27 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa4d38b883de98c04d37dbe38627108394993e012287", async() => {
                WriteLiteral(@"
                    <div class=""col-12"">
                        <table class=""table table-striped table-hover table-sm"">
                            <thead>
                                <tr>
                                    <th>Image</th>
                                    <th>Name</th>
                                    <th>Price</th>
                                    <th>Qty</th>
                                    <th>Amount</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 45 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                 foreach (var item in Model)
                                {
                                    var imagePath = item.Images.FirstOrDefault(i => i.IsMain == true).ImagePath;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr id=\"entityTr\" data-entity-id=\"");
#nullable restore
#line 48 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-quantity=\"1\" data-price=\"");
#nullable restore
#line 48 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                                                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                        <td style=\"display:flex;justify-content:center;\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa4d38b883de98c04d37dbe38627108394993e014437", async() => {
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8aa4d38b883de98c04d37dbe38627108394993e014658", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 2398, "~/uploads/images/", 2398, 17, true);
#nullable restore
#line 50 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
AddHtmlAttributeValue("", 2415, imagePath, 2415, 10, false);

#line default
#line hidden
#nullable disable
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                                                                                            WriteLiteral(item.CategoryId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa4d38b883de98c04d37dbe38627108394993e019304", async() => {
#nullable restore
#line 53 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                                                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                                                                                            WriteLiteral(item.CategoryId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 56 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ₼
                                        </td>
                                        <td>
                                            <button onclick=""minusQuantity(event)"" type=""button"" class=""btn btn-danger""><i class=""fa-solid fa-minus""></i></button>
                                            <span class=""quantity"">1</span>
                                            <button onclick=""plusQuantity(event)"" type=""button"" class=""btn btn-primary""><i class=""fa-solid fa-plus""></i></button>
                                        </td>
                                        <td class=""product-price"">
                                            <span class=""amount"">");
#nullable restore
#line 64 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₼</span>\r\n                                        </td>\r\n                                        <td>\r\n                                            <a");
                BeginWriteAttribute("onclick", " onclick=\"", 3688, "\"", 3720, 3);
                WriteAttributeValue("", 3698, "removeEntity(", 3698, 13, true);
#nullable restore
#line 67 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
WriteAttributeValue("", 3711, item.Id, 3711, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3719, ")", 3719, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-link text-danger\"><i class=\"fa-solid fa-trash-can\"></i></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 70 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tbody>
                            <tfoot>
                                <tr>
                                    <th colspan=""3"" class=""text-right"">Total</th>
                                    <th id=""totalPrice"">$4,000</th>
                                    <th></th>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                    <div class=""col-12 text-right"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa4d38b883de98c04d37dbe38627108394993e025692", async() => {
                    WriteLiteral("<i class=\"fa-solid fa-arrow-left-long me-1\"></i> Continue Shopping");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <a href=\"#\" class=\"btn btn-outline-success\">Checkout</a>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("js", async() => {
                WriteLiteral(@"
    <script>
        function checkCart() {
            let items = readFromBasket();
            var divContainer = $('<div>', {
                class: 'd-flex flex-column justify-content-center align-items-center'
            });
            var iTag = $('<i>', {
                class: 'emptyBasket fa-solid fa-cart-shopping'
            });
            var h1Tag = $('<h1>').text(""Your Cart is empty"").addClass(""emptyBasketText"");
            let divTag = $('div.table-responsive');
            if (items.length <= 1) {
                $('form.row').remove();
                iTag.appendTo(divContainer);
                h1Tag.appendTo(divContainer);
                divContainer.appendTo(divTag);
            }
        }
        function setTotalPrice() {
            let items = document.querySelectorAll('.amount');
            let totalPrice = 0;
            for (var i = 0; i < items.length; i++) {
                totalPrice = totalPrice + parseInt(items[i].textContent);
            }
  ");
                WriteLiteral(@"          $('#totalPrice').html(`${totalPrice}₼`);
            console.log(totalPrice);
        }
        setTotalPrice();
        function showCardCount() {
            let items = readFromBasket();
            $('#header-qty').html(items.length - 1);
        }
        function readFromBasket() {
            return ($.cookie('cards') || '').split(',');
        }
        function removeEntity(entityId) {
            let items = readFromBasket();
            let id = entityId.toString();
            const index = items.indexOf(id);
            if (index > -1) {
                items.splice(index, 1);
            }
            $.cookie('cards', items.toString(), { expires: 7, path: '/' });

            $.ajax({
                success: function (response) {
                    if (response.error == true) {
                        toastr.error(response.message, ""Error!"");
                        return;
                    }
                    toastr.success(""Successfully Deleted"", res");
                WriteLiteral(@"ponse.message)
                    $(`tr[data-entity-id=${entityId}]`).remove();
                    showCardCount();
                    setTotalPrice();
                    checkCart();
                },
                error: function (response) {
                    toastr[""error""](""Unsuccessfully"", ""Data has not been deleted"")
                }
            })
        }
        function plusQuantity(e) {
            e.preventDefault();
            let row = $(e.currentTarget).closest('tr');

            let data = $(row).data();

            let quantity = $(row).find('span.quantity').html();
            if (!isNaN(quantity)) {
                quantity++;
                $(row).data('quantity', quantity);
            }
            $(row).find('span.quantity').html(quantity);
            $(row).find('td.product-price .amount').html(`${(data.price * quantity)}₼`)
            setTotalPrice();
            console.log(data);
        }
        function minusQuantity(e) {
           ");
                WriteLiteral(@" e.preventDefault();
            let row = $(e.currentTarget).closest('tr');

            let data = $(row).data();

            let quantity = $(row).find('span.quantity').html();
            if (quantity == 1) {
                return;
            }
            if (!isNaN(quantity)) {
                quantity--;
                $(row).data('quantity', quantity);
            }
            $(row).find('span.quantity').html(quantity);
            $(row).find('td.product-price .amount').html(`${(data.price * quantity)}₼`)
            setTotalPrice();
            console.log(data);
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
