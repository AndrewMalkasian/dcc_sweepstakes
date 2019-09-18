using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeepstakes
{
    interface IContestant
    {
        void RegisterContestant(Contestant conetestant);
        void PrintContestantInfo(Contestant contestant);
    }
}
