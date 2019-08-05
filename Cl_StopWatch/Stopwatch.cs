using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_StopWatch
{
    class Stopwatch
    {
        public DateTime begin;
        public DateTime end;
        
        public void Start()
        {            
            begin = DateTime.Now;
            while (Stop())            
                begin.AddSeconds(1);            
        }

        public bool Stop()
        {
            end = DateTime.Now;
            return false;
        }

    }
}
