#pragma checksum "C:\WEB_PROJECT\KLOVE_ASSIGNMENT\Views\Home\CRUD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a830a44289b2b7ff23f8d90e1b6d456d25b88e67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CRUD), @"mvc.1.0.view", @"/Views/Home/CRUD.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CRUD.cshtml", typeof(AspNetCore.Views_Home_CRUD))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a830a44289b2b7ff23f8d90e1b6d456d25b88e67", @"/Views/Home/CRUD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a21bf94ad14e10f292003487f31bb81fd3a534ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CRUD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\WEB_PROJECT\KLOVE_ASSIGNMENT\Views\Home\CRUD.cshtml"
  
    ViewData["Title"] = "CRUD";

#line default
#line hidden
            BeginContext(42, 309, true);
            WriteLiteral(@"
<h2>CRUD</h2>
<ul>
    <li><a href=""/employees"">Employees</a></li>
    <li><a href=""/departments"">Departments</a></li>
    <li><a href=""/employeedepartments"">Associate Employee to Department</a></li>
    <li><a href=""/employeedepartments/DepartmentEmps"">Employees per Department</a></li>


</ul>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591