#pragma checksum "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeff7bc6be7f58b7e7fabed4c78feee95b0c6d17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Catego_Views_Categoria_Index), @"mvc.1.0.view", @"/Areas/Catego/Views/Categoria/Index.cshtml")]
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
#line 1 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\_ViewImports.cshtml"
using WebApplication1.Models.Paginador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\_ViewImports.cshtml"
using WebApplication1.Areas.Servi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeff7bc6be7f58b7e7fabed4c78feee95b0c6d17", @"/Areas/Catego/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880d6ad404bf2dabf0728214b26b1d89e067c32f", @"/Areas/Catego/Views/_ViewImports.cshtml")]
    public class Areas_Catego_Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataPaginador<Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Catego/Categoria/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Catego/Categoria/Agregar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Datos.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 style=\"text-align:center\">CATEGORIAS</h1>\r\n<br />\r\n<div class=\"intro-y col-span-12 overflow-auto lg:overflow-visible\">\r\n    <ul class=\"xl:text-right\">\r\n        <li>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeff7bc6be7f58b7e7fabed4c78feee95b0c6d175487", async() => {
                WriteLiteral("\r\n                <select class=\"w-30 input box mt-3 sm:mt-0 xl:text-left\" name=\"Registros\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeff7bc6be7f58b7e7fabed4c78feee95b0c6d175863", async() => {
                    WriteLiteral("Seleccionar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeff7bc6be7f58b7e7fabed4c78feee95b0c6d176902", async() => {
                    WriteLiteral("2");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeff7bc6be7f58b7e7fabed4c78feee95b0c6d177931", async() => {
                    WriteLiteral("4");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeff7bc6be7f58b7e7fabed4c78feee95b0c6d178960", async() => {
                    WriteLiteral("6");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeff7bc6be7f58b7e7fabed4c78feee95b0c6d179989", async() => {
                    WriteLiteral("8");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeff7bc6be7f58b7e7fabed4c78feee95b0c6d1711018", async() => {
                    WriteLiteral("10");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
                <input type=""search"" class=""input w-200 box pr-10 placeholder-theme-13"" placeholder=""Buscar..."" name=""Search"" />
                <button id=""buscar"" type=""submit"" class=""button w-8 xl:w-12 text-white bg-theme-1 xl:mr-2""><span class=""icon""><i class=""fa fa-search""></i></span></button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <br />\r\n        <li>\r\n            ");
#nullable restore
#line 23 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\Categoria\Index.cshtml"
       Write(Html.Raw(Model.Pagi_info));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </li>
    </ul>

</div>
<div class=""intro-y col-span-12 overflow-auto lg:overflow-visible"">
    <table class=""table table-report -mt-2"">
        <thead>
            <tr>
                <th class=""whitespace-no-wrap"">Codigo</th>
                <th class=""text-center whitespace-no-wrap"">Nombre</th>
                <th class=""text-center whitespace-no-wrap"">Opciones</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 38 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\Categoria\Index.cshtml"
             foreach (Categoria item in Model.Lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <div class=\"flex justify-center items-center\">\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\Categoria\Index.cshtml"
                       Write(item.CategoriaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\Categoria\Index.cshtml"
                       Write(item.NombreCategoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </div>\r\n                    <td class=\"table-report__action w-56\">\r\n                        <div class=\"flex justify-center items-center\">\r\n                            <a class=\"flex items-center mr-3\"");
            BeginWriteAttribute("href", " href=\"", 1983, "\"", 2032, 2);
            WriteAttributeValue("", 1990, "/Catego/Categoria/Editar/", 1990, 25, true);
#nullable restore
#line 47 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 2015, item.CategoriaId, 2015, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i data-feather=\"check-square\" class=\"w-4 h-4 mr-1\"></i> Editar </a>\r\n\r\n                            <button class=\"flex items-center text-theme-6\" data-toggle=\"modal\" data-target=\"#delete-confirmation-modal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2242, "\"", 2276, 3);
            WriteAttributeValue("", 2252, "Elimi(", 2252, 6, true);
#nullable restore
#line 49 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 2258, item.CategoriaId, 2258, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2275, ")", 2275, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i data-feather=\"trash-2\" class=\"w-4 h-4 mr-1\"></i> Eliminar </button>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 53 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\Categoria\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<div class=""intro-y col-span-12 overflow-auto lg:overflow-visible"">
    <table class=""table table-report -mt-2 xl:text-center"">
        <tbody>
            <tr>
                <td>
                    <ul id=""pagination"">
                        ");
#nullable restore
#line 63 "C:\Users\USUARIO\source\repos\WebApplication1\WebApplication1\Areas\Catego\Views\Categoria\Index.cshtml"
                   Write(Html.Raw(Model.Pagi_navegacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </td>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n<div class=\"intro-x mt-5 xl:mt-8 text-center xl:text-right\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeff7bc6be7f58b7e7fabed4c78feee95b0c6d1718037", async() => {
                WriteLiteral("\r\n        <button class=\"button button--lg w-full xl:w-32 text-white bg-theme-1 xl:mr-3\">Agregar</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeff7bc6be7f58b7e7fabed4c78feee95b0c6d1719242", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataPaginador<Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
