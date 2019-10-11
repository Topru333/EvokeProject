using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvokeProjectWithApi.Models {
    public class Candidate {

        public int ID {
            get; set;
        }
        public string Name {
            get; set;
        }
        public string Email {
            get; set;
        }
        public int Age {
            get; set;
        }
        public int Phone {
            get; set;
        }
    }
}