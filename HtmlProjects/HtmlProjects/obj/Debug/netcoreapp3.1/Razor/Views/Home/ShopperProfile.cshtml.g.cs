#pragma checksum "/Users/cristalzavala/Desktop/HTML Progress /HtmlProjects/HtmlProjects/Views/Home/ShopperProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daed2d22556fc881cd87e9cda9f91fb263861efd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShopperProfile), @"mvc.1.0.view", @"/Views/Home/ShopperProfile.cshtml")]
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
#line 1 "/Users/cristalzavala/Desktop/HTML Progress /HtmlProjects/HtmlProjects/Views/_ViewImports.cshtml"
using HtmlProjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cristalzavala/Desktop/HTML Progress /HtmlProjects/HtmlProjects/Views/_ViewImports.cshtml"
using HtmlProjects.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daed2d22556fc881cd87e9cda9f91fb263861efd", @"/Views/Home/ShopperProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2828925b83ac68c1ba9f82c0c1bfdab0f35787e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShopperProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daed2d22556fc881cd87e9cda9f91fb263861efd3216", async() => {
                WriteLiteral("\n    <table>\n        <tbody>\n            <tr>\n                <td>\n                    <label");
                BeginWriteAttribute("for", " for=\"", 99, "\"", 105, 0);
                EndWriteAttribute();
                WriteLiteral(">First Name:</label>\n                </td>\n                <td>\n                    <input type=\"text\" id=\"FirstName\" />\n                </td>\n                <td>\n                    <label");
                BeginWriteAttribute("for", " for=\"", 296, "\"", 302, 0);
                EndWriteAttribute();
                WriteLiteral(@">Last Name:</label>
                </td>
                <td>
                    <input type=""text"" id=""LastName"" />
                </td>
            </tr>
            <tr>
                <td>
                    <lable>Gender:</lable>

                </td>
                <td colspan=""3"">
                    <input type=""radio"" id=""MaleGender"" name=""gender"" />
                    <lable for=""MaleGender"">Male</lable>

                    <input type=""radio"" id=""femaleGender"" name=""gender"" />
                    <lable for=""femalGender"">female</lable>

                    <input type=""radio"" id=""NoResponseGender"" name=""gender"" />
                    <lable for=""NoResponseGender"">Prefer not to respond</lable>

                </td>
            </tr>
            <tr>
                <td colspan=""3"">
                    <lable for=""Favorite Color"">Choose favorite color</lable>
                    <input type=""color"" id=""favoritecolor"" />
                </td>
               
            </tr>
            <tr");
                WriteLiteral(@">
                <td>
                    <lable for=""Birthday"">Birthday</lable>
                        
                  </td>
                <td>
                   <input type=""date"" id=""Birthdya"" min=""1970-05-01""
                          max=""2025-11-07""/>
                </td>
                <td colspan=""2"">
                    <label for=""Email"">Email:</label>
                    <input type=""email"" id=""Email""/>

                </td>
                <tr>

                    <td>
                        <label for=""ProfilePicture"">Select profile pictures:</label>


                    </td>
                    <td colspan=""3"">
                        <input type=""file"" id=""ProfilePicture"" multiple />
                        <input type=""number"" />
                    </td>
                  </tr>
            <tr>
                <td colspan=""4"">
                    <lable for=""Language"">Language Proficiency</label>
                    <input type=""range""id=""language"" />
                    <input");
                WriteLiteral(@" type=""time""/>
                         
                    </lable>
                </td>
            </tr>
            <tr>
                <td colspan=""4"">
                    <input type=""submit""/>
                   
                </td>
            </tr>
        </tbody>
    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
