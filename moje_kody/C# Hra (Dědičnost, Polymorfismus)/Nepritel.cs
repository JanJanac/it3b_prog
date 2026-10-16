class Nepritel : Mistnost
{
    private static Random rnd = new Random();
    public override void Aktivuj(Hrac hrac)
    {
        Console.WriteLine("Narazil jsi na Nepritele!");
        if (rnd.Next(2) == 0)
        {
            Console.WriteLine("Boj jsi vyhral.");
        }
        else
        {
            hrac.Zivoty -= 20;
            Console.WriteLine("Boj jsi prohral a ztratil 20 zivotu!");
        }
        hrac.VypisInfo();
    }
}