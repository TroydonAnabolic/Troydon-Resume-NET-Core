#pragma checksum "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Feedback\Comment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdb13e743f675fc4f3085f96ed4458425d3c67cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_Comment), @"mvc.1.0.view", @"/Views/Feedback/Comment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedback/Comment.cshtml", typeof(AspNetCore.Views_Feedback_Comment))]
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
#line 1 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\_ViewImports.cshtml"
using Troydon_Resume_Online_NET_Core_;

#line default
#line hidden
#line 2 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\_ViewImports.cshtml"
using Troydon_Resume_Online_NET_Core_.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdb13e743f675fc4f3085f96ed4458425d3c67cf", @"/Views/Feedback/Comment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8300d73af55943cc9e3e81a975bcc948b74924af", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_Comment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Troydon_Resume_Online_NET_Core_.Models.Comment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 12, true);
            WriteLiteral("\r\n\r\n    <h1>");
            EndContext();
            BeginContext(68, 11, false);
#line 4 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Feedback\Comment.cshtml"
   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(79, 60, true);
            WriteLiteral("</h1>\r\n    <div class=\"content-wrap\">\r\n        Posted <span>");
            EndContext();
            BeginContext(140, 15, false);
#line 6 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Feedback\Comment.cshtml"
                Write(Model.Commented);

#line default
#line hidden
            EndContext();
            BeginContext(155, 17, true);
            WriteLiteral("</span> by <span>");
            EndContext();
            BeginContext(173, 12, false);
#line 6 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Feedback\Comment.cshtml"
                                                 Write(Model.Person);

#line default
#line hidden
            EndContext();
            BeginContext(185, 55, true);
            WriteLiteral("</span>\r\n    </div>\r\n\r\n<div class=\"content-wrap\">\r\n    ");
            EndContext();
            BeginContext(241, 10, false);
#line 10 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Feedback\Comment.cshtml"
Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(251, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Troydon_Resume_Online_NET_Core_.Models.Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591