#pragma checksum "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\Account\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cf7032789f3252e58dbc82fc1c6451a8b0e87f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Logout), @"mvc.1.0.view", @"/Views/Account/Logout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Logout.cshtml", typeof(AspNetCore.Views_Account_Logout))]
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
#line 1 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\_ViewImports.cshtml"
using VotingSystemWeb;

#line default
#line hidden
#line 2 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\_ViewImports.cshtml"
using VotingSystemWeb.Models;

#line default
#line hidden
#line 5 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\_ViewImports.cshtml"
using Vs.Services.UserServices;

#line default
#line hidden
#line 8 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\_ViewImports.cshtml"
using Vs.Services.SharedServices;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf7032789f3252e58dbc82fc1c6451a8b0e87f1", @"/Views/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0c1c4a6fb412e6dad1c3ff8336d85caa79bf92", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Logout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\Account\Logout.cshtml"
  
    ViewData["Title"] = "Logout";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(91, 21, true);
            WriteLiteral("\r\n<h1>Logout</h1>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISharedService _sharedService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUsersService _userService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
