#pragma checksum "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3e7142cfccf4de091c58741a482afe22920ce41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Edit), @"mvc.1.0.view", @"/Views/Employee/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Edit.cshtml", typeof(AspNetCore.Views_Employee_Edit))]
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
#line 1 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\_ViewImports.cshtml"
using MVCpresent;

#line default
#line hidden
#line 2 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\_ViewImports.cshtml"
using MVCpresent.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e7142cfccf4de091c58741a482afe22920ce41", @"/Views/Employee/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a329b5791ac3f8340fc8932def0bb878d0551629", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCpresent.Models.EmployeeData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            DefineSection("Styles", async() => {
                BeginContext(97, 149, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/css/bootstrap-datetimepicker.min.css\" />\r\n");
                EndContext();
            }
            );
            BeginContext(249, 15, true);
            WriteLiteral("<h2>Edit</h2>\r\n");
            EndContext();
#line 10 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
 using (Html.BeginForm("edit", "Employee", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
            BeginContext(370, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(409, 54, false);
#line 13 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.firstname, "ชื่อพนักงาน"));

#line default
#line hidden
            EndContext();
            BeginContext(463, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(474, 108, false);
#line 14 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.TextBoxFor(model => model.firstname, new { @class = "form-control", placeholder = "กรอกชื่อภาพยนตร์" }));

#line default
#line hidden
            EndContext();
            BeginContext(582, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(593, 87, false);
#line 15 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.firstname, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(680, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(733, 49, false);
#line 18 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.lastname, "นามสุกล"));

#line default
#line hidden
            EndContext();
            BeginContext(782, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(793, 109, false);
#line 19 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.TextBoxFor(model => model.lastname, new { @class = "form-control", placeholder = "กรอกนามสกุลพนักงาน" }));

#line default
#line hidden
            EndContext();
            BeginContext(902, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(913, 86, false);
#line 20 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.lastname, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(999, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1052, 64, false);
#line 23 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.releaseDate, "เกิดวันที่/เดือน/ปี"));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 73, true);
            WriteLiteral("\r\n        <div class=\'input-group date\' id=\'dtReleaseDate\'>\r\n            ");
            EndContext();
            BeginContext(1190, 113, false);
#line 25 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.releaseDate, new { @class = "form-control", placeholder = "ระบุวันที่/เดือน/ปี" }));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1318, 89, false);
#line 26 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.releaseDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 203, true);
            WriteLiteral("\r\n            <span class=\"input-group-addon\">\r\n                <span class=\"glyphicon glyphicon-calendar\"></span>\r\n            </span>\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1611, 49, false);
#line 33 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.position, "ตำแหน่ง"));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1671, 245, false);
#line 34 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.DropDownListFor(m => m.position, new List<SelectListItem>
        {
        new SelectListItem { Text="CEO", Value="CEO" },
        new SelectListItem { Text="Dev", Value="Dev" }
        }, "กรุณาเลือก", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1916, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1927, 86, false);
#line 39 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.position, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2013, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 41 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
    //change salary

#line default
#line hidden
            BeginContext(2048, 37, true);
            WriteLiteral("   <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(2086, 54, false);
#line 43 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.salary, "เลือกเงินเดือน"));

#line default
#line hidden
            EndContext();
            BeginContext(2140, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2151, 249, false);
#line 44 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.DropDownListFor(m => m.salary, new List<SelectListItem>
        {
        new SelectListItem { Text="1000K", Value="1000K" },
        new SelectListItem { Text="500K", Value="500K" }
        }, "กรุณาเลือก", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2411, 84, false);
#line 49 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.salary, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2495, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 51 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
    // input Age

#line default
#line hidden
            BeginContext(2527, 40, true);
            WriteLiteral("      <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(2568, 45, false);
#line 53 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.age, "ระบุอายุ"));

#line default
#line hidden
            EndContext();
            BeginContext(2613, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2624, 346, false);
#line 54 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.DropDownListFor(m => m.age, new List<SelectListItem>
        {
        new SelectListItem { Text="20", Value="20" },
        new SelectListItem { Text="21", Value="21" },
        new SelectListItem { Text="22", Value="22" },
        new SelectListItem { Text="23", Value="23" }
        }, "กรุณาเลือก", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2970, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2981, 81, false);
#line 61 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.age, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3062, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 63 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
    // input Address

#line default
#line hidden
            BeginContext(3098, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(3137, 57, false);
#line 65 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.LabelFor(model => model.address, "กรุณากรอกที่อยู่"));

#line default
#line hidden
            EndContext();
            BeginContext(3194, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(3205, 102, false);
#line 66 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.TextAreaFor(m => m.address, new { @class = "form-control", placeholder = "ที่อยู่สำหรับติดต่อ" }));

#line default
#line hidden
            EndContext();
            BeginContext(3307, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(3318, 85, false);
#line 67 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.address, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3403, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(3423, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(3462, 36, false);
#line 73 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
   Write(Html.Label("fileCoverImg", "รูปภาพ"));

#line default
#line hidden
            EndContext();
            BeginContext(3498, 137, true);
            WriteLiteral("\r\n        <input type=\"file\" id=\"fileUpload\" name=\"fileUpload\" class=\"form-control\" />\r\n        <lable class=\"text-danger\">\r\n            ");
            EndContext();
            BeginContext(3636, 39, false);
#line 76 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
       Write(Html.ValidationMessage("errFileUpload"));

#line default
#line hidden
            EndContext();
            BeginContext(3675, 72, true);
            WriteLiteral("\r\n        </lable>\r\n    </div>\r\n    <div class=form-group>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3747, "\"", 3781, 1);
#line 80 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
WriteAttributeValue("", 3753, Url.Content(Model.coverImg), 3753, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3782, 188, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n    </div>\r\n    <div class=form-group>\r\n        <input onclick=\"return validateOnSubmit()\" type=\"submit\" value=\"Update\" class=\"btn btn-primary\" />\r\n    </div>\r\n");
            EndContext();
#line 85 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Employee\Edit.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(3992, 920, true);
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.22.2/moment.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/js/bootstrap-datetimepicker.min.js""></script>
    <script type=""text/javascript"">
        $(function() {
            $('#dtReleaseDate').datetimepicker({
                defaultDate: new Date(),
            });
        });
        function validateOnSubmit() {
            if (!$('#duration').val()) {
                $('span[data-valmsg-for=""errDuration""]').text('The duration is required.');
            }
        }
    </script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.16.0/jquery.validate.min.js""></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js""></script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCpresent.Models.EmployeeData> Html { get; private set; }
    }
}
#pragma warning restore 1591
