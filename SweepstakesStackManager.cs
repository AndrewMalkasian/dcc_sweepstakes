using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeepstakes
{
    class SweepstakesStackManager : ISweepstakesManager, IManagable
    {
        Stack<Sweepstakes> manager = new Stack<Sweepstakes>();

        public void GetNewSweepstakes()
        {
            GetSweepstakes();
        }

        public Sweepstakes GetSweepstakes() 
        {
            return manager.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes) 
        {
            manager.Push(sweepstakes);
        }
    }
}
