using System;
using System.Collections.Generic;
using System.Linq;
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
        return new List<SpyGadget>();

    }

    public void DeactivateGadget(string name)
    {

    }

    public static bool PowerCheck(List<SpyGadget> gadgets, int minPower)
    {
        return false;
    }


    public void DebugMission(string missionName, int requiredPower)
    {

    }
}
