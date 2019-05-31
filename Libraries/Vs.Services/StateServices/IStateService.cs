using System.Collections.Generic;
using System.Threading.Tasks;
using Vs.Core.ElectionState;

namespace Vs.Services.StateServices
{
    public interface IStateService
    {
        bool DecryptAndDisplayAllVotesToPlainText();
        List<BBCountingPhase> GetAllEncryptedVotes();
        List<ElectionStage> GetAllStates();
        List<BBRegistrationPhase> GetAllUsersWhoHaveRegisteredForElection();
        List<BBVotingPhase> GetAllUsersWhoHaveValidVotes();
        ElectionStates GetCurrentState();
        long GetCurrentStateId();
        ElectionStates GetStateById(long Id);
        bool GoToNextState();
        Task<bool> RegisterUserForVotingAsync();
        Task ResetStateAsync();
        bool ResolveRegistrationPhaseHasBegan();
        bool ResolveRegistrationPhaseHasEnded();
        bool ResolveVotingPhaseHasBegan();
        bool ResolveVotingPhaseHasEnded();
        string StateResolverById(int Id);
        Task<bool> VoteForCandidateAsync(long CandidateId);

        List<BBCountingPhase> GetAllDecryptedVotes();
    }
}