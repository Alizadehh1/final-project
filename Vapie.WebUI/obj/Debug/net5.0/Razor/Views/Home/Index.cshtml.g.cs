#pragma checksum "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "928de5cdc2d6d6f892ae1af447ca6ba44d345679"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928de5cdc2d6d6f892ae1af447ca6ba44d345679", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd5bdd801da681c02871c694286a714d45e96351", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-12 px-0"">
    <div id=""slider"" class=""carousel slide w-100"" data-bs-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-bs-target=""#slider"" data-bs-slide-to=""0"" class=""active""></li>
            <li data-bs-target=""#slider"" data-bs-slide-to=""1""></li>
            <li data-bs-target=""#slider"" data-bs-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"" role=""listbox"">
            <div class=""carousel-item active"">
                <img src=""./assets/images/slider-1.jpg"" class=""slider-img"">
            </div>
            <div class=""carousel-item"">
                <img src=""./assets/images/slider-2.jpg"" class=""slider-img"">
            </div>
            <div class=""carousel-item"">
                <img src=""./assets/images/slider-3.jpg"" class=""slider-img"">
            </div>
        </div>
        <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#slider"" data-bs-slide=""prev"">
            <span class=""carousel-control-pr");
            WriteLiteral(@"ev-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Previous</span>
        </button>
        <button class=""carousel-control-next"" type=""button"" data-bs-target=""#slider"" data-bs-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Next</span>
        </button>
    </div>
</div>
<div class=""col-12"">
    <div class=""row"">
        <div class=""col-12 py-3"">
            <div class=""row"">
                <div class=""col-12 text-center text-uppercase"">
                    <h2>Featured Products</h2>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class=""col-12 bg-white text-center h-100 product-item"">
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                          ");
            WriteLiteral(@"          <img src=""./assets/images/image-1.jpg"" class=""img-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">Sony Alpha DSLR Camera</a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <span class=""product-price-old"">
                                    $500
                                </span>
                                <br>
                                <span class=""product-price"">
                                    $500
                                </span>
                            </div>
                            <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
               ");
            WriteLiteral(@"         </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class=""col-12 bg-white text-center h-100 product-item"">
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                                    <img src=""./assets/images/image-2.jpg"" class=""img-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">Optoma 4K HDR Projector</a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <span class=""product-price"">
                                    $1,500
                                </span>
                            </div>
                            <div class=""col-12 mb-3");
            WriteLiteral(@" align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class=""col-12 bg-white text-center h-100 product-item"">
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                                    <img src=""./assets/images/image-3.jpg"" class=""img-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">HP Envy Specter 360</a>
                            </div>
                            <div class=""col-12 mb-3"">
                          ");
            WriteLiteral(@"      <div class=""product-price-old"">
                                    $2,800
                                </div>
                                <span class=""product-price"">
                                    $2,500
                                </span>
                            </div>
                            <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class=""col-12 bg-white text-center h-100 product-item"">
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                                    <img src=""./assets/images/image-4.jpg"" class=""img");
            WriteLiteral(@"-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">Dell Alienware Area 51</a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <span class=""product-price"">
                                    $4,500
                                </span>
                            </div>
                            <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>

<div class=""col-12"">
    <hr>
</div>

<div class=""col-12"">
    <div class=""row"">
        <div class=""col-12 p");
            WriteLiteral(@"y-3"">
            <div class=""row"">
                <div class=""col-12 text-center text-uppercase"">
                    <h2>Latest Products</h2>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class=""col-12 bg-white text-center h-100 product-item"">
                        <span class=""new"">New</span>
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                                    <img src=""./assets/images/image-1.jpg"" class=""img-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">Sony Alpha DSLR Camera</a>
                            </div>
                            <div class=""col-12 mb-3"">
                          ");
            WriteLiteral(@"      <span class=""product-price-old"">
                                    $500
                                </span>
                                <br>
                                <span class=""product-price"">
                                    $500
                                </span>
                            </div>
                            <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class=""col-12 bg-white text-center h-100 product-item"">
                        <span class=""new"">New</span>
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.htm");
            WriteLiteral(@"l"">
                                    <img src=""./assets/images/image-2.jpg"" class=""img-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">Optoma 4K HDR Projector</a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <span class=""product-price"">
                                    $1,500
                                </span>
                            </div>
                            <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class");
            WriteLiteral(@"=""col-12 bg-white text-center h-100 product-item"">
                        <span class=""new"">New</span>
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                                    <img src=""./assets/images/image-3.jpg"" class=""img-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">HP Envy Specter 360</a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <div class=""product-price-old"">
                                    $2,800
                                </div>
                                <span class=""product-price"">
                                    $2,500
                                </span>
                            </div>
     ");
            WriteLiteral(@"                       <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class=""col-12 bg-white text-center h-100 product-item"">
                        <span class=""new"">New</span>
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                                    <img src=""./assets/images/image-4.jpg"" class=""img-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">Dell Alienware Area 51</a>
              ");
            WriteLiteral(@"              </div>
                            <div class=""col-12 mb-3"">
                                <span class=""product-price"">
                                    $4,500
                                </span>
                            </div>
                            <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>

<div class=""col-12"">
    <hr>
</div>
<div class=""col-12"">
    <div class=""row"">
        <div class=""col-12 py-3"">
            <div class=""row"">
                <div class=""col-12 text-center text-uppercase"">
                    <h2>Top Selling Products</h2>
                </div>
            </div>
            <div class=""row"">
                <div class=""co");
            WriteLiteral(@"l-lg-3 col-sm-6 my-3"">
                    <div class=""col-12 bg-white text-center h-100 product-item"">
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                                    <img src=""./assets/images/image-1.jpg"" class=""img-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">Sony Alpha DSLR Camera</a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <span class=""product-price-old"">
                                    $500
                                </span>
                                <br>
                                <span class=""product-price"">
                                    $500
                                </span>
  ");
            WriteLiteral(@"                          </div>
                            <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class=""col-12 bg-white text-center h-100 product-item"">
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                                    <img src=""./assets/images/image-2.jpg"" class=""img-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">Optoma 4K HDR Projector</a>
                            ");
            WriteLiteral(@"</div>
                            <div class=""col-12 mb-3"">
                                <span class=""product-price"">
                                    $1,500
                                </span>
                            </div>
                            <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class=""col-12 bg-white text-center h-100 product-item"">
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                                    <img src=""./assets/images/image-3.jpg"" class=""img-fluid"">
                                </a>
            ");
            WriteLiteral(@"                </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">HP Envy Specter 360</a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <div class=""product-price-old"">
                                    $2,800
                                </div>
                                <span class=""product-price"">
                                    $2,500
                                </span>
                            </div>
                            <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-sm-6 my-3"">
                    <div class=""col");
            WriteLiteral(@"-12 bg-white text-center h-100 product-item"">
                        <div class=""row h-100"">
                            <div class=""col-12 p-0 mb-3"">
                                <a href=""product.html"">
                                    <img src=""./assets/images/image-4.jpg"" class=""img-fluid"">
                                </a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <a href=""product.html"" class=""product-name"">Dell Alienware Area 51</a>
                            </div>
                            <div class=""col-12 mb-3"">
                                <span class=""product-price"">
                                    $4,500
                                </span>
                            </div>
                            <div class=""col-12 mb-3 align-self-end"">
                                <button class=""btn btn-outline-dark"" type=""button""><i class=""fas fa-cart-plus me-2""></i>Add to cart</button>");
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""col-12 py-3 bg-light d-sm-block d-none"">
    <div class=""row"">
        <div class=""col-lg-3 col ms-auto large-holder"">
            <div class=""row"">
                <div class=""col-auto ms-auto large-icon"">
                    <i class=""fas fa-money-bill""></i>
                </div>
                <div class=""col-auto me-auto large-text"">
                    Best Price
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col large-holder"">
            <div class=""row"">
                <div class=""col-auto ms-auto large-icon"">
                    <i class=""fas fa-truck-moving""></i>
                </div>
                <div class=""col-auto me-auto large-text"">
                    Fast Delivery
                </div>
            </div>
        </div>
        <div class");
            WriteLiteral(@"=""col-lg-3 col me-auto large-holder"">
            <div class=""row"">
                <div class=""col-auto ms-auto large-icon"">
                    <i class=""fas fa-check""></i>
                </div>
                <div class=""col-auto me-auto large-text"">
                    Genuine Products
                </div>
            </div>
        </div>
    </div>
</div>
");
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
