#pragma checksum "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbacfaf4a26c8f229bd70932af5bcda2af0b806a"
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
#line 1 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbacfaf4a26c8f229bd70932af5bcda2af0b806a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce.ViewModel.UserProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LoadMore2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("load-more"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Show More Shoe.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("services-img-position"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Path 1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <section class=""top-container"">
                <header class=""showcase"">
                    <p>
                        Super Flash Sale<br> 50% Off
                    </p>
                </header>
</section>
<!--Boxes Section-->
<section class=""Boxes-section"">
    <div class=""boxes"">
        <div class=""box box1"">
            <div class=""box-overlay"">
                <div class=""text-adjust"" class=""box-text"">FS - QUILTED MAXI<br> CROSS BAG</div>
                <p class=""box-price"">
                    <span class=""featured_productPrice price-strike-through"">$534,33</span>&nbsp
                    <span class=""initPrice new-price"">24% off</span>
                    <span  class=""discount-price-one"">299,43</span>
                </p>
            </div>
        </div>
        <div class=""box box2"">
            <div class=""box-overlay"">
                <div class=""text-adjust"" class=""box-text"">FS - NIKE AIR<br> MAX 270 REACT...</div>
                <span  class=""discount-price-two"">");
            WriteLiteral(@"299,43</span>
                <p class=""box-price-center"">
                    <span>
                        <span class=""featured_productPrice price-strike-through"">$534,33</span>&nbsp
                        <span class=""initPrice new-price"">24% off</span>
                    </span>
                </p>
            </div>
        </div>
        <div class=""box box3"">
            <div class=""box-overlay"">
                <div class=""text-adjust"" class=""box-text"">FS - NIKE AIR<br> MAX 270 REACT...</div>
                <p class=""box-price-center"">
                    <span>
                        <span class=""featured_productPrice price-strike-through"">$534,33</span>&nbsp
                        <span class=""initPrice new-price"">24% off</span>
                    </span>
                </p>
            </div>
        </div>
    </div>
</section>
    <!--Info Section-->
<section class=""info"">
    <div class=""best-seller"">
        <h1>BEST SELLER</h1>
    </div>
    <div id=""best-");
            WriteLiteral(@"seller-adjust"">
        <ul id=""best-seller-ul-adjust"">
            <li><a style=""color: #46BCF7;"">All</a></li>
            <li><a>Bags</a></li>
            <li><a>Sneakers</a></li>
            <li><a>Belt</a></li>
            <li><a>Sunglasses</a></li>
        </ul>
    </div>
    <div class=""Boxes-section"" style=""padding:0px 120px"">
        <div class=""best-seller-items"">
");
#nullable restore
#line 66 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
              
                int count = 0;
                foreach(var product in Model.Products.OrderBy(x=>x.NumberOfSale).ToList())
                {
                    string img = product.ProductImage;
                    if(count < 8)
                    {  

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbacfaf4a26c8f229bd70932af5bcda2af0b806a10053", async() => {
                WriteLiteral("\r\n                                 <div class=\"best-seller-box1\">\r\n                                <div class=\"best-seller-box\"><img");
                BeginWriteAttribute("src", " src=", 3028, "", 3065, 1);
#nullable restore
#line 75 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
WriteAttributeValue("", 3033, product.ProductImage.ToString(), 3033, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"100%\"></div>\r\n                                <div id=\"text\">\r\n                                    ");
#nullable restore
#line 77 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                               Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                                </div>\r\n                                <div id=\"features-detail\">\r\n");
#nullable restore
#line 80 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                              
                                for(int i = 0; i < 5; i++)
                                {
                                    if(i < product.Ratings)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <i class=\"fa-solid fa-star stars-ratings\"></i>\r\n");
#nullable restore
#line 86 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <i class=\"fa fa-star stars-gray\"></i>\r\n");
#nullable restore
#line 90 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>\r\n");
#nullable restore
#line 94 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                              
                                int amount = (int) product.UnitPrice;
                                int discountAmount = (int) product.DiscountedUnitPrice;
                                string price = Ecommerce.Utilities.PriceAdjuster.PriceEdit($"{amount}");
                                string discountedPrice = Ecommerce.Utilities.PriceAdjuster.PriceEdit($"{discountAmount}");
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <span class=\"featured_productPrice price-color\">");
#nullable restore
#line 100 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                                                           Write(discountedPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> \r\n                                <span class=\"initPrice price-strike-through\">");
#nullable restore
#line 101 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                                                        Write(price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                <span class=\"initPrice new-price\">");
#nullable restore
#line 102 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                                             Write(product.PercentOff);

#line default
#line hidden
#nullable disable
                WriteLiteral("% off</span>\r\n                            </p>\r\n                            </div>\r\n                        </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                                                 WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 107 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                         count++;      
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section >\r\n<section class=\"info\">\r\n    <div class=\"best-seller\">\r\n");
#nullable restore
#line 116 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
              
                if(Model.IsSuccess == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 id=\"load-more\">LOAD MORE</h3>   \r\n");
#nullable restore
#line 120 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbacfaf4a26c8f229bd70932af5bcda2af0b806a17466", async() => {
                WriteLiteral("<h3>LOAD MORE</h3>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 124 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
        <section class=""load-more"">
            <div class=""inner-content"">
                <div>
                    <h1 class=""adidas"">
                        ADIDAS MEN RUNNING<br><br> SNIKERS
                    </h1>
                    <h3>
                        performance and design. Taken right to the edge
                    </h3>
                    <span id=""shop-now"">
                        SHOP NOW
                    </span>
                </div>
                </div>
            <div class=""best-seller-img"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbacfaf4a26c8f229bd70932af5bcda2af0b806a19522", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" 
            </div>
        </section>
</section>
<section class=""services"">
    <div style=""width:250px"">
        <img src=""img/shipping.png""  class=""services-img-position"" src height=""100%"">
        <h3 class=""services-p"">FREE SHIPPING</h3>
        <p>
            lorem ipsu is simply a dummy text of th printing and typesetting industrt
        </p>
    </div>
    <div style=""width:250px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbacfaf4a26c8f229bd70932af5bcda2af0b806a21148", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <img class=""services-img-position-second"" src=""img/Path 2.png"" height=""100%"">
        <h3 class=""services-p"">100% REFUND</h3>
        <p>
            lorem ipsu is simply a dummy text of th printing and typesetting industrt
        </p>
    </div>
    <div style=""width:250px"">
        <img src=""img/Path 4.png"" class=""services-img-position"" src height=""100%"">
        <h3 class=""services-p"">SUPPORT 24/7</h3>
        <p>
            lorem ipsu is simply a dummy text of th printing and typesetting industrt
        </p>
    </div>
</section>
<section class=""info"">
    <div class=""best-seller"">
        <h1>LATEST NEWS</h1>
    </div>
    <section class=""latest-news"">
");
#nullable restore
#line 175 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
     foreach(var news in Model.LatestNews)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"latest-inner\">\r\n            <div class=\"overlay latest-img\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 7314, "", 7319, 0);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 179 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                     Write(news.NewsImage.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("  src width=\"100%\">\r\n            </div>\r\n            <div class=\"overlay\">\r\n                <h5 class=\"latest-date\">");
#nullable restore
#line 182 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                   Write(news.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h3 style=\"text-align: left;\">\r\n                    ");
#nullable restore
#line 184 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
               Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n                <p  style=\"text-align: left;\">\r\n                    ");
#nullable restore
#line 187 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
               Write(news.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 191 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n</section>\r\n<section class=\"info\">\r\n    <div class=\"best-seller\">\r\n        <h1>FEATURED PRODUCTS</h1>\r\n    </div>\r\n    <section class=\"featured\" >\r\n");
#nullable restore
#line 199 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
         foreach(var featuredProduct in Model.Products)
        {
            if (featuredProduct.Featured)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbacfaf4a26c8f229bd70932af5bcda2af0b806a25526", async() => {
                WriteLiteral("\r\n                    <div class=\"featured-column\">\r\n                    <div id=\"featured-column-inner\">\r\n                        <img");
                BeginWriteAttribute("src", " src=", 8193, "", 8227, 1);
#nullable restore
#line 206 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
WriteAttributeValue("", 8198, featuredProduct.ProductImage, 8198, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  id=\"featured-image\" width=\"100%\">\r\n                    </div>\r\n                    <div id=\"features-detail\">\r\n                        <h3>");
#nullable restore
#line 209 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                       Write(featuredProduct.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 210 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                          
                            for(int i = 0; i < 5; i++)
                            {
                                if(i < featuredProduct.Ratings)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fa-solid fa-star stars-ratings\"></i>\r\n");
#nullable restore
#line 216 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fa fa-star stars-gray\"></i>\r\n");
#nullable restore
#line 220 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p>\r\n");
#nullable restore
#line 224 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                              
                                int amount = (int) featuredProduct.UnitPrice;
                                int discountAmount = (int) featuredProduct.DiscountedUnitPrice;
                                string price = Ecommerce.Utilities.PriceAdjuster.PriceEdit($"{amount}");
                                string discountedPrice = Ecommerce.Utilities.PriceAdjuster.PriceEdit($"{discountAmount}");
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"featured_productPrice price-color\">");
#nullable restore
#line 230 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                                                       Write(discountedPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> \r\n                            <span class=\"initPrice price-strike-through\">");
#nullable restore
#line 231 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                                                    Write(price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <span class=\"initPrice new-price\">");
#nullable restore
#line 232 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
                                                         Write(featuredProduct.PercentOff);

#line default
#line hidden
#nullable disable
                WriteLiteral("% off</span>\r\n                        </p>\r\n                    </div>\r\n                </div> \r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 237 "C:\Users\hp\source\repos\weekk9\Ecommerce1.0\Views\Home\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n</section>\r\n<section class=\"centered-form\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbacfaf4a26c8f229bd70932af5bcda2af0b806a30895", async() => {
                WriteLiteral("\r\n        <input class=\"input\"><input class=\"button\" type=\"submit\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.ViewModel.UserProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
