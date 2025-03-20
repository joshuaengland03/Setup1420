using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arenabattle
{
    public abstract class Fighter
    {
        public string Name { get; }
        public int Health { get; protected set; }
        public int AttackPower { get; }
        public Fighter(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }
        public abstract int Attack();
        public void TakeDamage(int damage)
        {
            Health = Health - damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }
    }
}
