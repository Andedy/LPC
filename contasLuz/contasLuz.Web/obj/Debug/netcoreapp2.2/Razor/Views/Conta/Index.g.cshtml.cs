#pragma checksum "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72128808494b18e3d7aadb462b48df30926ede0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_Index), @"mvc.1.0.view", @"/Views/Conta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conta/Index.cshtml", typeof(AspNetCore.Views_Conta_Index))]
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
#line 1 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\_ViewImports.cshtml"
using contasLuz;

#line default
#line hidden
#line 2 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\_ViewImports.cshtml"
using contasLuz.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72128808494b18e3d7aadb462b48df30926ede0b", @"/Views/Conta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84a2ceded78b1724561887516d23b2a138045c11", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<contasLuz.Models.Conta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 473, true);
            WriteLiteral(@"
    

<a href=""Conta/Create"" class=""btn btn-primary"">Nova Conta</a>


<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Data Leitura</th>
                <th>Número Leitura</th>
                <th>Kw Gastos</th>
                <th>Valor a Pagar</th>
                <th>Data Pagamento</th>
                <th>Média Consumo</th>
                <th></th>
                <th></th>
            </tr>
        </thead>

");
            EndContext();
#line 23 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(562, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(600, 16, false);
#line 26 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.dataLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(616, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(643, 18, false);
#line 27 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.numeroLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(661, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(688, 12, false);
#line 28 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.kwGasto);

#line default
#line hidden
            EndContext();
            BeginContext(700, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(727, 15, false);
#line 29 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.valorPagar);

#line default
#line hidden
            EndContext();
            BeginContext(742, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(769, 18, false);
#line 30 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.dataPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(787, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(814, 17, false);
#line 31 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(831, 51, true);
            WriteLiteral("</td>\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\n                    href=\"", 882, "\"", 941, 2);
            WriteAttributeValue("", 909, "Conta/Delete/", 909, 13, true);
#line 33 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
WriteAttributeValue("", 922, item.numeroLeitura, 922, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(942, 64, true);
            WriteLiteral(">Delete</a> </td>\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " \n                    href=\"", 1006, "\"", 1053, 2);
            WriteAttributeValue("", 1034, "Conta/Edit/", 1034, 11, true);
#line 35 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
WriteAttributeValue("", 1045, item.id, 1045, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1054, 36, true);
            WriteLiteral(">Editar</a> </td>\n            </tr>\n");
            EndContext();
#line 37 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1100, 19, true);
            WriteLiteral("    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<contasLuz.Models.Conta>> Html { get; private set; }
    }
}
#pragma warning restore 1591