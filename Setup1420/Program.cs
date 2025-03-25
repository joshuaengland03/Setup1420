namespace SpyTools
{
    class Program
    {
        static void Main(string[] args)
        {
            SpyToolkit spyToolkit = new SpyToolkit();
            spyToolkit.AddGadget("Freeze Ray", "Weapon");
            spyToolkit.AddGadget("Grappling Hook", "Utility");
            spyToolkit.AddGadget("Freeze Ray", "Weapon");
        }
    }
}