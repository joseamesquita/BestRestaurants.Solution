#pragma checksum "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d2c40f5a10a8deb5e197c754d2148af8c5c52c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Index), @"mvc.1.0.view", @"/Views/Restaurants/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Index.cshtml", typeof(AspNetCore.Views_Restaurants_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 5 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml"
using BestRestaurants.Models;

#line default
#line hidden
#line 6 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2c40f5a10a8deb5e197c754d2148af8c5c52c9", @"/Views/Restaurants/Index.cshtml")]
    public class Views_Restaurants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BestRestaurants.Models.Restaurant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(149, 202, true);
            WriteLiteral("\r\n\r\n  <div class=\"row\">\r\n    <div class=\"col-sm-9 col-md-7 col-lg-5 mx-auto\">\r\n      <div class=\"card bg-warning my-5\">\r\n        <div class=\"card-body\">\r\n          <h1>Restaurants</h1>\r\n          <hr>\r\n");
            EndContext();
#line 16 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml"
           if (@Model.Count == 0)
          {

#line default
#line hidden
            BeginContext(399, 58, true);
            WriteLiteral("            <h3>No restaurants have been added yet!</h3>\r\n");
            EndContext();
#line 19 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml"
          } 

#line default
#line hidden
            BeginContext(471, 16, true);
            WriteLiteral("          <ul>\r\n");
            EndContext();
#line 21 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml"
             foreach(Restaurant restaurant in Model)
            {

#line default
#line hidden
            BeginContext(556, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(577, 86, false);
#line 23 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml"
               Write(Html.ActionLink($"{restaurant.Name}", "Details", new { id = restaurant.RestaurantId }));

#line default
#line hidden
            EndContext();
            BeginContext(663, 8, true);
            WriteLiteral(" </li>\r\n");
            EndContext();
#line 24 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(686, 38, true);
            WriteLiteral("\r\n            <hr/>\r\n\r\n            <p>");
            EndContext();
            BeginContext(725, 47, false);
#line 28 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml"
          Write(Html.ActionLink("Add new restaurant", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(772, 23, true);
            WriteLiteral("</p>\r\n\r\n            <p>");
            EndContext();
            BeginContext(796, 40, false);
#line 30 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Restaurants\Index.cshtml"
          Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(836, 81, true);
            WriteLiteral("</p>\r\n          </ul>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BestRestaurants.Models.Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
