#pragma checksum "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6ae269b57fd7332678f01f8993d4a46eb043cbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BulletinBoard_Index), @"mvc.1.0.view", @"/Views/BulletinBoard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BulletinBoard/Index.cshtml", typeof(AspNetCore.Views_BulletinBoard_Index))]
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
#line 5 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\_ViewImports.cshtml"
using Vs.Services.UserServices;

#line default
#line hidden
#line 8 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\_ViewImports.cshtml"
using Vs.Services.SharedServices;

#line default
#line hidden
#line 1 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
using VotingSystemWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ae269b57fd7332678f01f8993d4a46eb043cbf", @"/Views/BulletinBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0c1c4a6fb412e6dad1c3ff8336d85caa79bf92", @"/Views/_ViewImports.cshtml")]
    public class Views_BulletinBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BulletinBoardVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
 if (Model == null)
{


#line default
#line hidden
            BeginContext(173, 103, true);
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\r\n        Bulletin Board data not found\r\n    </div>\r\n");
            EndContext();
#line 15 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"

}
else
{




    

#line default
#line hidden
#line 23 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
     if (Model.bBProxyPhaseList != null)
    {



#line default
#line hidden
            BeginContext(351, 44, true);
            WriteLiteral("        <h3>Proxy phase</h3>\r\n        <ul>\r\n");
            EndContext();
#line 29 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
             foreach (var proxy in Model.bBProxyPhaseList)
            {

#line default
#line hidden
            BeginContext(470, 26, true);
            WriteLiteral("                <li>proxy ");
            EndContext();
            BeginContext(497, 13, false);
#line 31 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                     Write(proxy.ProxyId);

#line default
#line hidden
            EndContext();
            BeginContext(510, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(512, 15, false);
#line 31 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                    Write(proxy.ProxyName);

#line default
#line hidden
            EndContext();
            BeginContext(527, 18, true);
            WriteLiteral(" registered</li>\r\n");
            EndContext();
#line 32 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(560, 21, true);
            WriteLiteral("\r\n\r\n\r\n        </ul>\r\n");
            EndContext();
#line 37 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
    }

#line default
#line hidden
#line 40 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
     if (Model.bBRegistrationPhaseList != null)
    {



#line default
#line hidden
            BeginContext(652, 53, true);
            WriteLiteral("        <h3>Registration phase</h3>\r\n        <ul>\r\n\r\n");
            EndContext();
#line 47 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
             foreach (var registeredUser in Model.bBRegistrationPhaseList)
            {

#line default
#line hidden
            BeginContext(796, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(817, 21, false);
#line 49 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
               Write(registeredUser.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(838, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(840, 23, false);
#line 49 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                      Write(registeredUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(863, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(865, 24, false);
#line 49 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                                               Write(registeredUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(889, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(891, 23, false);
#line 49 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                                                                         Write(registeredUser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(914, 30, true);
            WriteLiteral("  is registered to vote</li>\r\n");
            EndContext();
#line 50 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(959, 17, true);
            WriteLiteral("\r\n        </ul>\r\n");
            EndContext();
#line 53 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
    }

#line default
#line hidden
#line 56 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
     if (Model.bBVotingPhaseList != null)
    {



#line default
#line hidden
            BeginContext(1041, 45, true);
            WriteLiteral("        <h3>Voting phase</h3>\r\n        <ul>\r\n");
            EndContext();
#line 62 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
             foreach (var votes in Model.bBVotingPhaseList)
            {

#line default
#line hidden
            BeginContext(1162, 39, true);
            WriteLiteral("                <li>Vote received from ");
            EndContext();
            BeginContext(1202, 12, false);
#line 64 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                  Write(votes.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(1214, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1216, 14, false);
#line 64 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                                Write(votes.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1230, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1232, 15, false);
#line 64 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                                                Write(votes.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1247, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1249, 14, false);
#line 64 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                                                                 Write(votes.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1263, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 65 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1285, 21, true);
            WriteLiteral("\r\n\r\n\r\n        </ul>\r\n");
            EndContext();
#line 70 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
    }

#line default
#line hidden
#line 74 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
     if (Model.bBCountingPhaseList != null)
    {



#line default
#line hidden
            BeginContext(1375, 43, true);
            WriteLiteral("        <h3>Counting Encrypted phase</h3>\r\n");
            EndContext();
            BeginContext(1420, 16, true);
            WriteLiteral("        <ul>\r\n\r\n");
            EndContext();
#line 82 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
             foreach (var item in Model.bBCountingPhaseList)
            {

#line default
#line hidden
            BeginContext(1513, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(1534, 36, false);
#line 84 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
               Write(item.EncryptedUsernameVotedCandidate);

#line default
#line hidden
            EndContext();
            BeginContext(1570, 30, true);
            WriteLiteral(" encypted vote received</li>\r\n");
            EndContext();
#line 85 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1615, 23, true);
            WriteLiteral("\r\n\r\n\r\n\r\n        </ul>\r\n");
            EndContext();
#line 91 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"

    }

#line default
#line hidden
#line 95 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
     if (Model.bBCountingPhaseList2 != null)
    {



#line default
#line hidden
            BeginContext(1708, 43, true);
            WriteLiteral("        <h3>Counting Decrypted phase</h3>\r\n");
            EndContext();
            BeginContext(1753, 16, true);
            WriteLiteral("        <ul>\r\n\r\n");
            EndContext();
#line 103 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
             foreach (var item in Model.bBCountingPhaseList2)
            {

#line default
#line hidden
            BeginContext(1847, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(1868, 36, false);
#line 105 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
               Write(item.EncryptedUsernameVotedCandidate);

#line default
#line hidden
            EndContext();
            BeginContext(1904, 20, true);
            WriteLiteral(" vote counted</li>\r\n");
            EndContext();
#line 106 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1939, 23, true);
            WriteLiteral("\r\n\r\n\r\n\r\n        </ul>\r\n");
            EndContext();
#line 112 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"

    }

#line default
#line hidden
#line 115 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
     if (Model.bBCandidatesNoVotesList != null)
    {



#line default
#line hidden
            BeginContext(2033, 105, true);
            WriteLiteral("        <h3>Voting result Summary</h3>\r\n        <h4>Candidates and number of votes</h4>\r\n        <ul>\r\n\r\n");
            EndContext();
#line 123 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
             foreach (var candidate in Model.bBCandidatesNoVotesList)
            {

#line default
#line hidden
            BeginContext(2224, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(2245, 23, false);
#line 125 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
               Write(candidate.CandidateName);

#line default
#line hidden
            EndContext();
            BeginContext(2268, 7, true);
            WriteLiteral(" with: ");
            EndContext();
            BeginContext(2276, 23, false);
#line 125 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                              Write(candidate.NumberOfVotes);

#line default
#line hidden
            EndContext();
            BeginContext(2299, 13, true);
            WriteLiteral(" votes</li>\r\n");
            EndContext();
#line 126 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2327, 23, true);
            WriteLiteral("\r\n\r\n\r\n\r\n        </ul>\r\n");
            EndContext();
#line 132 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
    }

#line default
#line hidden
#line 134 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
     if (Model.bBVotingParticipantsSummary != null)
    {



#line default
#line hidden
            BeginContext(2423, 126, true);
            WriteLiteral("        <h4>Voting participants summary</h4>\r\n        <ul>\r\n            <li>Number of people who registered for the election: ");
            EndContext();
            BeginContext(2550, 58, false);
#line 140 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                                             Write(Model.bBVotingParticipantsSummary.NumberOfRegisteredVoters);

#line default
#line hidden
            EndContext();
            BeginContext(2608, 51, true);
            WriteLiteral("</li>\r\n            <li>Number of people who voted: ");
            EndContext();
            BeginContext(2660, 56, false);
#line 141 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                       Write(Model.bBVotingParticipantsSummary.NumberOfPeopleWhoVoted);

#line default
#line hidden
            EndContext();
            BeginContext(2716, 57, true);
            WriteLiteral("</li>\r\n            <li>Number of people who didn\'t vote: ");
            EndContext();
            BeginContext(2774, 59, false);
#line 142 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
                                             Write(Model.bBVotingParticipantsSummary.NumberOfPeoleWhoDidntVote);

#line default
#line hidden
            EndContext();
            BeginContext(2833, 22, true);
            WriteLiteral("</li>\r\n        </ul>\r\n");
            EndContext();
#line 144 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
    }

#line default
#line hidden
#line 144 "C:\Users\DC\source\repos\VotingSystem\Views\VotingSystemWeb\Views\BulletinBoard\Index.cshtml"
     

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BulletinBoardVm> Html { get; private set; }
    }
}
#pragma warning restore 1591