Garen g = new Garen();


RubyCrystal rb = new RubyCrystal();
Ringofregen RoR = new Ringofregen();
g.showHP();
g.buyItem(rb);
g.showHP();
g.buyItem(RoR);g.showHP();


class Champion
{
    public string name;
    public float hp;
    public Item[] items;

    public Champion()
    {
        name = "";
        hp = 0;
        items = new Item[6];
        Console.WriteLine("Konstruktor klasy Champion");
    }
    public void buyItem(Item i)
    {
        Console.WriteLine(name.ToString() + " kupuje " + i.name.ToString());
        items[0] = i;
        hp += i.stats["HP"];
    }
    public void showHP()
    {
        Console.WriteLine("Postać ma " + hp.ToString() + "HP");
    }
}
class Garen : Champion
{
    public Garen()
    {
        name = "Garen";
        hp = 620;
        Console.WriteLine("Konstruktor klasy Garen");
    }




}

public class Item
{
    public string name;
    public int price;
    public Dictionary<string, float> stats;

    public Item()
    {
        name = "";
        price = 0;
        stats = new Dictionary<string, float>();
        stats.Add("HP", 0);
        stats.Add("AP", 0);
        stats.Add("AD", 0);
    }
}
public class RubyCrystal : Item
{
    public int bonusHP = 150;
    public RubyCrystal()
    {
        name = "Ruby Crystal";
        price = 400;
        stats["HP"] = 150;
    }
}
public class Ringofregen : Item
{
    public int bonusHP = 150;
    public Ringofregen()
    {
        name = "Ring of Regen";
        price = 2400;
        stats["HP"] = 13000;
    }
}
