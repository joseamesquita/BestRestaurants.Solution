#pragma checksum "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7287d3f0757491c20eee6416f0acde9b75f5df26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Create), @"mvc.1.0.view", @"/Views/Cuisines/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Create.cshtml", typeof(AspNetCore.Views_Cuisines_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7287d3f0757491c20eee6416f0acde9b75f5df26", @"/Views/Cuisines/Create.cshtml")]
    public class Views_Cuisines_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(71, 30, true);
            WriteLiteral("\r\n<h4>Add a new cuisine</h4>\r\n");
            EndContext();
#line 8 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(136, 34, false);
#line 10 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(177, 36, false);
#line 11 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(215, 53, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new cuisine\" />\r\n");
            EndContext();
#line 13 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Create.cshtml"
}

#line default
#line hidden
            BeginContext(271, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(275, 45, false);
#line 14 "C:\Users\viole\Desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Create.cshtml"
Write(Html.ActionLink("Show all cuisines", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(320, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurants.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591
