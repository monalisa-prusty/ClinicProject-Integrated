#pragma checksum "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\DocAddTimeSlot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31a21bb9168f4e9e2283b1b2a1d475c7cb68de1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DocAddTimeSlot), @"mvc.1.0.view", @"/Views/Admin/DocAddTimeSlot.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a21bb9168f4e9e2283b1b2a1d475c7cb68de1c", @"/Views/Admin/DocAddTimeSlot.cshtml")]
    public class Views_Admin_DocAddTimeSlot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.DoctorScheduleViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\DocAddTimeSlot.cshtml"
  Layout = "~/views/shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a21bb9168f4e9e2283b1b2a1d475c7cb68de1c2890", async() => {
                WriteLiteral("\n   \n    <h1 id=\"main\" class=\"alert alert-success\">Add Schedule Time</h1>\n    <hr />\n    <div class=\"row\">\n        <div class=\"col-md-4\">\n");
#nullable restore
#line 10 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\DocAddTimeSlot.cshtml"
             using (Html.BeginForm("DocAddTimeSlot", "Admin", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\DocAddTimeSlot.cshtml"
           Write(Html.LabelFor(m => m.EnteredTime, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\DocAddTimeSlot.cshtml"
           Write(Html.EditorFor(m => m.EnteredTime, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\DocAddTimeSlot.cshtml"
           Write(Html.ValidationMessageFor(m => m.EnteredTime, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button class=\"btn btn-primary\">Add Schedule </button>\n");
#nullable restore
#line 17 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\DocAddTimeSlot.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    </div>\n\n    <section>\n");
                WriteLiteral("\n        <p>");
#nullable restore
#line 24 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\DocAddTimeSlot.cshtml"
      Write(Html.ActionLink("Back", "DocMain"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n\n\n\n    </section>\n");
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
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.DoctorScheduleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
