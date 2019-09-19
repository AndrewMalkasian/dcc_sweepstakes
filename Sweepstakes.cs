using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sweeepstakes
{
    public class Sweepstakes : IManager
    {
        int keyId = 0;
        string name;
      
        
        
        
        
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            RandomPrize();
            keyId++;
            contestant.RegistrationNum = keyId;
            UI.GetUserInfo(contestant.FirstName);
            UI.GetUserInfo(contestant.LastName);
            UI.GetUserInfo(contestant.EmailAddress);
            UI.GiveUserKeyID(keyId);
            contestants.Add(keyId, contestant); 


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
        public void RandomPrize()
        {
           var random = new Random();
            List<string> sweepstakesPrizes = new List<string>() { "Stolen Dog" , "a bag of candy wrappers" , "Russian Bride", "TJMaxx giftcard", "Mayoral authority", "box of band-aids(24 pack)"};
            int index = random.Next(sweepstakesPrizes.Count);
            Console.WriteLine($"Enter to win {sweepstakesPrizes[index]}!!!");
        }
    }
}
