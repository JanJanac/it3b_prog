class Truhla : Mistnost
{
    public override void Aktivuj(Hrac hrac)
    {
        Console.WriteLine("Nasel jsi Truhlu!");
        hrac.PridejPenize(10);
        hrac.VypisInfo();
    }
}
