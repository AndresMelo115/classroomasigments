#pragma checksum "C:\Users\Sane\source\repos\Ejercicio1\Ejercicio1\Views\Home\Horoscopo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c28c24ee3f6dc6297c496b5a311a6f979efe0ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Horoscopo), @"mvc.1.0.view", @"/Views/Home/Horoscopo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Horoscopo.cshtml", typeof(AspNetCore.Views_Home_Horoscopo))]
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
#line 1 "C:\Users\Sane\source\repos\Ejercicio1\Ejercicio1\Views\_ViewImports.cshtml"
using Ejercicio1;

#line default
#line hidden
#line 2 "C:\Users\Sane\source\repos\Ejercicio1\Ejercicio1\Views\_ViewImports.cshtml"
using Ejercicio1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c28c24ee3f6dc6297c496b5a311a6f979efe0ef", @"/Views/Home/Horoscopo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4208cf12cc68e8567e72877a21b2ffbbd3bf49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Horoscopo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Sane\source\repos\Ejercicio1\Ejercicio1\Views\Home\Horoscopo.cshtml"
  
    ViewData["Title"] = "Resultado";


#line default
#line hidden
            BeginContext(47, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(52, 14, false);
#line 5 "C:\Users\Sane\source\repos\Ejercicio1\Ejercicio1\Views\Home\Horoscopo.cshtml"
Write(ViewBag.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(66, 4, true);
            WriteLiteral(" es ");
            EndContext();
            BeginContext(71, 17, false);
#line 5 "C:\Users\Sane\source\repos\Ejercicio1\Ejercicio1\Views\Home\Horoscopo.cshtml"
                  Write(ViewBag.Resultado);

#line default
#line hidden
            EndContext();
            BeginContext(88, 9, true);
            WriteLiteral("  </h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
