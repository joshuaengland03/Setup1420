using arenabattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arenabattle
{
    public class Battle
    {
        public Fighter Fighter1 { get; }
        public Fighter Fighter2 { get; }

        public Battle(Fighter fighter1, Fighter fighter2)
        {
            Fighter1 = fighter1;
            Fighter2 = fighter2;
        }

        public Fighter Fight()
        {
            Console.WriteLine($"The battle begins! {Fighter1.Name} vs. {Fighter2.Name}!");
            Console.WriteLine();
            while (Fighter1.Health > 0 && Fighter2.Health > 0)
            {
                int damage = Fighter1.Attack();
                Fighter2.TakeDamage(damage);

                Console.WriteLine($"{Fighter1.Name} attacks and deals {damage} damage to {Fighter2.Name}. {Fighter2.Name} has {Fighter2.Health} HP remaining.");
                if (Fighter2.Health <= 0)
                {
                    break;
                }
                damage = Fighter2.Attack();
                Fighter1.TakeDamage(damage);

                Console.WriteLine($"{Fighter2.Name} attacks and deals {damage} damage to {Fighter1.Name}. {Fighter1.Name} has {Fighter1.Health} HP remaining.");
                if (Fighter1.Health <= 0)
                {
                    break;
                }
            }
            Console.WriteLine();
            if (Fighter1.Health > 0)
            {
                Console.WriteLine($"{Fighter1.Name} the Barbarian has won the fight!");
                return Fighter1;
            }
            else
            {
                Console.WriteLine($"{Fighter2.Name} the Mage has won the fight!");
                return Fighter2;
            }
        }
    }
}
