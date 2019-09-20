using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> manager = new Queue<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            return manager.Dequeue(); 
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            manager.Enqueue(sweepstakes);
            
        }
    }
}
