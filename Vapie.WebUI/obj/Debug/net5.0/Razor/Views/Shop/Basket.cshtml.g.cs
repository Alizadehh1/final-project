#pragma checksum "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "845c0036e21d9349ddc9595663a74a5211610c30"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"845c0036e21d9349ddc9595663a74a5211610c30", @"/Views/Shop/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb4347f747b6b344367769e9972aeddd4aec934", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""page-header breadcrumb-wrap"">
    <div class=""container"">
        <div class=""breadcrumb"">
            <a class=""me-1"" href=""index.html""><i class=""fa-solid fa-house me-1""></i>Home</a>
            <i class=""fa-solid fa-cart-shopping""></i> Cart
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "845c0036e21d9349ddc9595663a74a5211610c305666", async() => {
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
#line 34 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                             foreach (var item in Model)
                            {
                                var imagePath = item.Images.FirstOrDefault(i => i.IsMain == true).ImagePath;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr data-quantity=\"1\" data-price=\"");
#nullable restore
#line 37 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                                             Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                    <td style=\"display:flex;justify-content:center;\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "845c0036e21d9349ddc9595663a74a5211610c307378", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1619, "~/uploads/images/", 1619, 17, true);
#nullable restore
#line 39 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
AddHtmlAttributeValue("", 1636, imagePath, 1636, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 42 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 45 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
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
#line 53 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                                                        Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ₼</span>
                                    </td>
                                    <td>
                                        <button class=""btn btn-link text-danger""><i class=""fas fa-times""></i></button>
                                    </td>
                                </tr>
");
#nullable restore
#line 59 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Shop\Basket.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </tbody>
                        <tfoot>
                            <tr>
                                <th colspan=""3"" class=""text-right"">Total</th>
                                <th>$4,000</th>
                                <th></th>
                            </tr>
                        </tfoot>
                    </table>
                </div>
                <div class=""col-12 text-right"">
                    <button class=""btn btn-outline-secondary me-3"" type=""submit"">Update</button>
                    <a href=""#"" class=""btn btn-outline-success"">Checkout</a>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("js", async() => {
                WriteLiteral(@" 
    <script>
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

            console.log(data);
        }
        function minusQuantity(e) {
            e.preventDefault();
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
      ");
                WriteLiteral("      $(row).find(\'span.quantity\').html(quantity);\r\n            $(row).find(\'td.product-price .amount\').html(`${(data.price * quantity)}₼`)\r\n\r\n            console.log(data);\r\n        }\r\n    </script>\r\n");
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
