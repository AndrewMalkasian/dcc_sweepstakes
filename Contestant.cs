using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeepstakes
{

    public abstract class Contestant
    {
        Contestant contestant;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNum;
        
       
        public Contestant(string FirstName, string LastName, string EmailAddress)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
         
        }

       
    }
    
}
