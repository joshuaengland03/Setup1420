using arenabattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arenabattle
{
    public class Mage : Fighter
    {
        public Mage(string name) : base(name, 85, 15)
        {
        }
        public override int Attack()
        {
            Random random = new Random();
            int damageModifier = random.Next(5, 15);
            int damage = AttackPower + damageModifier;
            return damage;
        }
    }
}
