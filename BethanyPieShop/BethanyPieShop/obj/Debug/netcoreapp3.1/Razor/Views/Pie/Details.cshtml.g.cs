#pragma checksum "/Users/diogobasilio/Projects/ASP.NET_Core_MVC/BethanyPieShop/BethanyPieShop/Views/Pie/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4b9cab83bf45298bd2c2d750185e4dfaee4c929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_Details), @"mvc.1.0.view", @"/Views/Pie/Details.cshtml")]
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
#line 1 "/Users/diogobasilio/Projects/ASP.NET_Core_MVC/BethanyPieShop/BethanyPieShop/Views/_ViewImports.cshtml"
using BethanyPieShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/diogobasilio/Projects/ASP.NET_Core_MVC/BethanyPieShop/BethanyPieShop/Views/_ViewImports.cshtml"
using BethanyPieShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b9cab83bf45298bd2c2d750185e4dfaee4c929", @"/Views/Pie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c03a21f691ab6a66a52b1db8191d287f13dfd83", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<h2>");
#nullable restore
#line 4 "/Users/diogobasilio/Projects/ASP.NET_Core_MVC/BethanyPieShop/BethanyPieShop/Views/Pie/Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<div class=\"thumbnail\">\n    <img");
            BeginWriteAttribute("alt", " alt=\"", 67, "\"", 84, 1);
#nullable restore
#line 7 "/Users/diogobasilio/Projects/ASP.NET_Core_MVC/BethanyPieShop/BethanyPieShop/Views/Pie/Details.cshtml"
WriteAttributeValue("", 73, Model.Name, 73, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 85, "\"", 106, 1);
#nullable restore
#line 7 "/Users/diogobasilio/Projects/ASP.NET_Core_MVC/BethanyPieShop/BethanyPieShop/Views/Pie/Details.cshtml"
WriteAttributeValue("", 91, Model.ImageUrl, 91, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"caption-full\">\n        <h3 class=\"pull-right\">");
#nullable restore
#line 9 "/Users/diogobasilio/Projects/ASP.NET_Core_MVC/BethanyPieShop/BethanyPieShop/Views/Pie/Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <h3>\n            <a href=\"#\">");
#nullable restore
#line 11 "/Users/diogobasilio/Projects/ASP.NET_Core_MVC/BethanyPieShop/BethanyPieShop/Views/Pie/Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n        </h3>\n        <h4>");
#nullable restore
#line 13 "/Users/diogobasilio/Projects/ASP.NET_Core_MVC/BethanyPieShop/BethanyPieShop/Views/Pie/Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <p>");
#nullable restore
#line 14 "/Users/diogobasilio/Projects/ASP.NET_Core_MVC/BethanyPieShop/BethanyPieShop/Views/Pie/Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591