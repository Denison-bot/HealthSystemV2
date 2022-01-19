using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV2
{
    class Player
    {

        public int currentHealth;
        //public int currentShield;
        public int currentLives;

        public Player()
        {
            currentHealth = 100;
            //currentShield = 100;
            currentLives = 3;
        }

        public void TakeDamage(int damageTaken)
        {
            Console.WriteLine("Player takes " + damageTaken + " damage");

            //if (damageTaken >= 0)
            //{
            //    currentShield = currentShield - damageTaken;

            //    if (currentShield <= 0)
            //    {
            //        currentHealth = currentHealth - currentShield;
            //    }
            //    if (currentShield <= 0)
            //    {
            //        currentShield = 0;
            //        currentHealth = currentHealth - damageTaken;
            //    }
            //    if (currentHealth <= 0)
            //    {
            //        currentLives = currentLives - 1;
            //        Respawn();
            //        if (currentLives == 0)
            //        {
            //            GameOver();
            //        }
            //    }
            //}

            currentHealth = currentHealth - damageTaken;
            if (currentHealth <= 0)
            {
                currentLives = currentLives - 1;
                Respawn();
                if (currentLives == 0)
                {
                    GameOver();
                }
            }


            ShowHUD();
            Console.ReadKey(true);
        }

        public void GameOver()
        {
            Console.WriteLine("GAME OVER");
            Console.ReadKey(true);
            ResetGame();
        }

        public void ResetGame()
        {
            Console.WriteLine("Restarting...");
            Console.ReadKey(true);
            currentHealth = 100;
            //currentShield = 100;
            currentLives = 3;
            
        }

        public void Respawn()
        {
            Console.WriteLine("You Died");
            Console.WriteLine("Respawn");
            Console.ReadKey(true);
            currentHealth = 100;
            //currentShield = 100;
        }
            
        public void Heal(int healthHealed)
        {
            currentHealth = currentHealth + healthHealed;
            Console.WriteLine("Player heals " + healthHealed + " health");
            ShowHUD();
            Console.ReadKey(true);
        }
        public void ShowHUD()
        {
            Console.WriteLine();
            Console.WriteLine("--------------HUD--------------");
            Console.WriteLine("Player health: " + currentHealth + "%");
            //Console.WriteLine("Player shield: " + currentShield + "%");
            Console.WriteLine("Player lives: " + currentLives);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }
    }
}
