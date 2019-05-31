using System.Collections.Generic;
using Vs.Core.Candidates;

namespace Vs.Services.CandidatesServices
{
    public interface ICandidatesService
    {
        List<Candidatesvm> GetAllCandidates();
        Candidates GetCandidateById(long Id);
    }
}