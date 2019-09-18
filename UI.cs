using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeepstakes
{
    class UI
    {
        public void GetInformation(Contestant contestant)
        {
            Console.WriteLine("Enter First Name: ");
            contestant.FirstName = Console.ReadLine();    

            Console.WriteLine("Enter Last Name: ");
            contestant.LastName = Console.ReadLine();

            Console.WriteLine("Enter E-mail: ");
            contestant.EmailAddress = Console.ReadLine();

         //call function that gives registration #
        }
        
    }
}
