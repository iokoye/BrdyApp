#pragma checksum "C:\Users\iokoy\source\repos\FinalProject\BrdyWebApp\Brdy\Views\WishList\AllWishList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bea997a7816c1498202e0f9edb84e3a29a602fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WishList_AllWishList), @"mvc.1.0.view", @"/Views/WishList/AllWishList.cshtml")]
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
#line 1 "C:\Users\iokoy\source\repos\FinalProject\BrdyWebApp\Brdy\Views\_ViewImports.cshtml"
using Brdy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iokoy\source\repos\FinalProject\BrdyWebApp\Brdy\Views\_ViewImports.cshtml"
using Brdy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bea997a7816c1498202e0f9edb84e3a29a602fe", @"/Views/WishList/AllWishList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c0cda8828b877343c1fbe85c2e673eedea4726", @"/Views/_ViewImports.cshtml")]
    public class Views_WishList_AllWishList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Brdy.Data.Models.WishList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\iokoy\source\repos\FinalProject\BrdyWebApp\Brdy\Views\WishList\AllWishList.cshtml"
  
    ViewData["Title"] = "AllWishList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .table {
        color: white;
        background-color: black;
        opacity: 0.7;
    }
    .h1 {
        display: flex;
        justify-content: center;
        text-align: center;
    }
</style>

<h1 class=""h1"">All Users Wish List</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 25 "C:\Users\iokoy\source\repos\FinalProject\BrdyWebApp\Brdy\Views\WishList\AllWishList.cshtml"
           Write(Html.DisplayNameFor(model => model.CommonName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\iokoy\source\repos\FinalProject\BrdyWebApp\Brdy\Views\WishList\AllWishList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\iokoy\source\repos\FinalProject\BrdyWebApp\Brdy\Views\WishList\AllWishList.cshtml"
           Write(Html.DisplayFor(modelItem => item.CommonName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\iokoy\source\repos\FinalProject\BrdyWebApp\Brdy\Views\WishList\AllWishList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Brdy.Data.Models.WishList>> Html { get; private set; }
    }
}
#pragma warning restore 1591