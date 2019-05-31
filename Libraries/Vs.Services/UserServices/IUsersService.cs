namespace Vs.Services.UserServices
{
    public interface IUsersService
    {
        string GetFirstLastNames(string id);
        string GetFirstName(string id);
        string GetLastName(string id);
        bool HasUserAgreedToTermsAndConditions();
        bool HasUserVotedForCandidate();
        bool IsUserRegisteredForElection();
    }
}