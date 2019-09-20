using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> manager = new Stack<Sweepstakes>();

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
