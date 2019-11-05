#pragma checksum "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afd885f5292854fd3ffba83de795a3fbfa16bc1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Create), @"mvc.1.0.view", @"/Views/Movie/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Create.cshtml", typeof(AspNetCore.Views_Movie_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afd885f5292854fd3ffba83de795a3fbfa16bc1c", @"/Views/Movie/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a329b5791ac3f8340fc8932def0bb878d0551629", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCpresent.Models.MovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            DefineSection("Styles", async() => {
                BeginContext(93, 149, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/css/bootstrap-datetimepicker.min.css\" />\r\n");
                EndContext();
            }
            );
            BeginContext(245, 19, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n");
            EndContext();
#line 11 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
 using (Html.BeginForm("create", "movie", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
            BeginContext(369, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(408, 51, false);
#line 14 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
   Write(Html.LabelFor(model => model.title, "ชื่อภาพยนตร์"));

#line default
#line hidden
            EndContext();
            BeginContext(459, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(470, 104, false);
#line 15 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
   Write(Html.TextBoxFor(model => model.title, new { @class = "form-control", placeholder = "กรอกชื่อภาพยนตร์" }));

#line default
#line hidden
            EndContext();
            BeginContext(574, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(585, 83, false);
#line 16 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.title, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(668, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(721, 57, false);
#line 19 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
   Write(Html.LabelFor(model => model.releaseDate, "เข้าฉายเมื่อ"));

#line default
#line hidden
            EndContext();
            BeginContext(778, 73, true);
            WriteLiteral("\r\n        <div class=\'input-group date\' id=\'dtReleaseDate\'>\r\n            ");
            EndContext();
            BeginContext(852, 109, false);
#line 21 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
       Write(Html.TextBoxFor(model => model.releaseDate, new { @class = "form-control", placeholder = "กรอกเวลาเข้าฉาย" }));

#line default
#line hidden
            EndContext();
            BeginContext(961, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(976, 89, false);
#line 22 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.releaseDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 203, true);
            WriteLiteral("\r\n            <span class=\"input-group-addon\">\r\n                <span class=\"glyphicon glyphicon-calendar\"></span>\r\n            </span>\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1269, 47, false);
#line 29 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
   Write(Html.LabelFor(model => model.genre, "หมวดหมู่"));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1327, 252, false);
#line 30 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
   Write(Html.DropDownListFor(m => m.genre, new List<SelectListItem>
        {
        new SelectListItem { Text="Action", Value="Action" },
        new SelectListItem { Text="Drama", Value="Drama" }
        }, "กรุณาเลือก", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1590, 83, false);
#line 35 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.genre, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1673, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1726, 55, false);
#line 38 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
   Write(Html.LabelFor(model => model.duration, "ความยาว(นาที)"));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1792, 125, false);
#line 39 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
   Write(Html.TextBoxFor(model => model.duration, new { @class = "form-control", placeholder = "กรอกความยาว(นาที)", type = "number" }));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 51, true);
            WriteLiteral("\r\n        <lable class=\"text-danger\">\r\n            ");
            EndContext();
            BeginContext(1969, 37, false);
#line 41 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
       Write(Html.ValidationMessage("errDuration"));

#line default
#line hidden
            EndContext();
            BeginContext(2006, 70, true);
            WriteLiteral("\r\n        </lable>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(2077, 36, false);
#line 45 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
   Write(Html.Label("fileCoverImg", "รูปภาพ"));

#line default
#line hidden
            EndContext();
            BeginContext(2113, 137, true);
            WriteLiteral("\r\n        <input type=\"file\" id=\"fileUpload\" name=\"fileUpload\" class=\"form-control\" />\r\n        <lable class=\"text-danger\">\r\n            ");
            EndContext();
            BeginContext(2251, 39, false);
#line 48 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
       Write(Html.ValidationMessage("errFileUpload"));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 180, true);
            WriteLiteral("\r\n        </lable>\r\n    </div>\r\n    <div class=form-group>\r\n        <input onclick=\"return validateOnSubmit()\" type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n    </div>\r\n");
            EndContext();
#line 54 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Create.cshtml"
}

#line default
#line hidden
            BeginContext(2473, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2494, 1080, true);
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
            if (!$('#fileUpload').val()) {
                $('span[data-valmsg-for=""errFileUpload""]').text('The file upload is required.');
            }
            if (!$('#duration').val()) {
                $('span[data-valmsg-for=""errDuration""]').text('The duration is required.');
            }
        }
    </script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.16.0/jquery.validate.min.js""></script>   
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusi");
                WriteLiteral("ve/3.2.6/jquery.validate.unobtrusive.min.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCpresent.Models.MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
