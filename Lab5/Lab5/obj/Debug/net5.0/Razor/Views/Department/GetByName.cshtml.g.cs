#pragma checksum "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\Department\GetByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d467e03218bb6d3b15971c0fa5bce427aba005d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_GetByName), @"mvc.1.0.view", @"/Views/Department/GetByName.cshtml")]
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
#line 1 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\_ViewImports.cshtml"
using Lab5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\_ViewImports.cshtml"
using Lab5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d467e03218bb6d3b15971c0fa5bce427aba005d3", @"/Views/Department/GetByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de5c7a10af704975369c03e51a68b1f930a79786", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_GetByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d467e03218bb6d3b15971c0fa5bce427aba005d34035", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 55, "\"", 74, 1);
#nullable restore
#line 2 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\Department\GetByName.cshtml"
WriteAttributeValue("", 63, ViewBag.Id, 63, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Id""/>
    <table>
        <tr>
            <td><p>Enter Name:</p></td>
            <td><input type=""text"" name=""Name""/></td>
        </tr>
        <tr>
            <td><input type=""submit"" value=""GetByName""/></td>
        </tr>
    </table>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d467e03218bb6d3b15971c0fa5bce427aba005d36219", async() => {
                WriteLiteral(@"
    <div>
    <table>
        <tr>
            <td>Id</td>
            <td>>Name</td>
            <td>SupervisorPIB</td>
            <td>DeputySupervisorPIB</td>
            <td>SpecialistPIB</td>
            <td>EmployeePIB</td>
        </tr>
");
#nullable restore
#line 24 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\Department\GetByName.cshtml"
         foreach (var value in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n              <td>");
#nullable restore
#line 27 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\Department\GetByName.cshtml"
             Write(value.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 28 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\Department\GetByName.cshtml"
             Write(value.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 29 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\Department\GetByName.cshtml"
             Write(value.SupervisorPIB);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 30 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\Department\GetByName.cshtml"
             Write(value.DeputySupervisorPIB);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 31 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\Department\GetByName.cshtml"
             Write(value.SpecialistPIB);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 32 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\Department\GetByName.cshtml"
             Write(value.EmployeePIB);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\sasha\OneDrive\Рабочий стол\labs\5\Lab5\Lab5\Views\Department\GetByName.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
