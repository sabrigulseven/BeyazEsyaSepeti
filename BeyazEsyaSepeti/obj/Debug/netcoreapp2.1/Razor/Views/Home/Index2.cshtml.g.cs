#pragma checksum "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\Home\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "318b21728ca52783ebc0267392d208258a558643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index2), @"mvc.1.0.view", @"/Views/Home/Index2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index2.cshtml", typeof(AspNetCore.Views_Home_Index2))]
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
#line 1 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\_ViewImports.cshtml"
using BeyazEsyaSepeti;

#line default
#line hidden
#line 2 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\_ViewImports.cshtml"
using BeyazEsyaSepeti.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318b21728ca52783ebc0267392d208258a558643", @"/Views/Home/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d79559de20dfef4c0eece7097093a58b6d7f6722", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BeyazEsyaSepeti.Models.UserProductContainer>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\Home\Index2.cshtml"
  
    ViewData["Title"] = "Index2";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(138, 859, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "318b21728ca52783ebc0267392d208258a5586433536", async() => {
                BeginContext(144, 186, true);
                WriteLiteral("\n    <div class=\"col-md-6\">\n        <div class=\"panel panel-info\">\n            <h3 class=\"bg-success\">Ürünler</h3>\n            <div class=\"panel-body\">\n                <div class=\"row\">\n");
                EndContext();
#line 14 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\Home\Index2.cshtml"
                     foreach (var product in Model.productList)
                    {

#line default
#line hidden
                BeginContext(416, 89, true);
                WriteLiteral("                    <div class=\"col-md-4 col-sm-4 col-lg-4\">\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 505, "\"", 529, 1);
#line 17 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\Home\Index2.cshtml"
WriteAttributeValue("", 511, product.GetPath(), 511, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(530, 94, true);
                WriteLiteral(" class=\"img-responsive\" style=\"width:100%;\" />\n                        <div class=\"text-info\">");
                EndContext();
                BeginContext(625, 12, false);
#line 18 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\Home\Index2.cshtml"
                                          Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(637, 77, true);
                WriteLiteral("</div>\n                        <div class=\"text-danger\"style=font-size: 2rem>");
                EndContext();
                BeginContext(715, 13, false);
#line 19 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\Home\Index2.cshtml"
                                                                 Write(product.Price);

#line default
#line hidden
                EndContext();
                BeginContext(728, 66, true);
                WriteLiteral(" TL</div>;\n                        <a href=\"javascript:AddToCart;\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 794, "\"", 828, 3);
                WriteAttributeValue("", 804, "AddToCart(\'", 804, 11, true);
#line 20 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\Home\Index2.cshtml"
WriteAttributeValue("", 815, product.Id, 815, 11, false);

#line default
#line hidden
                WriteAttributeValue("", 826, "\')", 826, 2, true);
                EndWriteAttribute();
                BeginContext(829, 71, true);
                WriteLiteral(" class=\"btn btn-info float-right\">+ ADD</a>\n                    </div>\n");
                EndContext();
#line 22 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\Home\Index2.cshtml"
                    }

#line default
#line hidden
                BeginContext(922, 68, true);
                WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(997, 132, true);
            WriteLiteral("\n\n<script type=\"text/javascript\">\n    function AddToCart(productId) {\n        $.ajax({\n            method: \"GET\",\n            url: \'");
            EndContext();
            BeginContext(1130, 37, false);
#line 33 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\Home\Index2.cshtml"
             Write(Url.Action("AddProductToCart","User"));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 242, true);
            WriteLiteral("\' + \"?id=\" + productId\n        })\n        .done(function (msg) {\n            alert(\"Ürün Sepete Eklendi\");\n            UpdateCart();\n        });\n    }\n\n    function UpdateCart() {\n        $.ajax({\n            method: \"GET\",\n            url: \'");
            EndContext();
            BeginContext(1410, 35, false);
#line 44 "C:\Users\Sabri\Desktop\BeyazEsyaSepeti\BeyazEsyaSepeti\Views\Home\Index2.cshtml"
             Write(Url.Action("UserCartCount", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 126, true);
            WriteLiteral("\'\n        })\n            .done(function (msg) {\n              $(\"#CartItemCount\").html(msg);\n        });\n\n    }\n\n\n</script>\n\n\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BeyazEsyaSepeti.Service.Interface.IUserService _userService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeyazEsyaSepeti.Models.UserProductContainer> Html { get; private set; }
    }
}
#pragma warning restore 1591
