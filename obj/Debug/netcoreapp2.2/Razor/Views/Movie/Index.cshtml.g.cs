#pragma checksum "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f05296466f3d79142933a2c3fe44c6717c2d3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Index.cshtml", typeof(AspNetCore.Views_Movie_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f05296466f3d79142933a2c3fe44c6717c2d3e", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a329b5791ac3f8340fc8932def0bb878d0551629", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCpresent.Models.MovieModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Movie index";

#line default
#line hidden
            BeginContext(97, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(102, 17, false);
#line 5 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(119, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
            BeginContext(127, 120, false);
#line 6 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
Write(Html.ActionLink("+ เพิ่ม", "Create", "Movie", null, new { @class = "btn btn-primary", @style = "margin-bottom: 20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(247, 270, true);
            WriteLiteral(@"
<br>
<table class=""table"">
    <tr>
        <th>รหัสภาพยนต์</th>
        <th>ชื่อภาพยนต์</th>
        <th>รูป</th>
        <th>เข้าฉายเมื่อ</th>
        <th>หมวดหมู่</th>
        <th>ความยาว (นาที)</th>
        <th>แก้ไข</th>
        <th>ลบ</th>
    </tr>
");
            EndContext();
#line 19 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(558, 46, true);
            WriteLiteral("        <tr>\r\n            <td class=\"item-id\">");
            EndContext();
            BeginContext(605, 7, false);
#line 22 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
                           Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(612, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(636, 10, false);
#line 23 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
           Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(646, 45, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 691, "\"", 711, 1);
#line 25 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
WriteAttributeValue("", 697, item.coverImg, 697, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(712, 54, true);
            WriteLiteral(" height=\"80px\" />\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(767, 46, false);
#line 27 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
           Write(item.releaseDate.Value.ToString("dd MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(813, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(837, 10, false);
#line 28 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
           Write(item.genre);

#line default
#line hidden
            EndContext();
            BeginContext(847, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(871, 13, false);
#line 29 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
           Write(item.duration);

#line default
#line hidden
            EndContext();
            BeginContext(884, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(926, 136, false);
#line 31 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.id }, new { id = item.id, @class = "btn btn-primary", @style = "margin-bottom: 20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 152, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <input type=\"button\" value=\"Delete\" class=\"btn btn-danger\" />\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 37 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1221, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
#line 39 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
 using (Html.BeginForm("delete", "movie", FormMethod.Post, new { name = "frmMovie", id = "frmMovie" }))
{

#line default
#line hidden
            BeginContext(1339, 39, true);
            WriteLiteral("    <input type=\"hidden\" name=\"id\" />\r\n");
            EndContext();
#line 42 "C:\Users\NB-PC\Desktop\Myproject\MVCpresent\Views\Movie\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1381, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1402, 382, true);
                WriteLiteral(@"
    <script>
        $("".btn-danger"").click(function () {
            if(!confirm('Do you really want to delete this movie?')) {
                return false;
            }
            var id = $(this).closest(""tr"").find("".item-id"").text();
            document.frmMovie.id.value = id;
            document.getElementById(""frmMovie"").submit();
        });
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCpresent.Models.MovieModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
