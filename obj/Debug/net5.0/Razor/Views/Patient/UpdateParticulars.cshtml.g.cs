#pragma checksum "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "298880a503518bc6751749d32631a59e40ca3dd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_UpdateParticulars), @"mvc.1.0.view", @"/Views/Patient/UpdateParticulars.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298880a503518bc6751749d32631a59e40ca3dd3", @"/Views/Patient/UpdateParticulars.cshtml")]
    public class Views_Patient_UpdateParticulars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
  Layout = "~/views/shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<title> Update Particulars</title>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "298880a503518bc6751749d32631a59e40ca3dd33847", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "298880a503518bc6751749d32631a59e40ca3dd34961", async() => {
                WriteLiteral("\n    <div>\n");
#nullable restore
#line 10 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
         using (Html.BeginForm("UpdateParticulars", "Patient", FormMethod.Post))
        {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
   Write(Html.LabelFor(m => m.Username, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
   Write(Html.DisplayFor(m => m.Username));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
                                         ;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
   Write(Html.LabelFor(m => m.Name, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
   Write(Html.EditorFor(m => m.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
   Write(Html.LabelFor(m => m.Phone, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
   Write(Html.EditorFor(m => m.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button class=\"btn btn-primary\">Update Particulars</button> ");
#nullable restore
#line 18 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
                                                                                                                      }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\n        ");
#nullable restore
#line 20 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Patient\UpdateParticulars.cshtml"
   Write(Html.ActionLink("Return to Main Page", "PatientConsole", "Patient"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
