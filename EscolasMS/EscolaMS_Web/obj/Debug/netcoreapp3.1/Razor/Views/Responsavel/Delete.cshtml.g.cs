#pragma checksum "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5abe0adf0f0341e5f2a9393034e964ae8f899cf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Responsavel_Delete), @"mvc.1.0.view", @"/Views/Responsavel/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5abe0adf0f0341e5f2a9393034e964ae8f899cf9", @"/Views/Responsavel/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5314cae24cea7f0e58a81e0d9ff3348dc61adb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Responsavel_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResponsavelViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right btn btn-outline-dark mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Responsavel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
  
    ViewData["Title"] = "Deletar Responsável";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">
    <div class=""container col-sm-6"" style=""margin-top: 20px;"">
        <h1>Detalhes do Responsável</h1>
        <h3 class=""text-danger"">Deseja realmente deletar o cadastro deste Responsável?</h3>
        <hr />
        <section class=""container"" style=""margin-top: 10px"">
            <div class=""row"">
                <aside>
                    <div class=""card"">
                        <article class=""card-body"">
");
#nullable restore
#line 17 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                             if (TempData["MSG_E"] != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"alert alert-danger\">");
#nullable restore
#line 19 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                                                     Write(Html.Raw(TempData["MSG_E"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dl class=\"row\">\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 23 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.ResponsavelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 26 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.ResponsavelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 29 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 32 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 35 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 38 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-4\">\r\n                                    ");
#nullable restore
#line 41 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-8\">\r\n                                    ");
#nullable restore
#line 44 "D:\C#\Escolas-MS\EscolasMS\EscolaMS_Web\Views\Responsavel\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n                            </dl>\r\n                        </article>\r\n                    </div>\r\n                </aside>\r\n            </div>\r\n        </section>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5abe0adf0f0341e5f2a9393034e964ae8f899cf910149", async() => {
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Deletar\" class=\"btn btn-danger mt-1\" />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5abe0adf0f0341e5f2a9393034e964ae8f899cf910509", async() => {
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
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</main>");
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
