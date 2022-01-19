using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2
{
    class Program
    {
        static Player player1 = new Player();

        static void Main(string[] args)
        {
            Console.WriteLine("Health System V.2");
            Console.WriteLine("Incorporating OOP");
            Console.ReadKey(true);

            player1.ShowHUD();
            Console.ReadKey();

            player1.TakeDamage(50);
            player1.Heal(25);
            player1.TakeDamage(100);
            player1.TakeDamage(150);
            player1.TakeDamage(150);

            Console.ReadKey(true);
        }
    }
}
