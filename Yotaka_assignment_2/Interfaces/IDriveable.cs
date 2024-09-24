using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yotaka_assignment_2.Interfaces
{
    public interface IDriveable
    {
        string Drive();
        public bool IsEngineOn();
        public void StartEngine();
        public void StopEngine();
    }
}
