#pragma checksum "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\AdminConsole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e476a9d1e2c435b94444e2102f96a9a4beb4ea7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminConsole), @"mvc.1.0.view", @"/Views/Admin/AdminConsole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e476a9d1e2c435b94444e2102f96a9a4beb4ea7b", @"/Views/Admin/AdminConsole.cshtml")]
    public class Views_Admin_AdminConsole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.Admin>
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
#line 3 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\AdminConsole.cshtml"
  Layout = "~/views/shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e476a9d1e2c435b94444e2102f96a9a4beb4ea7b2893", async() => {
                WriteLiteral("\n\n\n    <section class=\"alert alert-danger\">\n        ");
#nullable restore
#line 9 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\AdminConsole.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 10 "C:\CollaberaTraining\FinalPresentationProject\ClinicManagementProject-main\Views\Admin\AdminConsole.cshtml"
   Write(ViewData["Successful"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </section>

    <table class=""table table-borderless"">
        <thead>
            <tr>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope=""row"">1</th>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td>Empty for now</td>
            </tr>
            <tr>
                <th scope=""row"">1</th>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td><p>hello</p><p>hello</p><p>Empty for now</p></td>
            </tr>
            <tr>
                <th scope=""row"">1</th>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td>Empty for now</td>
                <td>E");
                WriteLiteral("mpty for now</td>\n                <td><p>hello</p><p>hello</p><p>Empty for now</p></td>\n            </tr>\n        </tbody>\n    </table>\n    <section>\n");
                WriteLiteral("\n\n\n\n    </section>\n");
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
            WriteLiteral("\n\n</html> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
