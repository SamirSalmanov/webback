#pragma checksum "C:\Users\user\Desktop\websuper-back\Websuper\Views\Home\Works.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf0afc8d5f458b086c9259efaa237c7d3a71152b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Works), @"mvc.1.0.view", @"/Views/Home/Works.cshtml")]
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
#line 1 "C:\Users\user\Desktop\websuper-back\Websuper\Views\_ViewImports.cshtml"
using Websuper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\websuper-back\Websuper\Views\_ViewImports.cshtml"
using Websuper.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\websuper-back\Websuper\Views\_ViewImports.cshtml"
using Websuper.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf0afc8d5f458b086c9259efaa237c7d3a71152b", @"/Views/Home/Works.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ad9afb193399235da314fd142fc9a022cbbb60", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Works : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <section class=""portfolios"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 col-lg-3 col-md-3"">
                    <div class=""left-port"">
                        <div class=""line"">
                        </div>
                        <h3>Categories</h3>
                        <ul>
");
#nullable restore
#line 12 "C:\Users\user\Desktop\websuper-back\Websuper\Views\Home\Works.cshtml"
                             foreach (var category in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 516, "\"", 547, 2);
            WriteAttributeValue("", 523, "/home/works/", 523, 12, true);
#nullable restore
#line 14 "C:\Users\user\Desktop\websuper-back\Websuper\Views\Home\Works.cshtml"
WriteAttributeValue("", 535, category.ID, 535, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "C:\Users\user\Desktop\websuper-back\Websuper\Views\Home\Works.cshtml"
                                                                  Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 15 "C:\Users\user\Desktop\websuper-back\Websuper\Views\Home\Works.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n\r\n                    </div>\r\n\r\n\r\n                </div>\r\n                <div class=\"col-12 col-md-9 col-lg-9\">\r\n                    <div class=\"right-port\">\r\n                        <div class=\"row\">\r\n");
#nullable restore
#line 26 "C:\Users\user\Desktop\websuper-back\Websuper\Views\Home\Works.cshtml"
                             foreach (var work in Model.Galleries)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-12 col-md-6  col-lg-4\">\r\n                                <div class=\"img\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1108, "\"", 1128, 1);
#nullable restore
#line 30 "C:\Users\user\Desktop\websuper-back\Websuper\Views\Home\Works.cshtml"
WriteAttributeValue("", 1114, work.PhotoURL, 1114, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1129, "\"", 1135, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"ground\"></div>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1241, "\"", 1272, 2);
            WriteAttributeValue("", 1248, "/product/detail/", 1248, 16, true);
#nullable restore
#line 32 "C:\Users\user\Desktop\websuper-back\Websuper\Views\Home\Works.cshtml"
WriteAttributeValue("", 1264, work.ID, 1264, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i class=\"fas fa-plus\"></i>\r\n                                    </a>\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 38 "C:\Users\user\Desktop\websuper-back\Websuper\Views\Home\Works.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
