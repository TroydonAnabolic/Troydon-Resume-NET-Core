#pragma checksum "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Home\Comment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "539f865e23f9eda6f1f09935a1fcd95c0375ebe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Comment), @"mvc.1.0.view", @"/Views/Home/Comment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Comment.cshtml", typeof(AspNetCore.Views_Home_Comment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539f865e23f9eda6f1f09935a1fcd95c0375ebe6", @"/Views/Home/Comment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946cdbb139c51e010b78db6ba8936cfdb889d772", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Comment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Troydon_Resume_Online_NET_Core_.Models.Comment>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Home\Comment.cshtml"
  
    Layout = "_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(97, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "539f865e23f9eda6f1f09935a1fcd95c0375ebe63616", async() => {
                BeginContext(103, 47, true);
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n\r\n        <h1>");
                EndContext();
                BeginContext(151, 11, false);
#line 9 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Home\Comment.cshtml"
       Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(162, 41, true);
                WriteLiteral("</h1>\r\n        \r\n        <p>Posted <span>");
                EndContext();
                BeginContext(204, 15, false);
#line 11 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Home\Comment.cshtml"
                   Write(Model.Commented);

#line default
#line hidden
                EndContext();
                BeginContext(219, 22, true);
                WriteLiteral("</span> by </p> <span>");
                EndContext();
                BeginContext(242, 12, false);
#line 11 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Home\Comment.cshtml"
                                                         Write(Model.Person);

#line default
#line hidden
                EndContext();
                BeginContext(254, 22, true);
                WriteLiteral("</span>\r\n\r\n        <p>");
                EndContext();
                BeginContext(277, 10, false);
#line 13 "C:\Users\troyi\Documents\Troydon\IT_Projects\Troydon-Resume-NET-Core\Troydon-Resume-Online(NET Core)\Views\Home\Comment.cshtml"
      Write(Model.Body);

#line default
#line hidden
                EndContext();
                BeginContext(287, 18, true);
                WriteLiteral("</p>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
