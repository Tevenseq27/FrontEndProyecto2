#pragma checksum "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05c71457cb776689ec22cc49a5b32e119b4ee401"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ruta_Consulta), @"mvc.1.0.view", @"/Views/Ruta/Consulta.cshtml")]
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
#line 1 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\_ViewImports.cshtml"
using Presentacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\_ViewImports.cshtml"
using Presentacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05c71457cb776689ec22cc49a5b32e119b4ee401", @"/Views/Ruta/Consulta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf57c469e1b8e05140e56e7f20f29b558100cc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Ruta_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Presentacion.Models.RutaModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearRuta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ruta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c71457cb776689ec22cc49a5b32e119b4ee4014025", async() => {
                WriteLiteral("Crear nueva ruta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.DisplayNameFor(model => model.IdRuta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.DisplayNameFor(model => model.TerminalSalida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.DisplayNameFor(model => model.TerminalLlegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadParadas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.DisplayNameFor(model => model.MontoEstimadoRuta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdRuta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.DisplayFor(modelItem => item.TerminalSalida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.DisplayFor(modelItem => item.TerminalLlegada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantidadParadas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.DisplayFor(modelItem => item.MontoEstimadoRuta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.ActionLink("Modificar", "EditaRuta", "Ruta", new { item.IdRuta }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 53 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
           Write(Html.ActionLink("Eliminar", "Eliminar", "Ruta", new { item.IdRuta }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\SSequeira\source\repos\FrontEndProyecto2\Presentacion\Views\Ruta\Consulta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Presentacion.Models.RutaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591