using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS1._1
{
    class FakeHeater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on - FAKE");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off - FAKE");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
