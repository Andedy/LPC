#pragma checksum "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f02f1de87699f8656cd4b86ce77782c989d4a623"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f02f1de87699f8656cd4b86ce77782c989d4a623", @"/Views/Conta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ab121d0eaa5960892aca858e56d05a9dffd7992", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<contasLuz.Models.Conta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 488, true);
            WriteLiteral(@"
    

<a href=""Create"" class=""btn btn-primary"">Nova Conta</a>


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
            BeginContext(580, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(619, 16, false);
#line 26 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.dataLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(635, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(663, 18, false);
#line 27 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.numeroLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(681, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(709, 12, false);
#line 28 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.kwGasto);

#line default
#line hidden
            EndContext();
            BeginContext(721, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(749, 15, false);
#line 29 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.valorPagar);

#line default
#line hidden
            EndContext();
            BeginContext(764, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(792, 18, false);
#line 30 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.dataPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(810, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(838, 17, false);
#line 31 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
               Write(item.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(855, 52, true);
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                    href=\"", 907, "\"", 967, 2);
            WriteAttributeValue("", 935, "Conta/Delete/", 935, 13, true);
#line 33 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
WriteAttributeValue("", 948, item.numeroLeitura, 948, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(968, 65, true);
            WriteLiteral(">Delete</a> </td>\r\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " \r\n                    href=\"", 1033, "\"", 1092, 2);
            WriteAttributeValue("", 1062, "Conta/Edit/", 1062, 11, true);
#line 35 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
WriteAttributeValue("", 1073, item.numeroLeitura, 1073, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1093, 38, true);
            WriteLiteral(">Editar</a> </td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\contasLuz\Views\Conta\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1142, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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