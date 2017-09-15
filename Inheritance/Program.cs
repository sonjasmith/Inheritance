using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat ssSonja = new Boat(2, 500, "red", 80.0d, .90d);
            ssSonja.Move();
            ssSonja.Move();
            Console.WriteLine("Boat " + ssSonja.GetDistanceTraveled());
            Automobile tesla = new Automobile(4, 22, 2, 2, 500, "Yellow", 250d);
            tesla.Move();
            Console.WriteLine("car " + tesla.GetDistanceTraveled());
        }
    }
}
