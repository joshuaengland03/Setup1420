namespace arenabattle
{

    public class Program
    {
        public static void Main()
        {
            Fighter fighter1 = new Barbarian("Gronk");
            Fighter fighter2 = new Mage("Dumbledore");
            Battle battle = new Battle(fighter1, fighter2);
            battle.Fight();
        }
    }
}