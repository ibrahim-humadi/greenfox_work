#pragma checksum "C:\Users\tiglath\projects\c_sharp\asp_dot_net\fox_club\Views\Home\Information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d1902b07e92012c725b5b74dd175b74a5fdd299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Information), @"mvc.1.0.view", @"/Views/Home/Information.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Information.cshtml", typeof(AspNetCore.Views_Home_Information))]
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
#line 1 "C:\Users\tiglath\projects\c_sharp\asp_dot_net\fox_club\Views\Home\Information.cshtml"
using fox_club.Services;

#line default
#line hidden
#line 2 "C:\Users\tiglath\projects\c_sharp\asp_dot_net\fox_club\Views\Home\Information.cshtml"
using fox_club.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d1902b07e92012c725b5b74dd175b74a5fdd299", @"/Views/Home/Information.cshtml")]
    public class Views_Home_Information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Foxes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\tiglath\projects\c_sharp\asp_dot_net\fox_club\Views\Home\Information.cshtml"
  
    ViewData["Title"] = "Information";

#line default
#line hidden
            BeginContext(114, 39, true);
            WriteLiteral("\r\n<h1>Information</h1>\r\n\r\n\r\n\r\n<table>\r\n");
            EndContext();
#line 14 "C:\Users\tiglath\projects\c_sharp\asp_dot_net\fox_club\Views\Home\Information.cshtml"
     foreach (var item in Model.foxes)
    {

#line default
#line hidden
            BeginContext(200, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(237, 9, false);
#line 18 "C:\Users\tiglath\projects\c_sharp\asp_dot_net\fox_club\Views\Home\Information.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(246, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(290, 9, false);
#line 21 "C:\Users\tiglath\projects\c_sharp\asp_dot_net\fox_club\Views\Home\Information.cshtml"
       Write(item.Food);

#line default
#line hidden
            EndContext();
            BeginContext(299, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(343, 10, false);
#line 24 "C:\Users\tiglath\projects\c_sharp\asp_dot_net\fox_club\Views\Home\Information.cshtml"
       Write(item.Drink);

#line default
#line hidden
            EndContext();
            BeginContext(353, 48, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 401, "\"", 428, 2);
            WriteAttributeValue("", 410, "/Tricks/", 410, 8, true);
#line 27 "C:\Users\tiglath\projects\c_sharp\asp_dot_net\fox_club\Views\Home\Information.cshtml"
WriteAttributeValue("", 418, item.Name, 418, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(429, 115, true);
            WriteLiteral(" method=\"POST\">\r\n                <button type=\"submit\">GO</button>\r\n            </form>\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 32 "C:\Users\tiglath\projects\c_sharp\asp_dot_net\fox_club\Views\Home\Information.cshtml"
    }

#line default
#line hidden
            BeginContext(551, 20, true);
            WriteLiteral("    </table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Foxes> Html { get; private set; }
    }
}
#pragma warning restore 1591
