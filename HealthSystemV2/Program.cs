using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2
{
    class Program
    {
        static Player player1 = new Player;

        static void Main(string[] args)
        {
            Console.WriteLine("Health System V.2");
            Console.WriteLine("Incorporating OOP");
            Console.ReadKey();

            player1.ShowStats();



            Console.ReadKey(true);
        }
    }
}
