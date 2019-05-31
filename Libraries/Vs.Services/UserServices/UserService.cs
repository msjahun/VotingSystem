
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Vs.Core.Users;

namespace Vs.Services.UserServices
{
    public class UsersService : IUsersService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsersService(UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

        }


        public string GetFirstName(string id)
        {
            return _userManager.Users.Where(c => c.Id == id).FirstOrDefault().FirstName.ToString();
        }



        public string GetLastName(string id)
        {
            return _userManager.Users.Where(c => c.Id == id).FirstOrDefault().LastName.ToString();
        }

        public string GetFirstLastNames(string id)
        {
            return GetFirstName(id) + " " + GetLastName(id);
        }



        //fill out the proper logic
        public bool HasUserAgreedToTermsAndConditions()
        {
            var CurrentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var User = _userManager.Users.Where(_ => _.Id == CurrentUserId).FirstOrDefault();
            if (User != null)
            {
                return User.HasAgreedToTermsAndConditions;
            }
            return false;
        }

        public bool IsUserRegisteredForElection()
        {
            var CurrentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var User = _userManager.Users.Where(_ => _.Id == CurrentUserId).FirstOrDefault();
            if (User != null)
            {
                return User.IsRegisteredForElection;
            }
            return false;
        }


        public bool HasUserVotedForCandidate()
        {
            var CurrentUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var User = _userManager.Users.Where(_ => _.Id == CurrentUserId).FirstOrDefault();
            if (User != null)
            {
                return User.HasVotedForCandidate;
            }
            return false;
        }

    }



}
