#pragma checksum "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47496da0d2cd46339c9fa043d2127c32ea57569c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Index.cshtml", typeof(AspNetCore.Views_Usuarios_Index))]
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
#line 1 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\_ViewImports.cshtml"
using SGVT;

#line default
#line hidden
#line 2 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\_ViewImports.cshtml"
using SGVT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47496da0d2cd46339c9fa043d2127c32ea57569c", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b6f2e4d3dd42cafe5bc7f2c4220b86aff87f720", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGVT.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 606, true);
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

<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
            EndContext();
            BeginContext(691, 44, false);
#line 26 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(735, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(791, 46, false);
#line 29 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(837, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(893, 46, false);
#line 32 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(939, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(995, 44, false);
#line 35 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NuCorreo));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1095, 45, false);
#line 38 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IuCelular));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1196, 47, false);
#line 41 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NuDireccion));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1299, 48, false);
#line 44 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1403, 61, false);
#line 47 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FkIdTipoUsuarioNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 53 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1582, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1631, 43, false);
#line 56 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(1674, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1730, 45, false);
#line 59 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1775, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1831, 45, false);
#line 62 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1932, 43, false);
#line 65 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NuCorreo));

#line default
#line hidden
            EndContext();
            BeginContext(1975, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2031, 44, false);
#line 68 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IuCelular));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2131, 46, false);
#line 71 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NuDireccion));

#line default
#line hidden
            EndContext();
            BeginContext(2177, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2233, 47, false);
#line 74 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(2280, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2336, 76, false);
#line 77 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkIdTipoUsuarioNavigation.PkIdTipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(2412, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2467, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b46cac5820f4a3f930345216580ab9a", async() => {
                BeginContext(2515, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
                                       WriteLiteral(item.PkDni);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2525, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2545, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55df679e4214889bc332825c539b712", async() => {
                BeginContext(2596, 8, true);
                WriteLiteral("Detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
                                          WriteLiteral(item.PkDni);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2608, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2628, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb2835f8fc5141d5866f2f67e474cd76", async() => {
                BeginContext(2678, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
                                         WriteLiteral(item.PkDni);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2690, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 85 "H:\SGVT-Rodrigo (3)\SGVT-Rodrigo\SGVT\SGVT\Views\Usuarios\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2729, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SGVT.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
