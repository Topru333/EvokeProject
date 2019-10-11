using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EvokeProjectWithApi.Models {
    public class CandidateContext : DbContext {
        public CandidateContext () : base("DefaultConnection") {

        }

        public DbSet<Candidate> Candidate {
            get; set;
        }

    }
}