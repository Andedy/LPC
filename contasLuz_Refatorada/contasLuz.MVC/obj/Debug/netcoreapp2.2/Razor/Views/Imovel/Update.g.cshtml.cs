#pragma checksum "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa3999d3ed7f5ffc2ab2c5dcae5f186f7da4dc51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Imovel_Update), @"mvc.1.0.view", @"/Views/Imovel/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Imovel/Update.cshtml", typeof(AspNetCore.Views_Imovel_Update))]
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
#line 1 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\_ViewImports.cshtml"
using contasLuz.MVC;

#line default
#line hidden
#line 2 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\_ViewImports.cshtml"
using contasLuz.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa3999d3ed7f5ffc2ab2c5dcae5f186f7da4dc51", @"/Views/Imovel/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"737471fec7f0af6b8b6930ed588a4461b32a60de", @"/Views/_ViewImports.cshtml")]
    public class Views_Imovel_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<contasLuz.Entities.Imoveis>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
  
    ViewData["Title"] = "Imoveis";

#line default
#line hidden
            BeginContext(74, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(108, 28, false);
#line 9 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(147, 33, false);
#line 11 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
   Write(Html.HiddenFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(182, 211, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 text-left\">\n            <div class=\"editor-label\">\n                Identificação\n            </div>\n            <div class=\"editor-field\">\n                ");
            EndContext();
            BeginContext(394, 101, false);
#line 18 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
           Write(Html.EditorFor(model => model.identificação, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(495, 53, true);
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(549, 55, false);
#line 19 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.identificação));

#line default
#line hidden
            EndContext();
            BeginContext(604, 43, true);
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(648, 204, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 text-left\">\n            <div class=\"editor-label\">\n                Numero\n            </div>\n            <div class=\"editor-field\">\n                ");
            EndContext();
            BeginContext(853, 94, false);
#line 28 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
           Write(Html.EditorFor(model => model.numero, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(947, 53, true);
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1001, 48, false);
#line 29 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.numero));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 43, true);
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(1093, 204, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 text-left\">\n            <div class=\"editor-label\">\n                Bairro\n            </div>\n            <div class=\"editor-field\">\n                ");
            EndContext();
            BeginContext(1298, 94, false);
#line 38 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
           Write(Html.EditorFor(model => model.bairro, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 53, true);
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1446, 48, false);
#line 39 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 43, true);
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(1538, 204, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 text-left\">\n            <div class=\"editor-label\">\n                Cidade\n            </div>\n            <div class=\"editor-field\">\n                ");
            EndContext();
            BeginContext(1743, 94, false);
#line 48 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
           Write(Html.EditorFor(model => model.cidade, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 53, true);
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1891, 48, false);
#line 49 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1939, 43, true);
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(1983, 204, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 text-left\">\n            <div class=\"editor-label\">\n                Estado\n            </div>\n            <div class=\"editor-field\">\n                ");
            EndContext();
            BeginContext(2188, 94, false);
#line 58 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
           Write(Html.EditorFor(model => model.estado, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2282, 53, true);
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2336, 48, false);
#line 59 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.estado));

#line default
#line hidden
            EndContext();
            BeginContext(2384, 43, true);
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(2428, 153, true);
            WriteLiteral("        <div class=\"d-block text-left\">\n            <button type=\"submit\" class=\"btn btn-success d-block my-4 text-left\">Atualizar</button>\n\n            ");
            EndContext();
            BeginContext(2582, 79, false);
#line 66 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
       Write(Html.ActionLink("Voltar", "Index", null, null, new { @class = "mt-2 d-block" }));

#line default
#line hidden
            EndContext();
            BeginContext(2661, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 68 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz_Refatorada\contasLuz.MVC\Views\Imovel\Update.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<contasLuz.Entities.Imoveis> Html { get; private set; }
    }
}
#pragma warning restore 1591
