#pragma checksum "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9fdf6d5d21a55cdd8eae59ebe65f73c94ae8a6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payments_Index), @"mvc.1.0.view", @"/Views/Payments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Payments/Index.cshtml", typeof(AspNetCore.Views_Payments_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9fdf6d5d21a55cdd8eae59ebe65f73c94ae8a6a", @"/Views/Payments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b200875e7a18b1897e6d668dd56ba0d45ae80d20", @"/Views/_ViewImports.cshtml")]
    public class Views_Payments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medcs.Models.Payments>>
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 34, true);
            WriteLiteral("\r\n<h2>Payments</h2>\r\n\r\n<p>\r\n\r\n    ");
            EndContext();
            BeginContext(121, 98, false);
#line 11 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
Write(Html.ActionLink("+Add New Payment", "Create", "Payments", null, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(219, 12, true);
            WriteLiteral("\r\n\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(289, 125, true);
            WriteLiteral("<table id=\"patients\" class=\"table table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(415, 47, false);
#line 22 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Appointment));

#line default
#line hidden
            EndContext();
            BeginContext(462, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(518, 42, false);
#line 25 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(560, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(616, 42, false);
#line 28 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PaidAt));

#line default
#line hidden
            EndContext();
            BeginContext(658, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(714, 46, false);
#line 31 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsReceived));

#line default
#line hidden
            EndContext();
            BeginContext(760, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(816, 42, false);
#line 34 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Method));

#line default
#line hidden
            EndContext();
            BeginContext(858, 56, true);
            WriteLiteral("\r\n            </th>\r\n             <th>\r\n                ");
            EndContext();
            BeginContext(915, 47, false);
#line 37 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(962, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1097, 50, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1147, "\"", 1197, 2);
            WriteAttributeValue("", 1154, "/Appointment/Details?id=", 1154, 24, true);
#line 47 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
WriteAttributeValue("", 1178, item.AppointmentId, 1178, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1198, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(1222, 49, false);
#line 48 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Appointment.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 24, true);
            WriteLiteral("\r\n                </a>\r\n");
            EndContext();
            BeginContext(1367, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1421, 41, false);
#line 53 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1518, 41, false);
#line 56 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaidAt));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 59 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
                 if (item.IsReceived == 1)
                {

#line default
#line hidden
            BeginContext(1661, 71, true);
            WriteLiteral("                    <label class=\"success label-success\">Paid</label>\r\n");
            EndContext();
#line 62 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1792, 74, true);
            WriteLiteral("                    <label class=\"success label-danger\">Not Paid</label>\r\n");
            EndContext();
#line 66 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1885, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1951, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2007, 41, false);
#line 70 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Method));

#line default
#line hidden
            EndContext();
            BeginContext(2048, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2106, 46, false);
#line 74 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(2279, 20, true);
            WriteLiteral("\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2299, "\"", 2336, 2);
            WriteAttributeValue("", 2306, "/Payments/Redirect?id=", 2306, 22, true);
#line 79 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
WriteAttributeValue("", 2328, item.Id, 2328, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2337, 36, true);
            WriteLiteral(" class=\"btn btn-primary\">Pay</a> |\r\n");
            EndContext();
            BeginContext(2463, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2479, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "845c8c7af3c241d1bac2ed2cf0eb872c", async() => {
                BeginContext(2524, 4, true);
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
#line 81 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
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
            BeginContext(2532, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2552, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e0cca5b0f124cbfbeb184bbd16d37bf", async() => {
                BeginContext(2600, 7, true);
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
#line 82 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
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
            BeginContext(2611, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2631, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44855c9ef5344df48decea5f86016eae", async() => {
                BeginContext(2678, 6, true);
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
#line 83 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
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
            BeginContext(2688, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 86 "F:\New folder (3)\WebApp\Medecs\Medcs\Views\Payments\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2735, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medcs.Models.Payments>> Html { get; private set; }
    }
}
#pragma warning restore 1591
