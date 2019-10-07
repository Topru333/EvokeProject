using System;

namespace EvokeProjectWithApi.Models {

    public abstract class Prototype {
        public abstract Prototype Clone ();
    }

    public class Man : Prototype {

        private Man () {

        }

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

        public override Prototype Clone () {
            return new Builder().SetName(this.Name).SetAge(this.Age).SetPhone(this.Phone).SetEmail(this.Email).build();
        }

        public class Builder {

            private Man _man = new Man();

            public Builder SetName (string name) {
                _man.Name = name;
                return this;
            }

            public Builder SetAge (int age) {
                if (age < 16) {
                    throw new Exception("Age isn't correct!");
                }
                _man.Age = age;
                return this;
            }

            public Builder SetEmail (string email) {
                _man.Email = email;
                return this;
            }

            public Builder SetPhone (string sphone) {
                if (sphone.Length != 9) {
                    throw new Exception("Phone isn't correct!");
                }
                _man.Phone = sphone;
                return this;
            }

            public Builder SetPhone (int phone) {
                this.SetPhone(""+phone);
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

}