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
        while (Fighter1.Health > 0 && Fighter2.Health > 0)
        {
            int damage = Fighter1.Attack();
            Fighter2.TakeDamage(damage);
            Console.WriteLine($"{Fighter1.Name} attacks and deals {damage} damage. {Fighter2.Name} has {Fighter2.Health} HP remaining.");
            if (Fighter2.Health <= 0)
            {
                break;
            }
            damage = Fighter2.Attack();
            Fighter1.TakeDamage(damage);
            Console.WriteLine($"{Fighter2.Name} attacks and deals {damage} damage. {Fighter1.Name} has {Fighter1.Health} HP remaining.");
            if (Fighter1.Health <= 0)
            {
                break;
            }
        }
        if (Fighter1.Health > 0)
        {
            Console.WriteLine($"{Fighter1.Name} the {Fighter1} has won the fight!");
            return Fighter1;
        }
        else
        {
            Console.WriteLine($"Winner: {Fighter2.Name} the {Fighter2}!");
            return Fighter2;
        }
    }
}