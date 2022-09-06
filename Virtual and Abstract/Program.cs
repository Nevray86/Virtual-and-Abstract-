using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_and_Abstract
{
    abstract class Vehicle
    {
        
        public abstract void Motor();
        public abstract void wheels();
        public virtual void Im_goin()
        {
            
        }
    }
   
    class  Men
    {
        public void Vehicle_Control(Vehicle car)
        {
            car.Im_goin();
            car.Motor();
            car.wheels();
            Console.WriteLine("\n");
        }
       
    }
        internal class Program
        {
        static void Main(string[] args)
            {

                Men men = new Men();
                Vehicle[] vehicle = { new Car(), new Bice(), new Kick_scooter(), new Truck() };
                Console.Write("На чем поедешь?\n0 - Subaru\n1 - Велосипед\n2 - Самокат\n3 - Грузовик\n");
                int a = Convert.ToInt32(Console.ReadLine());
                men.Vehicle_Control(vehicle[a]);
            }
        }
}
