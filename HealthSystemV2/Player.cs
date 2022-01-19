using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2
{
    class Player
    {

        public int currentHealth = 100;

        public void TakeDamage(int damageTaken)
        {
            currentHealth = currentHealth - damageTaken;

        }
        public Player()
        {
            currentHealth = 100;
        }
        public void Heal(int healthHealed)
        {
            currentHealth = currentHealth + healthHealed;
        }
        public void ShowStats()
        {
            Console.WriteLine();
            Console.WriteLine("--------------HUD--------------");
            Console.WriteLine("Player health: " + currentHealth);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }

    }
}
