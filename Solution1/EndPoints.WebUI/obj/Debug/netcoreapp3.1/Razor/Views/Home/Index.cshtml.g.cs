#pragma checksum "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a583ec1dba5be1c09d6829a83fd05f66bd9eacb"
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
#line 1 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a583ec1dba5be1c09d6829a83fd05f66bd9eacb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a714a1344e4c0bd2b12bf49ce32345bdfb97cd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Core.Domian.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"products-box\">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row special-list\">\r\n\r\n");
#nullable restore
#line 8 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3 col-md-6 special-grid best-seller"">
                    <div class=""products-single fix"">
                        <div class=""box-img-hover"">
                            <div class=""type-lb"">
                                <p class=""sale"">Sale</p>
                            </div>
                            <img");
            BeginWriteAttribute("src", " src=", 555, "", 571, 1);
#nullable restore
#line 17 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 560, item.Image, 560, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"" alt=""Image"">
                            <div class=""mask-icon"">
                                <ul>
                                    <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""View""><i class=""fas fa-eye""></i></a></li>
                                    <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Compare""><i class=""fas fa-sync-alt""></i></a></li>
                                    <li><a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""Add to Wishlist""><i class=""far fa-heart""></i></a></li>
                                </ul>
                                <a class=""cart"" href=""#"">Add to Cart</a>
                            </div>
                        </div>
                        <div class=""why-text"">
                            <h4>");
#nullable restore
#line 28 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <h4>");
#nullable restore
#line 29 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Home\Index.cshtml"
                           Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <h5>");
#nullable restore
#line 30 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Home\Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ریال</h5> \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 34 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Core.Domian.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
