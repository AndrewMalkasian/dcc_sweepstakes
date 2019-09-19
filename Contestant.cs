using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeepstakes
{

    public class Contestant
    {
        //Contestant contestant;
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNum;
        
       
        public Contestant()
        {
            this.FirstName = UI.GetUserInfo("Please enter your first name");
            this.LastName = UI.GetUserInfo("Please enter your Last name");
            this.EmailAddress = UI.GetUserInfo("Please enter your e-mail address");
          
         
        }

       
    }
    
}
