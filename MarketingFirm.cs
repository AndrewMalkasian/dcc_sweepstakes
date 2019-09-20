using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager sweepstakesManager;
       
        ///constructor injection
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }

        public void CreateSweepstakes()
        {

            Sweepstakes sweepstakes = new Sweepstakes(UI.GetUserInfo("Enter sweepstakes name"));
            sweepstakesManager.InsertSweepstakes(sweepstakes);

        }

        /// I want this to have functionality to create a sweepstakes
        /// I want to implement dependency injection so that I can utilize a sweepstakes manager.
        /// notes:
        /// dependent on interface + provides functionality.
    }
        }
