#pragma checksum "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b6685f71f30cc67d16a9fe098d2d81f886ddf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loteamento_Listagem), @"mvc.1.0.view", @"/Views/Loteamento/Listagem.cshtml")]
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
#line 1 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\_ViewImports.cshtml"
using Etapa_No._2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\_ViewImports.cshtml"
using Etapa_No._2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b6685f71f30cc67d16a9fe098d2d81f886ddf6", @"/Views/Loteamento/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2972a7280bcbea6bf78e31b9a10507de4f982efd", @"/Views/_ViewImports.cshtml")]
    public class Views_Loteamento_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Loteamento>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Loteamentos";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2b6685f71f30cc67d16a9fe098d2d81f886ddf63722", async() => {
                WriteLiteral("\r\n<style>\r\ntable {\r\n  border-collapse: collapse;\r\n  width: 100%;\r\n}\r\n\r\nth, td {\r\n  text-align: left;\r\n  padding: 8px;\r\n}\r\n\r\ntr:nth-child(even){background-color: #f2f2f2}\r\n\r\nth {\r\n  background-color: #04AA6D;\r\n  color: white;\r\n}\r\n</style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2b6685f71f30cc67d16a9fe098d2d81f886ddf64961", async() => {
                WriteLiteral(@"

<table class = ""table"">
    <table class=""table"">
                    <tr>
                        <th>Id</th>
                        <th>Nome Loteamento</th>
                        <th>Nome Cliente</th>
                        <th>CPF</th>
                        <th>Valor Lote</th>
                        <th>Entrada R$</th>
                        <th>Qtd Prestações</th>
                        <th>Valor Prestação</th>
                        <th>Data Contrato</th>
                        <th>Operações</th>

                    </tr>

");
#nullable restore
#line 48 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
                     foreach (Loteamento l in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 51 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
                           Write(l.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
                           Write(l.Nome_Lote);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
                           Write(l.Nome_Cliente);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
                           Write(l.CPF);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
                           Write(l.Valor_Lote);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
                           Write(l.Entrada);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
                           Write(l.Qtd_Parcelas);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 58 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
                           Write(l.Valor_Parcela);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 59 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
                           Write(l.Data_Contrato.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1598, "\"", 1632, 2);
                WriteAttributeValue("", 1605, "/Loteamento/Editar?Id=", 1605, 22, true);
#nullable restore
#line 62 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
WriteAttributeValue("", 1627, l.Id, 1627, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Alterar</a>|\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1682, "\"", 1717, 2);
                WriteAttributeValue("", 1689, "/Loteamento/Excluir?Id=", 1689, 23, true);
#nullable restore
#line 63 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"
WriteAttributeValue("", 1712, l.Id, 1712, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                onclick=\"return confirm(\'Desesaja remover esse item?\');\">Remover</a>\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 68 "C:\Users\ozima\Dropbox\Ozimar\Sesc\Tecnico\Estudos\Modulo_B\UC08\Projeto Integrador\Etapa No. 2\Views\Loteamento\Listagem.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Loteamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
