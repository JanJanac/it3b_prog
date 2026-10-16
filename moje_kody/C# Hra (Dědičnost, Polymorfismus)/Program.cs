class Program
{
    static void Main()
    {
        Hrac hrac = new Hrac(50, 50);
        hrac.VypisInfo();
        Console.WriteLine("-----------------------------------");
        List<Mistnost> mistnosti = new List<Mistnost>();
        mistnosti.Add(new Nepritel());
        mistnosti.Add(new Truhla());
        mistnosti.Add(new LecivaFontana());
        mistnosti.Add(new Truhla());
        mistnosti.Add(new Nepritel());
        mistnosti.Add(new ViteznyTrun());
       
        foreach (Mistnost m in mistnosti)
        {
            m.Aktivuj(hrac);
            Console.WriteLine("-----------------------------------");
        }
    }
}