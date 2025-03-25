using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSolution;

    public class SpyToolkit
    {
        private readonly List<SpyGadget> gadgets = new List<SpyGadget>();

        public SpyToolkit() { }

        public void AddGadget(string name, string category, int powerLevel = 50, bool isActive = true)
        {
            if (gadgets.Any(g => g.Name == name))
            {
                Console.WriteLine($"{name} already exists.");
                return;
            }
            gadgets.Add(new SpyGadget { Name = name, Category = category, PowerLevel = powerLevel, IsActive = isActive });
            Console.WriteLine($"{name} added to toolkit.");
        }

        public List<SpyGadget> GetActiveGadgets(string category = null)
        {
            return gadgets.Where(s => s.IsActive && (category == null || s.Category == category)).ToList();

        }

        public void DeactivateGadget(string name)
        {
            SpyGadget gadget = new SpyGadget();
            gadget = null;

            foreach (var gadgets in gadgets)
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

        public static bool PowerCheck(List<SpyGadget> gadgets, int minPower)
        {
            return false;
        }


        public void DebugMission(string missionName, int requiredPower)
        {

        }
    }