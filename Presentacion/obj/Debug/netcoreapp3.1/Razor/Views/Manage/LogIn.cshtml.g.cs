#pragma checksum "E:\Github\FrontEndProyecto2\Presentacion\Views\Manage\LogIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a789c8416cdf81e2caa661e481458231fbb9db0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_LogIn), @"mvc.1.0.view", @"/Views/Manage/LogIn.cshtml")]
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
#line 1 "E:\Github\FrontEndProyecto2\Presentacion\Views\_ViewImports.cshtml"
using Presentacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Github\FrontEndProyecto2\Presentacion\Views\_ViewImports.cshtml"
using Presentacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a789c8416cdf81e2caa661e481458231fbb9db0", @"/Views/Manage/LogIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf57c469e1b8e05140e56e7f20f29b558100cc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_LogIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link-inline font-size-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("estilos", async() => {
                WriteLiteral(@"
    <style>
        .signup_v4 .social-area {
            text-align: center;
            padding-top: 14px
        }

            .signup_v4 .social-area .title {
                font-size: 20px;
                text-transform: uppercase;
                font-weight: 600;
                display: inline-block;
                color: #007bff;
                position: relative
            }

            .signup_v4 .social-area .text {
                font-size: 17px;
                font-weight: 400;
                color: #143250
            }

            .signup_v4 .social-area .title::before {
                position: absolute;
                content: '';
                width: 40px;
                height: 1px;
                background: rgba(0, 0, 0, .2);
                top: 50%;
                -webkit-transform: translateY(-50%);
                -ms-transform: translateY(-50%);
                transform: translateY(-50%);
                left: 100%;
              ");
                WriteLiteral(@"  margin-left: 7px
            }

            .signup_v4 .social-area .title::after {
                position: absolute;
                content: '';
                width: 40px;
                height: 1px;
                background: rgba(0, 0, 0, .2);
                top: 50%;
                -webkit-transform: translateY(-50%);
                -ms-transform: translateY(-50%);
                transform: translateY(-50%);
                right: 100%;
                margin-right: 7px
            }

        .signup_v4 ul.social-links {
            padding: 0;
            margin: 0
        }

        .signup_v4 .social-area .social-links li {
            display: inline-block
        }

            .signup_v4 .social-area .social-links li a i {
                width: 50px;
                height: 50px;
                border-radius: 50%;
                line-height: 50px;
                display: inline-block;
                color: #fff;
                margin: 0 5px;
     ");
                WriteLiteral(@"           -webkit-box-shadow: 0 5px 10px rgb(0 0 0 / 15%);
                box-shadow: 0 5px 10px rgb(0 0 0 / 15%)
            }

                .signup_v4 .social-area .social-links li a i.fa-facebook-f {
                    background: #0069f7
                }

                .signup_v4 .social-area .social-links li a i.fa-google-plus-g {
                    background: #d1062c
                }

        .signup_v4 .nav-tabs .nav-link.active {
            background: #007bff
        }

        .signup_v4 .nav-tabs .nav-link {
            background: #143250
        }

        .signup_v4 .nav-tabs .nav-link {
            border: 0;
            margin: 0;
            padding: 10px 0;
            text-align: center;
            border-radius: 0;
            color: #fff
        }

        .signup_v4 .nav-tabs li.nav-item {
            width: 50%
        }

        .signup_v4 .card-body {
            padding: 0px
        }

            .signup_v4 .card-body .tab-content {");
                WriteLiteral("\r\n                padding: 0 1.25rem 1.75em\r\n            }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 111 "E:\Github\FrontEndProyecto2\Presentacion\Views\Manage\LogIn.cshtml"
 if (ViewData["MENSAJE"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n    ");
#nullable restore
#line 114 "E:\Github\FrontEndProyecto2\Presentacion\Views\Manage\LogIn.cshtml"
Write(ViewData["MENSAJE"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n</div>\r\n");
#nullable restore
#line 119 "E:\Github\FrontEndProyecto2\Presentacion\Views\Manage\LogIn.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card signup_v4 mb-30"">
    <div class=""card-body"">
        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
            <li class=""nav-item"" role=""presentation""> <a class=""nav-link active"" id=""login-tab"" data-toggle=""tab"" href=""#login"" role=""tab"" aria-controls=""login"" aria-selected=""true"">Login</a> </li>
            <li class=""nav-item"" role=""presentation""> <a class=""nav-link"" id=""register-tab"" data-toggle=""tab"" href=""#register"" role=""tab"" aria-controls=""register"" aria-selected=""false"">Registro</a> </li>
        </ul>
        <div class=""tab-content"" id=""myTabContent"">
            <div class=""tab-pane fade show active"" id=""login"" role=""tabpanel"" aria-labelledby=""login-tab"">
                <h4 class=""text-center mt-4 mb-4"" style=""text-transform: uppercase;"">Login</h4>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a789c8416cdf81e2caa661e481458231fbb9db010327", async() => {
                WriteLiteral(@"
                    <div class=""form-row"">
                        <div class=""form-group col-md-12""> <label for=""inputName"">Email</label> <input type=""email"" name=""email"" class=""form-control"" id=""inputEmail4"" placeholder=""Escribe tu direccion de correo""");
                BeginWriteAttribute("required", " required=\"", 4563, "\"", 4574, 0);
                EndWriteAttribute();
                WriteLiteral("> </div>\r\n                        <div class=\"form-group col-md-12\"> <label for=\"inputName\">Contraseña</label> <input type=\"password\" name=\"password\" class=\"form-control\" id=\"inputPassword4\" placeholder=\"Escribe tu contraseña\"");
                BeginWriteAttribute("required", " required=\"", 4801, "\"", 4812, 0);
                EndWriteAttribute();
                WriteLiteral(@"> </div>
                        <div class=""form-group col-md-12"">
                            <div class=""d-flex flex-wrap justify-content-between align-items-center"">
                                <a href=""#"" target=""_blank"">¿Contraseña olvidada?</a>
                            </div>
                        </div>
                    </div>
                    <div class=""mt-2 mb-3""> <button class=""btn btn-primary full-width"" type=""submit"">Login</button> </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"tab-pane fade\" id=\"register\" role=\"tabpanel\" aria-labelledby=\"register-tab\">\r\n                <h4 class=\"text-center mt-4 mb-4\" style=\"text-transform: uppercase;\">Registro</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a789c8416cdf81e2caa661e481458231fbb9db013358", async() => {
                WriteLiteral(@"
                    <div class=""form-row"">
                        <div class=""form-group col-md-12""> <label for=""inputName"">Email</label> <input type=""email"" name=""email"" class=""form-control"" id=""inputEmail4"" placeholder=""Escribe tu dirección de correo *""");
                BeginWriteAttribute("required", " required=\"", 5879, "\"", 5890, 0);
                EndWriteAttribute();
                WriteLiteral("> </div>\r\n                        <div class=\"form-group col-md-12\"> <label for=\"inputName\">Contraseña</label> <input type=\"password\" name=\"password\" class=\"form-control\" id=\"inputPassword4\" placeholder=\"Escribe tu contraseña *\"");
                BeginWriteAttribute("required", " required=\"", 6119, "\"", 6130, 0);
                EndWriteAttribute();
                WriteLiteral(@"> </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6""> <label for=""inputName"">Nombre</label> <input type=""text"" name=""nombre"" class=""form-control"" id=""inputEmail4"" placeholder=""Escribe tu nombre *""> </div>
                        <div class=""form-group col-md-6""> <label for=""inputName"">Apellidos</label> <input type=""text"" name=""apellidos"" class=""form-control"" id=""inputEmail4"" placeholder=""Escribe tus apellidos""> </div>
                    </div>
                    <div class=""form-group form-row mt-2"">
                        <label class=""col-md-2 col-form-label user_group"">Tipo de usuario</label>
                        <div class=""col-md-10 pt-1"">
                            <div class=""form-check form-check-inline""> <input class=""form-check-input"" type=""radio"" name=""tipo"" id=""inlineRadio1"" value=""USUARIO"" required> <label class=""form-check-label"" for=""inlineRadio1"">USUARIO</label> </div>
                          ");
                WriteLiteral(@"  <div class=""form-check form-check-inline""> <input class=""form-check-input"" type=""radio"" name=""tipo"" id=""inlineRadio2"" value=""ADMIN"" required> <label class=""form-check-label"" for=""inlineRadio2"">ADMIN</label> </div>
                        </div>
                    </div>
                    <hr class=""mt-3 mb-4"">
                    <div class=""col-12"">
                        <div class=""d-flex flex-wrap justify-content-between align-items-center"">
                            <div class=""custom-checkbox d-block""> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a789c8416cdf81e2caa661e481458231fbb9db016118", async() => {
                    WriteLiteral("¿Ya tienes una cuenta? LogIn");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" </div> <button class=\"btn btn-primary mt-3 mt-sm-0\" type=\"submit\">Registrate</button>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
