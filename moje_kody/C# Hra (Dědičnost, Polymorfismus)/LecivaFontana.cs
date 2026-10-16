class LecivaFontana : Mistnost
{
    public override void Aktivuj(Hrac hrac)
    {
        Console.WriteLine("Vstoupil jsi do Lecive fontany.");
        if (hrac.Penize >= 20)
        {
            hrac.Penize -= 20;
            hrac.Zivoty += 20;
            Console.WriteLine("Vylecil sis 20 zivotu za 20 penez.");
        }
        else
        {
            Console.WriteLine("Nemas dost penez na vyleceni!");
        }
        hrac.VypisInfo();
    }
}