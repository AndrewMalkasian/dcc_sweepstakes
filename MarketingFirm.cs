using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeepstakes
{
    public class MarketingFirm : IManager
    {
        ISweepstakesManager sweepstakes;
        //constructor injection

        public MarketingFirm(ISweepstakesManager sweepstakes)
        {
            this.sweepstakes = sweepstakes;
        }

        public void NewSweepstakes()
        {
            sweepstakes.GetSweepstakes();
        }
        /// I want this to have functionality to create a sweepstakes
        /// I want to implement dependency injection so that I can utilize a sweepstakes manager.
        /// notes:
        /// dependent on interface + provides functionality.
    }
}
