#pragma checksum "E:\AspNet2020\WebApplicationVente\WebApplicationVente\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "019e2630993691299941808a048c2d085a5cb0de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "E:\AspNet2020\WebApplicationVente\WebApplicationVente\Views\_ViewImports.cshtml"
using WebApplicationVente.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AspNet2020\WebApplicationVente\WebApplicationVente\Views\_ViewImports.cshtml"
using WebApplicationVente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"019e2630993691299941808a048c2d085a5cb0de", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eed14134e576600b0845ad012d523bde388449f", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<h1>Your Shopping Cart</h1>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Select Amount</th>
            <th>Produit</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">SubTotal</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "E:\AspNet2020\WebApplicationVente\WebApplicationVente\Views\ShoppingCart\Index.cshtml"
        foreach(var item in Model.ShoppingCart.shoppingCartItems)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "E:\AspNet2020\WebApplicationVente\WebApplicationVente\Views\ShoppingCart\Index.cshtml"
           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "E:\AspNet2020\WebApplicationVente\WebApplicationVente\Views\ShoppingCart\Index.cshtml"
           Write(item.Prouit.NomProduit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "E:\AspNet2020\WebApplicationVente\WebApplicationVente\Views\ShoppingCart\Index.cshtml"
           Write(item.Prouit.PrixVenteTTC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "E:\AspNet2020\WebApplicationVente\WebApplicationVente\Views\ShoppingCart\Index.cshtml"
            Write((item.Amount* item.Prouit.PrixVenteTTC).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "E:\AspNet2020\WebApplicationVente\WebApplicationVente\Views\ShoppingCart\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
