using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vs.Core.Candidates;
using Vs.Data.Repository;

namespace Vs.Services.CandidatesServices
{
    public class CandidatesService : ICandidatesService
    {
        private readonly IRepository<Candidates> _candidatesRepo;

        public CandidatesService(IRepository<Candidates> CandidatesRepo)
        {

            _candidatesRepo = CandidatesRepo;
        }


        public List<Candidatesvm> GetAllCandidates()
        {
            var Candidates = from candidate in _candidatesRepo.List().ToList()
                             select new Candidatesvm
                             {
                                 Id = candidate.Id,
                                 Name = candidate.Name
                             };

            return Candidates.ToList();
        }


        public Candidates GetCandidateById(long Id)
        {
            var Candidate = _candidatesRepo.GetById(Id);

            return Candidate;
        }


    }

    public class Candidatesvm
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
