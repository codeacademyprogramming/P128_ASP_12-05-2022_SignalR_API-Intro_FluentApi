#pragma checksum "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f742ff66f0ee2770b29faa20d9db8d77eb6bf0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductDetailPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductDetailPartial.cshtml")]
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
#line 2 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.ViewModels.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\_ViewImports.cshtml"
using P224Allup.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f742ff66f0ee2770b29faa20d9db8d77eb6bf0c", @"/Views/Shared/_ProductDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d72c2fc3d189420d4350005c775901c7e515b5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("basketform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-header"">
    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
        <i class=""fal fa-times""></i>
    </button>
</div>
<div class=""modal-body"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""product-quick-view-image mt-30"">
                <div class=""quick-view-image"">
");
#nullable restore
#line 12 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                     foreach (ProductImage productImage in Model.ProductImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-view-image\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f742ff66f0ee2770b29faa20d9db8d77eb6bf0c7042", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 573, "~/assets/images/product/", 573, 24, true);
#nullable restore
#line 15 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
AddHtmlAttributeValue("", 597, productImage.Image, 597, 19, false);

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
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 17 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <ul class=\"quick-view-thumb\">\r\n");
#nullable restore
#line 20 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                     foreach (ProductImage productImage in Model.ProductImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            <div class=\"single-thumb\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f742ff66f0ee2770b29faa20d9db8d77eb6bf0c9383", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 992, "~/assets/images/product/", 992, 24, true);
#nullable restore
#line 24 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
AddHtmlAttributeValue("", 1016, productImage.Image, 1016, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 27 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div> <!-- Modal Quick View Image -->\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"product-quick-view-content mt-30\">\r\n                <h3 class=\"product-title\">");
#nullable restore
#line 33 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <p class=""reference"">Reference: demo_12</p>
                <ul class=""rating"">
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                </ul>
                <div class=""product-prices"">
");
#nullable restore
#line 43 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                     if (Model.DiscountPrice > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"sale-price\"> €");
#nullable restore
#line 45 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                                              Write(Model.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"regular-price\">€");
#nullable restore
#line 46 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                                                Write(Model.DiscountPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"save\">Save ");
#nullable restore
#line 47 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                                            Write((((Model.Price * 100) / Model.DiscountPrice)-100).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 48 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"regular-price\">€");
#nullable restore
#line 51 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                                                Write(Model.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 52 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <p class=\"product-description\">");
#nullable restore
#line 54 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"product-size-color flex-wrap\">\r\n                    <div class=\"product-quantity\">\r\n                        <h5 class=\"title\">Quantity</h5>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f742ff66f0ee2770b29faa20d9db8d77eb6bf0c15074", async() => {
                WriteLiteral(@"
                            <div class=""quantity d-flex"">
                                <button type=""button"" id=""sub"" class=""sub""><i class=""fal fa-minus""></i></button>
                                <input type=""text"" id=""productcount"" name=""count"" value=""1"" />
                                <button type=""button"" id=""add"" class=""add""><i class=""fal fa-plus""></i></button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\hamid.mammadov\Desktop\P224Allup\Views\Shared\_ProductDetailPartial.cshtml"
                                                                                                             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                <div class=""product-add-cart"">
                    <button id=""addbasketbtn"" type=""submit"" form=""basketform""><i class=""icon ion-bag""></i> Add to cart</button>
                </div>
                <div class=""product-wishlist-compare"">
                    <ul class=""d-flex flex-wrap"">
                        <li><a href=""#""><i class=""fal fa-heart""></i> Add to wishlist</a></li>
                        <li><a href=""#""><i class=""fal fa-repeat""></i> Add to compare</a></li>
                    </ul>
                </div>
                <div class=""product-share d-flex"">
                    <p>Share</p>
                    <ul class=""social media-body"">
                        <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-google""></i></a></li>
                        <li><a href=""#");
            WriteLiteral("\"><i class=\"fab fa-pinterest-p\"></i></a></li>\r\n                    </ul>\r\n                </div>\r\n            </div> <!-- Modal Quick View Content -->\r\n        </div>\r\n    </div> <!-- row -->\r\n</div>  <!-- Modal Body -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
