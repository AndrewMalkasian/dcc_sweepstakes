using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeepstakes
{
   
    public static class SweepstakesFactory
    {
        public static ISweepstakesManager ChoosingSweepstakesManager(int input)
        {
            ISweepstakesManager sweepstakesManager = null;
            switch (input)
            {
                case 1:
                    sweepstakesManager = new SweepstakesQueueManager();
                    break;
                case 2:
                    sweepstakesManager = new SweepstakesStackManager();
                    break;
                   
            }
            return sweepstakesManager;
        }
    }
    
}

            //public class ItemFactory : IGetItem
            //{
            //    public Item GetItemToPurchase(string item)
            //    {
            //        switch (item)
            //        {
            //            case "lemon":
            //                return new Lemon();
            //        }


