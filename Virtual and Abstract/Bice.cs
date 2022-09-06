using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Abstract
{
    class Bice : Kick_scooter
    {
        string Name = "Велосипед";
        public override void Motor()
        {
            Console.WriteLine("Тут нет двигателя ");
        }
       

        public override void Im_goin()
        {
            Console.WriteLine("Я еду на " + Name + "e");
        }
    }
}
