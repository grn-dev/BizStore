#pragma checksum "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c23863cfa279f054a8a64fd8e650b91b279b6e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ViewDetails_ShoeDetail), @"mvc.1.0.view", @"/Views/ViewDetails/ShoeDetail.cshtml")]
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
#nullable restore
#line 3 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI.Models.Producte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\_ViewImports.cshtml"
using EndPoints.WebUI.Models.Categories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c23863cfa279f054a8a64fd8e650b91b279b6e6", @"/Views/ViewDetails/ShoeDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"062286973dfc7c644e884ed73ff7051c8d0aaa02", @"/Views/_ViewImports.cshtml")]
    public class Views_ViewDetails_ShoeDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EndPoints.WebUI.Models.ViewDetails.ViewDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShoeDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ViewDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
  
    ViewData["Title"] = "ShoeDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"" dir=""rtl"">
    <div class=""row"" dir=""rtl"">
        <div class=""col-xl-5 col-lg-5 col-md-6"">
            <div id=""carousel-example-1"" class=""single-product-slider carousel slide"" data-ride=""carousel"">
                <div class=""carousel-inner"" role=""listbox"">
                    <div class=""carousel-item active""> <img class=""d-block w-100"" src=""images/big-img-01.jpg"" alt=""First slide""> </div>
                    <div class=""carousel-item""> <img class=""d-block w-100"" src=""images/big-img-02.jpg"" alt=""Second slide""> </div>
                    <div class=""carousel-item""> <img class=""d-block w-100"" src=""images/big-img-03.jpg"" alt=""Third slide""> </div>
                </div>

                <ol class=""carousel-indicators"">

                    <li data-target=""#carousel-example-1"" data-slide-to=""2"">
                        <img class=""d-block w-100 img-fluid""");
            BeginWriteAttribute("src", " src=\"", 1010, "\"", 1040, 1);
#nullable restore
#line 20 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
WriteAttributeValue("", 1016, Model.MainProduct.Image, 1016, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1041, "\"", 1047, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </li>\r\n                </ol>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-xl-7 col-lg-7 col-md-6\">\r\n            <div class=\"single-product-details\">\r\n                <h2>");
#nullable restore
#line 27 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
               Write(Model.MainProduct.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h5>");
#nullable restore
#line 28 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
               Write(Model.MainProduct.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                <p>\r\n                    <h4>توضیحات</h4>\r\n                <p>\r\n                    ");
#nullable restore
#line 33 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
               Write(Model.MainProduct.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n\r\n                <div class=\"price-box-bar\">\r\n                    <div class=\"cart-and-bay-btn\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c23863cfa279f054a8a64fd8e650b91b279b6e69127", async() => {
                WriteLiteral("Add to Cart");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
                                                                                              WriteLiteral(Model.MainProduct.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </div>
                </div>


            </div>
        </div>
    </div>






    <div class=""row my-5"">
        <div class=""col-lg-12"">
            <div class=""title-all text-center"">
                <h1>محصولات مرتبط</h1>

            </div>
            <div class=""featured-products-box owl-carousel owl-theme"">

");
#nullable restore
#line 62 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
                 foreach (var item in Model.ReletionProduct)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item\">\r\n                        <div class=\"products-single fix\">\r\n                            <div class=\"box-img-hover\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2389, "\"", 2406, 1);
#nullable restore
#line 68 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
WriteAttributeValue("", 2395, item.Image, 2395, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"Image\">\r\n                                <div class=\"mask-icon\">\r\n                                    <ul>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c23863cfa279f054a8a64fd8e650b91b279b6e613091", async() => {
                WriteLiteral("\r\n                                            <i class=\"fas fa-eye\">\r\n                                                VIEW\r\n                                            </i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PrucuctId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
                                                                                                                                                                   WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PrucuctId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PrucuctId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PrucuctId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </ul>\r\n\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"why-text\">\r\n                                <h4>");
#nullable restore
#line 82 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" name</h4>\r\n                                <h5>");
#nullable restore
#line 83 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 87 "D:\Git myproject\BizStore\Solution1\EndPoints.WebUI\Views\ViewDetails\ShoeDetail.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EndPoints.WebUI.Models.ViewDetails.ViewDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
