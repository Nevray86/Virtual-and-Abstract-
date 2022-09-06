using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Abstract
{
    class Truck : Car
    {
        string Name = "Камаз";
        public override void Motor()
        {
            Console.WriteLine("Тут дизельный турбодвигатель ");
        }
        public override void wheels()
        {
            Console.WriteLine("6 колес");
        }

        public override void Im_goin()
        {
            Console.WriteLine("Я еду на " + Name + "e");
        }

    }
}
