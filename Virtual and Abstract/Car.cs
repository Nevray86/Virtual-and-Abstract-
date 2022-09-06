using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Abstract
{
     class Car : Vehicle
     {
        string Name = "Subaru STI";
        public override void Motor()
        {
            Console.WriteLine("Тут бензиновый турбодвигатель ");
        }
        public override void wheels()
        {
            Console.WriteLine("4 колеса");
        }

        public override void Im_goin()
        {
            Console.WriteLine("Я еду на " + Name);
        }

     }
}
