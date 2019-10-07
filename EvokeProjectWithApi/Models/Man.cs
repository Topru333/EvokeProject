using System;
using System.Text;

namespace EvokeProjectWithApi.Models {

    public class Man {

        public string Name {
            get; set;
        }

        public int Age {
            get; set;
        }

        public string Email {
            get; set;
        }

        public string Phone {
            get; set;
        }

    }

    public class ManBuilder {

        private Man _man = new Man();

        public ManBuilder SetName (string name) {
            _man.Name = name;
            return this;
        }

        public ManBuilder SetAge (int age) {
            if (age < 16) {
                throw new Exception("Age isn't correct!");
            }
            _man.Age = age;
            return this;
        }

        public ManBuilder SetEmail (string email) {
            _man.Email = email;
            return this;
        }

        public ManBuilder SetPhone (int phone) {
            string sphone = "" + phone;
            if (sphone.Length != 9) {
                throw new Exception("Phone isn't correct!");
            }
            StringBuilder sb = new StringBuilder("", 16);
            sb.Append("+375-")
                .Append(sphone.Substring(0, 2)).Append("-")
                .Append(sphone.Substring(2, 3)).Append("-")
                .Append(sphone.Substring(5, 2)).Append("-")
                .Append(sphone.Substring(7, 2));
            _man.Phone = sb.ToString();
            return this;
        }

        public Man build () {
            if (_man.Name == null || _man.Email == null || _man.Phone == null) {
                throw new NullReferenceException();
            }

            return _man;
        }
    }

}