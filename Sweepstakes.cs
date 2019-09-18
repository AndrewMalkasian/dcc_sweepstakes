using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sweeepstakes
{
    class Sweepstakes
    {
        int keyId = 1;
        string name;
        
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNum = keyId;
            while (contestants.ContainsKey(keyId))
            {
                keyId++;
            }
            contestants.Add(keyId, contestant); ///has been added to dictionary


        }
        public void PrintContestantInfo(Contestant contestant)
        { 
            foreach (var Contestant in contestants)
            {
                if (contestants.ContainsKey(keyId))
                {
                    Console.WriteLine(contestant.FirstName + " " + contestant.LastName);
                    Console.WriteLine(contestant.EmailAddress);
                }
            } 
            //need to pull from dictionary
        }
    }
}
