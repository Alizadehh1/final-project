#pragma checksum "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24630862b5c3a3fd4c2d2b83cecf552c97ab0429"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 2 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Vapie.WebUI.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Vapie.WebUI.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Vapie.WebUI.AppCode.Modules.BrandModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Vapie.WebUI.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Vapie.WebUI.AppCode.Modules.BlogModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Vapie.WebUI.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Vapie.WebUI.AppCode.Modules.ProductModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using Vapie.WebUI.AppCode.Modules.SliderModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alide\OneDrive\Desktop\final-project\Vapie.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24630862b5c3a3fd4c2d2b83cecf552c97ab0429", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bfd066f1b8c54f6283e176302324007d6d71e90", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""page-body"">
    <div class=""row"">
        <!-- task, page, download counter  start -->
        <div class=""col-xl-3 col-md-6"">
            <div class=""card bg-c-yellow update-card"">
                <div class=""card-block"">
                    <div class=""row align-items-end"">
                        <div class=""col-8"">
                            <h4 class=""text-white"">$30200</h4>
                            <h6 class=""text-white m-b-0"">All Earnings</h6>
                        </div>
                        <div class=""col-4 text-right"">
                            <canvas id=""update-chart-1"" height=""50""></canvas>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <p class=""text-white m-b-0"">
                        <i class=""feather icon-clock text-white f-14 m-r-10""></i>update
                        : 2:15 am
                    </p>
                </div>
            </div>
   ");
            WriteLiteral(@"     </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card bg-c-green update-card"">
                <div class=""card-block"">
                    <div class=""row align-items-end"">
                        <div class=""col-8"">
                            <h4 class=""text-white"">290+</h4>
                            <h6 class=""text-white m-b-0"">Page Views</h6>
                        </div>
                        <div class=""col-4 text-right"">
                            <canvas id=""update-chart-2"" height=""50""></canvas>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <p class=""text-white m-b-0"">
                        <i class=""feather icon-clock text-white f-14 m-r-10""></i>update
                        : 2:15 am
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card bg-c-pink upd");
            WriteLiteral(@"ate-card"">
                <div class=""card-block"">
                    <div class=""row align-items-end"">
                        <div class=""col-8"">
                            <h4 class=""text-white"">145</h4>
                            <h6 class=""text-white m-b-0"">Task Completed</h6>
                        </div>
                        <div class=""col-4 text-right"">
                            <canvas id=""update-chart-3"" height=""50""></canvas>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <p class=""text-white m-b-0"">
                        <i class=""feather icon-clock text-white f-14 m-r-10""></i>update
                        : 2:15 am
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-xl-3 col-md-6"">
            <div class=""card bg-c-lite-green update-card"">
                <div class=""card-block"">
                    <div class=""ro");
            WriteLiteral(@"w align-items-end"">
                        <div class=""col-8"">
                            <h4 class=""text-white"">500</h4>
                            <h6 class=""text-white m-b-0"">Downloads</h6>
                        </div>
                        <div class=""col-4 text-right"">
                            <canvas id=""update-chart-4"" height=""50""></canvas>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <p class=""text-white m-b-0"">
                        <i class=""feather icon-clock text-white f-14 m-r-10""></i>update
                        : 2:15 am
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("js", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
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
