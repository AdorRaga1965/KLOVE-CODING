#pragma checksum "C:\WEB_PROJECT\KLOVE_ASSIGNMENT\Views\EmployeeDepartments\DepartmentEmps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea17c0c0733b00611d6f3d69ad9bd83c5309cc47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeDepartments_DepartmentEmps), @"mvc.1.0.view", @"/Views/EmployeeDepartments/DepartmentEmps.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeeDepartments/DepartmentEmps.cshtml", typeof(AspNetCore.Views_EmployeeDepartments_DepartmentEmps))]
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
#line 1 "C:\WEB_PROJECT\KLOVE_ASSIGNMENT\Views\_ViewImports.cshtml"
using KLOVE_ASSIGNMENT;

#line default
#line hidden
#line 2 "C:\WEB_PROJECT\KLOVE_ASSIGNMENT\Views\_ViewImports.cshtml"
using KLOVE_ASSIGNMENT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea17c0c0733b00611d6f3d69ad9bd83c5309cc47", @"/Views/EmployeeDepartments/DepartmentEmps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a21bf94ad14e10f292003487f31bb81fd3a534ee", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeDepartments_DepartmentEmps : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KLOVE_ASSIGNMENT.Models.Employeedepartment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\WEB_PROJECT\KLOVE_ASSIGNMENT\Views\EmployeeDepartments\DepartmentEmps.cshtml"
  
    ViewData["Title"] = "DepartmentEmps";

#line default
#line hidden
            BeginContext(102, 215, true);
            WriteLiteral("\r\n<h2>Department Employees</h2>\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Employee-Department</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Employee\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(318, 42, false);
#line 17 "C:\WEB_PROJECT\KLOVE_ASSIGNMENT\Views\EmployeeDepartments\DepartmentEmps.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(360, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Department\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(457, 44, false);
#line 23 "C:\WEB_PROJECT\KLOVE_ASSIGNMENT\Views\EmployeeDepartments\DepartmentEmps.cshtml"
       Write(Html.DisplayFor(model => model.DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(501, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(548, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60c00a19722a42629487a190bcf21aa0", async() => {
                BeginContext(570, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(586, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KLOVE_ASSIGNMENT.Models.Employeedepartment> Html { get; private set; }
    }
}
#pragma warning restore 1591
