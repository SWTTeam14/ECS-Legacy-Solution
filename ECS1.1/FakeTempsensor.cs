using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS1._1
{
    class FakeTempsensor : ITempsensor
    {
        
        public int GetTemp()
        {
            return 25;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
