#pragma checksum "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7af8b8e128b42a8d21867b44839a1e6809c6d7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunos_Details), @"mvc.1.0.view", @"/Views/Alunos/Details.cshtml")]
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
#line 1 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\_ViewImports.cshtml"
using EscolaMS_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\_ViewImports.cshtml"
using EscolaMS_Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\_ViewImports.cshtml"
using EscolaMS_Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7af8b8e128b42a8d21867b44839a1e6809c6d7a", @"/Views/Alunos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5314cae24cea7f0e58a81e0d9ff3348dc61adb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Alunos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlunoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right btn btn-outline-dark mt-1 mr-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
  
    ViewData["Title"] = "Detalhes Aluno";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">
    <div class=""container col-sm-6"" style=""margin-top: 20px;"">
        <h1>Detalhes do Aluno</h1>        
        <hr />
        <section class=""container"" style=""margin-top: 10px"">
            <div class=""row"">
                <aside>
                    <div class=""card"">
                        <article class=""card-body"">
                            <dl class=""row"">
                                <dt class=""col-sm-4"">
                                    ");
#nullable restore
#line 18 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.AlunoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 21 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayFor(model => model.AlunoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 24 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 27 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 30 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 33 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 36 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.NumeroCertidaoNova));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 39 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayFor(model => model.NumeroCertidaoNova));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 42 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 45 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 48 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ResponsavelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 51 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ResponsavelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                            </dl>\r\n                        </article>\r\n                    </div>\r\n                </aside>\r\n            </div>\r\n        </section>        \r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7af8b8e128b42a8d21867b44839a1e6809c6d7a9628", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("            \r\n            ");
#nullable restore
#line 61 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Alunos\Details.cshtml"
       Write(Html.ActionLink("Editar", "Edit", new { id = Model.AlunoId }, new { @class = "float-right btn btn-outline-success mt-1 mr-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlunoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
