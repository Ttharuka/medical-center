#pragma checksum "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4145ce42bde27f91bdb0eecb13caf0c1d0103cbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PatientAppointments_Details), @"mvc.1.0.view", @"/Views/PatientAppointments/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PatientAppointments/Details.cshtml", typeof(AspNetCore.Views_PatientAppointments_Details))]
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
#line 1 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\_ViewImports.cshtml"
using Medcs;

#line default
#line hidden
#line 2 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\_ViewImports.cshtml"
using Medcs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4145ce42bde27f91bdb0eecb13caf0c1d0103cbe", @"/Views/PatientAppointments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b200875e7a18b1897e6d668dd56ba0d45ae80d20", @"/Views/_ViewImports.cshtml")]
    public class Views_PatientAppointments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Medcs.Models.Appointments>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Appointments</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(206, 47, false);
#line 14 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointedAt));

#line default
#line hidden
            EndContext();
            BeginContext(253, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(297, 43, false);
#line 17 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointedAt));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(384, 45, false);
#line 20 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsPresent));

#line default
#line hidden
            EndContext();
            BeginContext(429, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(473, 41, false);
#line 23 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsPresent));

#line default
#line hidden
            EndContext();
            BeginContext(514, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(558, 45, false);
#line 26 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(603, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(647, 41, false);
#line 29 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(688, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(732, 42, false);
#line 32 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Clinic));

#line default
#line hidden
            EndContext();
            BeginContext(774, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(818, 46, false);
#line 35 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Clinic.Address));

#line default
#line hidden
            EndContext();
            BeginContext(864, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(908, 55, false);
#line 38 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(963, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1007, 57, false);
#line 41 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedByNavigation.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1108, 42, false);
#line 44 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Doctor));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1194, 44, false);
#line 47 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Doctor.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1282, 43, false);
#line 50 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Patient));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1369, 47, false);
#line 53 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Patient.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1460, 43, false);
#line 56 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Session));

#line default
#line hidden
            EndContext();
            BeginContext(1503, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1547, 42, false);
#line 59 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Session.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1636, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "392c488024a0432a9ffee8545c21b204", async() => {
                BeginContext(1682, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\PatientAppointments\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1690, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1698, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4621d854d73142d5a3942150949cfb82", async() => {
                BeginContext(1720, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1736, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Medcs.Models.Appointments> Html { get; private set; }
    }
}
#pragma warning restore 1591