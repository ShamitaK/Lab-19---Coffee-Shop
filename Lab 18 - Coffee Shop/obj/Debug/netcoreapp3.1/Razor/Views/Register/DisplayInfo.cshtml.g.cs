#pragma checksum "C:\Users\shami\source\repos\Lab 18 - Coffee Shop\Lab 18 - Coffee Shop\Views\Register\DisplayInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7612478435590e528b81ed78df3e11a0fdad98de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_DisplayInfo), @"mvc.1.0.view", @"/Views/Register/DisplayInfo.cshtml")]
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
#line 1 "C:\Users\shami\source\repos\Lab 18 - Coffee Shop\Lab 18 - Coffee Shop\Views\_ViewImports.cshtml"
using Lab_18___Coffee_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shami\source\repos\Lab 18 - Coffee Shop\Lab 18 - Coffee Shop\Views\_ViewImports.cshtml"
using Lab_18___Coffee_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7612478435590e528b81ed78df3e11a0fdad98de", @"/Views/Register/DisplayInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad9d3f19a84ecdf7326b4b53a65aa1a88365da7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_DisplayInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\shami\source\repos\Lab 18 - Coffee Shop\Lab 18 - Coffee Shop\Views\Register\DisplayInfo.cshtml"
  
    ViewData["Title"] = "DisplayInfo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<h1>DisplayInfo</h1>

<table class=""table-responsive-sm, table"">
    <tr>
        <th>Username</th>
        <th>Email</th>
        <th>Password</th>
        <th>Gender</th>
        <th>Age</th>
        <th>Phone Number</th>
    </tr>
    </table>

    <table>
        <tr>
            
            <th>");
#nullable restore
#line 23 "C:\Users\shami\source\repos\Lab 18 - Coffee Shop\Lab 18 - Coffee Shop\Views\Register\DisplayInfo.cshtml"
           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 24 "C:\Users\shami\source\repos\Lab 18 - Coffee Shop\Lab 18 - Coffee Shop\Views\Register\DisplayInfo.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 25 "C:\Users\shami\source\repos\Lab 18 - Coffee Shop\Lab 18 - Coffee Shop\Views\Register\DisplayInfo.cshtml"
           Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 26 "C:\Users\shami\source\repos\Lab 18 - Coffee Shop\Lab 18 - Coffee Shop\Views\Register\DisplayInfo.cshtml"
           Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 27 "C:\Users\shami\source\repos\Lab 18 - Coffee Shop\Lab 18 - Coffee Shop\Views\Register\DisplayInfo.cshtml"
           Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 28 "C:\Users\shami\source\repos\Lab 18 - Coffee Shop\Lab 18 - Coffee Shop\Views\Register\DisplayInfo.cshtml"
           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n        </tr>\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591