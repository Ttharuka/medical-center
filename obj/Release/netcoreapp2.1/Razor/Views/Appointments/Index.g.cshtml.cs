#pragma checksum "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c6484e538d4f9d39ddf94debb46dba210c4a75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments_Index), @"mvc.1.0.view", @"/Views/Appointments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Appointments/Index.cshtml", typeof(AspNetCore.Views_Appointments_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c6484e538d4f9d39ddf94debb46dba210c4a75", @"/Views/Appointments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b200875e7a18b1897e6d668dd56ba0d45ae80d20", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medcs.Models.Appointments>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 27, true);
            WriteLiteral("\r\n<h2>Appointments</h2>\r\n\r\n");
            EndContext();
            BeginContext(175, 13, true);
            WriteLiteral("\r\n<p>\r\n\r\n    ");
            EndContext();
            BeginContext(189, 106, false);
#line 15 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
Write(Html.ActionLink("+Add New Appointment", "Create", "Appointments", null, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(295, 139, true);
            WriteLiteral("\r\n\r\n</p>\r\n<table id=\"appointments\" class=\"table table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(435, 47, false);
#line 22 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AppointedAt));

#line default
#line hidden
            EndContext();
            BeginContext(482, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(538, 45, false);
#line 25 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsPresent));

#line default
#line hidden
            EndContext();
            BeginContext(583, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(639, 45, false);
#line 28 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(684, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(740, 42, false);
#line 31 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Clinic));

#line default
#line hidden
            EndContext();
            BeginContext(782, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(838, 55, false);
#line 34 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedByNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(893, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(949, 52, false);
#line 37 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Doctor.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1057, 53, false);
#line 40 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Patient.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1166, 43, false);
#line 43 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Session));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 49 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1344, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1405, 46, false);
#line 53 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AppointedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(1569, 54, true);
            WriteLiteral("                    <a class=\"btn btn-outline-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1623, "\"", 1660, 2);
            WriteAttributeValue("", 1630, "/appointments/Present/", 1630, 22, true);
#line 57 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
WriteAttributeValue("", 1652, item.Id, 1652, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1661, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(1690, 49, false);
#line 58 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
                    Write(item.IsPresent == 1 ? "Yes" : "No, Mark Present?");

#line default
#line hidden
            EndContext();
            BeginContext(1740, 93, true);
            WriteLiteral("\r\n                    </a>\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1834, 44, false);
#line 62 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1946, 46, false);
#line 65 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Clinic.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2060, 60, false);
#line 68 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedByNavigation.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2120, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2188, 51, false);
#line 71 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Doctor.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2239, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2307, 52, false);
#line 74 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Patient.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2359, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2427, 45, false);
#line 77 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Session.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2541, "\"", 2578, 2);
            WriteAttributeValue("", 2548, "/Payments/Redirect?id=", 2548, 22, true);
#line 80 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
WriteAttributeValue("", 2570, item.Id, 2570, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2579, 34, true);
            WriteLiteral(">Pay</a> |\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2613, "\"", 2656, 2);
            WriteAttributeValue("", 2620, "/Prescriptions/Appointments/", 2620, 28, true);
#line 81 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
WriteAttributeValue("", 2648, item.Id, 2648, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2657, 42, true);
            WriteLiteral(">Prescriptions</a> |\r\n                    ");
            EndContext();
            BeginContext(2699, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ffca3b3c0234c9d9190d6437dcd9a19", async() => {
                BeginContext(2744, 4, true);
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
#line 82 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
                                           WriteLiteral(item.Id);

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
            BeginContext(2752, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2776, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e892760c58be4a2b815d362a6dba11eb", async() => {
                BeginContext(2824, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
                                              WriteLiteral(item.Id);

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
            BeginContext(2835, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2859, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2930e3fc88448d99cf654e1ee3d5311", async() => {
                BeginContext(2906, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
                                             WriteLiteral(item.Id);

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
            BeginContext(2916, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 87 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Appointments\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2971, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medcs.Models.Appointments>> Html { get; private set; }
    }
}
#pragma warning restore 1591