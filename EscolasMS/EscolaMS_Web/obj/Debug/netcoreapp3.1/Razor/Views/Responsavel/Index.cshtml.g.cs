#pragma checksum "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68c07b3a4cf76abe1224ebe5cf016a70a247f967"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Responsavel_Index), @"mvc.1.0.view", @"/Views/Responsavel/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c07b3a4cf76abe1224ebe5cf016a70a247f967", @"/Views/Responsavel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5314cae24cea7f0e58a81e0d9ff3348dc61adb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Responsavel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ResponsavelViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main role=\"main\">\r\n    <div class=\"container\" style=\"margin-top: 20px;\">\r\n        <h1>Responsáveis</h1>\r\n        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68c07b3a4cf76abe1224ebe5cf016a70a247f9674382", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> Incluir Novo");
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
            WriteLiteral("\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 17 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ResponsavelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 20 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 32 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 36 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ResponsavelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 39 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                       Write(Html.ActionLink("Deletar", "Delete", new { id = item.ResponsavelId }, new { @class = "float-right btn btn-danger btn-sm mt-1 ml-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 49 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                       Write(Html.ActionLink("Ver", "Details", new { id = item.ResponsavelId }, new { @class = "float-right btn btn-primary btn-sm mt-1 ml-1 mr-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 50 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                       Write(Html.ActionLink("Editar", "Edit", new { id = item.ResponsavelId }, new { @class = "float-right btn btn-success btn-sm mt-1 mr-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "E:\Projetos C#\Teste SGI\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ResponsavelViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
