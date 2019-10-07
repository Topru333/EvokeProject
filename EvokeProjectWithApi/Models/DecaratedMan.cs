using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace EvokeProjectWithApi.Models {
    public class DecaratedMan {

        private readonly Man _man;

        public string Name {
            get {
                return _man.Name;
            }
        }

        public int Age {
            get {
                return _man.Age;
            }
        }

        public string Email {
            get {
                return _man.Email;
            }
        }

        public string Phone {
            get {
                StringBuilder sb = new StringBuilder("", 16);
                sb.Append("+375-")
                    .Append(_man.Phone.Substring(0, 2)).Append("-")
                    .Append(_man.Phone.Substring(2, 3)).Append("-")
                    .Append(_man.Phone.Substring(5, 2)).Append("-")
                    .Append(_man.Phone.Substring(7, 2));
                return sb.ToString();
            } 
        }

        public DecaratedMan (Man man) {
            _man = man;
        }
    }
}