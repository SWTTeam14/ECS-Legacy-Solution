using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS1._1
{
    class Application
    {
        public static void Main(string[] args)
        {
            var ecs = new ECS(28, new Tempsensor(), new Heater());

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();

            Console.ReadKey();
        }

    }
}
