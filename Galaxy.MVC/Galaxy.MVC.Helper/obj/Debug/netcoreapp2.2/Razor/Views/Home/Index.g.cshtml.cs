#pragma checksum "D:\OneDrive\Galaxy\ASP NET MVC 6.0 Nivel Intermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Helper\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f9b49cae5ba75dd4c02a30e06727792c214e3ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\OneDrive\Galaxy\ASP NET MVC 6.0 Nivel Intermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Helper\Views\_ViewImports.cshtml"
using Galaxy.MVC.Helper;

#line default
#line hidden
#line 2 "D:\OneDrive\Galaxy\ASP NET MVC 6.0 Nivel Intermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Helper\Views\_ViewImports.cshtml"
using Galaxy.MVC.Helper.Models;

#line default
#line hidden
#line 2 "D:\OneDrive\Galaxy\ASP NET MVC 6.0 Nivel Intermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Helper\Views\Home\Index.cshtml"
using Galaxy.MVC.Helper.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f9b49cae5ba75dd4c02a30e06727792c214e3ea", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a24479328a537df68adf38ddfd758441dc4406d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelperViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Galaxy.MVC.Helper.Helpers.ArticleTagHelper __Galaxy_MVC_Helper_Helpers_ArticleTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\OneDrive\Galaxy\ASP NET MVC 6.0 Nivel Intermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Helper\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(103, 289, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-sm-4"">
        <div class=""card shadow p-3 mb-5 bg-white rounded"" style=""border-color:#7030a0"">
            <div class=""card-body"">
                <h5 class=""card-title"" style=""color:#7030a0"">HTML Helper (StringBuilder)</h5>
                ");
            EndContext();
            BeginContext(393, 55, false);
#line 13 "D:\OneDrive\Galaxy\ASP NET MVC 6.0 Nivel Intermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Helper\Views\Home\Index.cshtml"
           Write(Html.ArticleStringBuilder(m => m.ArticlesStringBuilder));

#line default
#line hidden
            EndContext();
            BeginContext(448, 313, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""col-sm-4"">
        <div class=""card shadow p-3 mb-5 bg-white rounded"" style=""border-color:#1f4e79"">
            <div class=""card-body"">
                <h5 class=""card-title"" style=""color:#1f4e79"">HTML Helper (TagBuilder)</h5>
                ");
            EndContext();
            BeginContext(762, 52, false);
#line 21 "D:\OneDrive\Galaxy\ASP NET MVC 6.0 Nivel Intermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Helper\Views\Home\Index.cshtml"
           Write(Html.ArticleTagBuilder(m => m.ArticlesStringBuilder));

#line default
#line hidden
            EndContext();
            BeginContext(814, 299, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""col-sm-4"">
        <div class=""card shadow p-3 mb-5 bg-white rounded"" style=""border-color:#00b050"">
            <div class=""card-body"">
                <h5 class=""card-title"" style=""color:#00b050"">Tag Helper</h5>
                ");
            EndContext();
            BeginContext(1113, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("list-articles", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f9b49cae5ba75dd4c02a30e06727792c214e3ea6160", async() => {
            }
            );
            __Galaxy_MVC_Helper_Helpers_ArticleTagHelper = CreateTagHelper<global::Galaxy.MVC.Helper.Helpers.ArticleTagHelper>();
            __tagHelperExecutionContext.Add(__Galaxy_MVC_Helper_Helpers_ArticleTagHelper);
#line 29 "D:\OneDrive\Galaxy\ASP NET MVC 6.0 Nivel Intermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Helper\Views\Home\Index.cshtml"
__Galaxy_MVC_Helper_Helpers_ArticleTagHelper.Articles = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ArticlesTagHelper);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("articles", __Galaxy_MVC_Helper_Helpers_ArticleTagHelper.Articles, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1173, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1191, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f9b49cae5ba75dd4c02a30e06727792c214e3ea7783", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1216, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelperViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591