using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyTools
{
    class SpyToolkit
    {
        List<SpyGadget> SpyGadgets { get; set; } = new List<SpyGadget>();
        public SpyToolkit()
        {

        }


        public void AddGadget(string name, string category, int powerLevel = 50, bool isActive = true)
        {
            SpyGadget spyGadget = new SpyGadget();
            spyGadget.Name = name;
            spyGadget.Category = category;
            spyGadget.PowerLevel = powerLevel;
            spyGadget.IsActive = isActive;

            bool containsGadget = SpyGadgets.Any(s => s.Name == name);

            if (containsGadget)
            {
                Console.WriteLine($"{name} already exists.");
                return;
            }

            SpyGadgets.Add(spyGadget);
            Console.WriteLine($"{name} added to toolkit.");
        }


        public List<SpyGadget> GetActiveGadgets(string category = null)
        {
            return SpyGadgets.Where(s => s.IsActive && (category == null || s.Category == category)).ToList();
        }

        public void DeactivateGadget(string name)
        {
            SpyGadget gadget = new SpyGadget();
            gadget = null;

            foreach (var gadgets in SpyGadgets)
            {
                if (gadgets.Name == name)
                {
                    gadget = gadgets;
                    break;
                }
            }

            if (gadget != null)
            {
                Console.WriteLine($"{name} deactivated.");
                gadget.IsActive = false;
            }
            else
            {
                Console.WriteLine($"{name} not found.");
            }
        }

    }
}
