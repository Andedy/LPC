#pragma checksum "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56dcf5611963a8644f4c73397e462af7589773e1"
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
#line 1 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\_ViewImports.cshtml"
using contasLuz;

#line default
#line hidden
#line 2 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\_ViewImports.cshtml"
using contasLuz.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56dcf5611963a8644f4c73397e462af7589773e1", @"/Views/Conta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ab121d0eaa5960892aca858e56d05a9dffd7992", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<contasLuz.Models.ContaLuzViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
  
    ViewData["Title"] = "Contas de Luz";

#line default
#line hidden
            BeginContext(96, 490, true);
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
#line 28 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
         foreach(var item in Model.listaContasLuz)
        {

#line default
#line hidden
            BeginContext(649, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(688, 16, false);
#line 31 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
               Write(item.dataLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(704, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(732, 18, false);
#line 32 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
               Write(item.numeroLeitura);

#line default
#line hidden
            EndContext();
            BeginContext(750, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(778, 12, false);
#line 33 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
               Write(item.kwGasto);

#line default
#line hidden
            EndContext();
            BeginContext(790, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(818, 15, false);
#line 34 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
               Write(item.valorPagar);

#line default
#line hidden
            EndContext();
            BeginContext(833, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(861, 18, false);
#line 35 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
               Write(item.dataPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(879, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(907, 17, false);
#line 36 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
               Write(item.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(924, 52, true);
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                    href=\"", 976, "\"", 1036, 2);
            WriteAttributeValue("", 1004, "Conta/Delete/", 1004, 13, true);
#line 38 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
WriteAttributeValue("", 1017, item.numeroLeitura, 1017, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1037, 65, true);
            WriteLiteral(">Delete</a> </td>\r\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " \r\n                    href=\"", 1102, "\"", 1161, 2);
            WriteAttributeValue("", 1131, "Conta/Edit/", 1131, 11, true);
#line 40 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
WriteAttributeValue("", 1142, item.numeroLeitura, 1142, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1162, 38, true);
            WriteLiteral(">Editar</a> </td>\r\n            </tr>\r\n");
            EndContext();
#line 42 "C:\Users\Felipe\Documents\lpc-torres-2019-2\contasLuz\Views\Conta\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1211, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<contasLuz.Models.ContaLuzViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
