#pragma checksum "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b65c4276f7dc9cba5c12fb9f7f8bbb8b21c5d10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Delete), @"mvc.1.0.view", @"/Views/Student/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Delete.cshtml", typeof(AspNetCore.Views_Student_Delete))]
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
#line 1 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\_ViewImports.cshtml"
using NgoThienDao.TrungTamNgoaiNgu;

#line default
#line hidden
#line 2 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\_ViewImports.cshtml"
using NgoThienDao.TrungTamNgoaiNgu.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b65c4276f7dc9cba5c12fb9f7f8bbb8b21c5d10", @"/Views/Student/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec987648e019748710eb818583076dab53d4ffa0", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NgoThienDao.TrungTamNgoaiNgu.Models.Request.Student.StudentDelete>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(118, 155, true);
            WriteLiteral("\r\n    <h1>Xóa sinh viên</h1>\r\n\r\n    <h3>Bạn có muốn xóa không?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(274, 38, false);
#line 14 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(312, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(376, 34, false);
#line 17 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(410, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(473, 47, false);
#line 20 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(520, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(584, 43, false);
#line 23 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(627, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(690, 39, false);
#line 26 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(729, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(793, 35, false);
#line 29 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(828, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(891, 40, false);
#line 32 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Male));

#line default
#line hidden
            EndContext();
            BeginContext(931, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(995, 36, false);
#line 35 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Male));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1094, 41, false);
#line 38 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1199, 37, false);
#line 41 "G:\LapTrinh\Module2.1\Kiểm Tra\NgoThienDao.TrungTamNgoaiNgu\NgoThienDao.TrungTamNgoaiNgu\Views\Student\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1274, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b65c4276f7dc9cba5c12fb9f7f8bbb8b21c5d109659", async() => {
                BeginContext(1300, 87, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-outline-danger\" /> \r\n        ");
                EndContext();
                BeginContext(1387, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b65c4276f7dc9cba5c12fb9f7f8bbb8b21c5d1010136", async() => {
                    BeginContext(1438, 8, true);
                    WriteLiteral("Quay Lại");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1450, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1463, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NgoThienDao.TrungTamNgoaiNgu.Models.Request.Student.StudentDelete> Html { get; private set; }
    }
}
#pragma warning restore 1591
