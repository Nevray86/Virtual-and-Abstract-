using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Abstract
{
     class Kick_scooter : Vehicle
     {
        string Name = "Самокат";
        public override void Motor()
        {
            Console.WriteLine("Тут маленький электро двигатель ");
        }
        public override void wheels()
        {
            Console.WriteLine("2 колеса");
        }

        public override void Im_goin()
        {
            Console.WriteLine("Я еду на " + Name + "e");
        }
     }
}
