#pragma checksum "D:\GitHub\NetCoreIntermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Cache\Views\Shared\Components\Pais\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6524bfbf8cd342a4a86d73b2a90f0ec6f093180"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pais_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pais/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Pais/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Pais_Default))]
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
#line 1 "D:\GitHub\NetCoreIntermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Cache\Views\_ViewImports.cshtml"
using Galaxy.MVC.Cache;

#line default
#line hidden
#line 2 "D:\GitHub\NetCoreIntermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Cache\Views\_ViewImports.cshtml"
using Galaxy.MVC.Cache.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6524bfbf8cd342a4a86d73b2a90f0ec6f093180", @"/Views/Shared/Components/Pais/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcf61a55485dcff1ae82d145dc412f3b56f9dae1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pais_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\GitHub\NetCoreIntermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Cache\Views\Shared\Components\Pais\Default.cshtml"
 foreach (string pais in Model)
{

#line default
#line hidden
            BeginContext(57, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(65, 4, false);
#line 4 "D:\GitHub\NetCoreIntermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Cache\Views\Shared\Components\Pais\Default.cshtml"
  Write(pais);

#line default
#line hidden
            EndContext();
            BeginContext(69, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 5 "D:\GitHub\NetCoreIntermedio\01 - Componentes MVC Y aplicando seguridad al Website\Galaxy.MVC\Galaxy.MVC.Cache\Views\Shared\Components\Pais\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
