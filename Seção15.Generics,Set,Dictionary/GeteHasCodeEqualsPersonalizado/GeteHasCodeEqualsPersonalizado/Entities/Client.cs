using System;
using System.Collections.Generic;
using System.Text;

namespace GeteHasCodeEqualsPersonalizado.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        //Customizar

        //sobrescrevi o Equals
        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }
        //sobrescrevi o GetHashCode
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
