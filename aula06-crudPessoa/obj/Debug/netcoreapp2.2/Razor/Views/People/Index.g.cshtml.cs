#pragma checksum "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\aula06-crudPessoa\Views\People\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ebf560da27913f7e600ee0871c3c8afd0cabd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Index), @"mvc.1.0.view", @"/Views/People/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/People/Index.cshtml", typeof(AspNetCore.Views_People_Index))]
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
#line 1 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\aula06-crudPessoa\Views\_ViewImports.cshtml"
using aula06_crudPessoa;

#line default
#line hidden
#line 2 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\aula06-crudPessoa\Views\_ViewImports.cshtml"
using aula06_crudPessoa.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ebf560da27913f7e600ee0871c3c8afd0cabd3", @"/Views/People/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"418e5af647c110ec35ce28c7316ca423196eab23", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aula06_crudPessoa.Models.Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 374, true);
            WriteLiteral(@"
    
</br></br>
<a href=""People/Create"" class=""btn btn-primary"">Nova Pessoa</a>
</br></br>

<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Endereço</th>
                <th></th>
                <th></th>
            </tr>
        </thead>

");
            EndContext();
#line 20 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\aula06-crudPessoa\Views\People\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
            BeginContext(475, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(514, 7, false);
#line 23 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\aula06-crudPessoa\Views\People\Index.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(521, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(549, 9, false);
#line 24 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\aula06-crudPessoa\Views\People\Index.cshtml"
               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(558, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(586, 12, false);
#line 25 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\aula06-crudPessoa\Views\People\Index.cshtml"
               Write(item.address);

#line default
#line hidden
            EndContext();
            BeginContext(598, 52, true);
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                    href=\"", 650, "\"", 700, 2);
            WriteAttributeValue("", 678, "People/Delete/", 678, 14, true);
#line 27 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\aula06-crudPessoa\Views\People\Index.cshtml"
WriteAttributeValue("", 692, item.id, 692, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(701, 65, true);
            WriteLiteral(">Delete</a> </td>\r\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " \r\n                    href=\"", 766, "\"", 815, 2);
            WriteAttributeValue("", 795, "People/Edit/", 795, 12, true);
#line 29 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\aula06-crudPessoa\Views\People\Index.cshtml"
WriteAttributeValue("", 807, item.id, 807, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(816, 38, true);
            WriteLiteral(">Editar</a> </td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\andre\Documents\05 - ulbra\2019-2\linguagem de programação comercial\LPC\aula06-crudPessoa\Views\People\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(865, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aula06_crudPessoa.Models.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
