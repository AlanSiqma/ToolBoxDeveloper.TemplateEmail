#pragma checksum "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\EmailConfiguration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5673d358c94b5e52946a7c6f9694d488a90053d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmailConfiguration_Index), @"mvc.1.0.view", @"/Views/EmailConfiguration/Index.cshtml")]
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
#line 1 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\_ViewImports.cshtml"
using ToolBoxDeveloper.TemplateEmail.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\_ViewImports.cshtml"
using ToolBoxDeveloper.TemplateEmail.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5673d358c94b5e52946a7c6f9694d488a90053d", @"/Views/EmailConfiguration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82cdcf2e197ef29bb196e7a4342e51153e4a297b", @"/Views/_ViewImports.cshtml")]
    public class Views_EmailConfiguration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToolBoxDeveloper.TemplateEmail.Domain.Dto.EmailConfigurationDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\EmailConfiguration\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Configurações</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5673d358c94b5e52946a7c6f9694d488a90053d4355", async() => {
                WriteLiteral("\r\n        <i class=\"fa fa-plus\" aria-hidden=\"true\"></i>\r\n        Novo\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Host</th>
            <th>Porta</th>
            <th>User</th>
            <th>Editar</th>
            <th>Deletar</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\EmailConfiguration\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\EmailConfiguration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\EmailConfiguration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Host));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\EmailConfiguration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Port));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\EmailConfiguration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1121, "\"", 1169, 1);
#nullable restore
#line 43 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\EmailConfiguration\Index.cshtml"
WriteAttributeValue("", 1128, Url.Action("Edit", new { id = item.Id }), 1128, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">\r\n                        <i class=\"fa fa-pencil\" aria-hidden=\"true\"></i>\r\n                    </a>\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1410, 1);
#nullable restore
#line 48 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\EmailConfiguration\Index.cshtml"
WriteAttributeValue("", 1367, Url.Action("Delete", new { id = item.Id }), 1367, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\r\n                        <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "G:\source\ToolBoxDeveloper\ToolBoxDeveloper.TemplateEmail\ToolBoxDeveloper.TemplateEmail.MVC\Views\EmailConfiguration\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToolBoxDeveloper.TemplateEmail.Domain.Dto.EmailConfigurationDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
