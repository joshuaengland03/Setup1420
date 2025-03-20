using arenabattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arenabattle
{
    public class Barbarian : Fighter
    {
        public Barbarian(string name) : base(name, 100, 15)
        {
        }
        public override int Attack()
        {
            Random random = new Random();
            int damageModifier = random.Next(1, 5);
            int damage = AttackPower + damageModifier;
            return damage;
        }
    }
}
