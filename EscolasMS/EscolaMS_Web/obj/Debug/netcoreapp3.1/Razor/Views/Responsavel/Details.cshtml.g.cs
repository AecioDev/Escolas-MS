#pragma checksum "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acb96e97731f31fd6839b8721a0628d231fc779c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Responsavel_Details), @"mvc.1.0.view", @"/Views/Responsavel/Details.cshtml")]
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
#line 1 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\_ViewImports.cshtml"
using EscolaMS_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\_ViewImports.cshtml"
using EscolaMS_Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\_ViewImports.cshtml"
using EscolaMS_Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb96e97731f31fd6839b8721a0628d231fc779c", @"/Views/Responsavel/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5314cae24cea7f0e58a81e0d9ff3348dc61adb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Responsavel_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResponsavelViewModel>
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
#line 3 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml"
  
    ViewData["Title"] = "Detalhes Responsável";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">
    <div class=""container col-sm-6"" style=""margin-top: 20px;"">
        <h1>Detalhes do Responsável</h1>
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
#line 18 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ResponsavelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 21 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ResponsavelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 24 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 27 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 30 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 33 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml"
                               Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 36 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 39 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                            </dl>\r\n                        </article>\r\n                    </div>\r\n                </aside>\r\n            </div>\r\n        </section>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acb96e97731f31fd6839b8721a0628d231fc779c8317", async() => {
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
            WriteLiteral("\r\n            ");
#nullable restore
#line 49 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Details.cshtml"
       Write(Html.ActionLink("Editar", "Edit", new { id = Model.ResponsavelId }, new { @class = "float-right btn btn-outline-success mt-1 mr-1" }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResponsavelViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
