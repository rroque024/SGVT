#pragma checksum "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c3f38d60b62eb2c292824ae18daa306e75b89a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Delete), @"mvc.1.0.view", @"/Views/Usuarios/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Delete.cshtml", typeof(AspNetCore.Views_Usuarios_Delete))]
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
#line 1 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\_ViewImports.cshtml"
using SGVT;

#line default
#line hidden
#line 2 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\_ViewImports.cshtml"
using SGVT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c3f38d60b62eb2c292824ae18daa306e75b89a", @"/Views/Usuarios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b6f2e4d3dd42cafe5bc7f2c4220b86aff87f720", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGVT.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(72, 619, true);
            WriteLiteral(@"
<section class=""banner_area"">
    <div class=""banner_inner d-flex align-items-center"">
        <div class=""container"">
            <div class=""banner_content text-center"">
                <h2>Shop Category Page</h2>
                <div class=""page_link"">
                    <a href=""index.html"">Home</a>
                    <a href=""category.html"">Category</a>
                    <a href=""category.html"">Women Fashion</a>
                </div>
            </div>
        </div>
    </div>
</section>
<div>
    <h4>Usuario</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            ");
            EndContext();
            BeginContext(692, 44, false);
#line 26 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(736, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(780, 40, false);
#line 29 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(820, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(864, 46, false);
#line 32 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(910, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(954, 42, false);
#line 35 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(996, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1040, 46, false);
#line 38 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1130, 42, false);
#line 41 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1216, 44, false);
#line 44 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NuCorreo));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1304, 40, false);
#line 47 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NuCorreo));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1388, 45, false);
#line 50 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IuCelular));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1477, 41, false);
#line 53 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IuCelular));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1562, 47, false);
#line 56 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NuDireccion));

#line default
#line hidden
            EndContext();
            BeginContext(1609, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1653, 43, false);
#line 59 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NuDireccion));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1740, 48, false);
#line 62 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1832, 44, false);
#line 65 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1920, 61, false);
#line 68 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIdTipoUsuarioNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1981, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2025, 73, false);
#line 71 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FkIdTipoUsuarioNavigation.PkIdTipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(2098, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(2132, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "decfe4aa2ad84e99a9dcb47118e2e4fa", async() => {
                BeginContext(2158, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2168, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1aadc28d516d4ea69ccce851ca945629", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 76 "D:\Rodrigo\RepoGit\SGVT\SGVT\SGVT\Views\Usuarios\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PkDni);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2207, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2291, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ebdba074bee491b89190c755cedff9e", async() => {
                    BeginContext(2313, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2329, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2342, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGVT.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
