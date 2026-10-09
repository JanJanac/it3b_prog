class Dum : Objekt
{
    public int Patra {  get; set; }
    public int Zahrada { get; set; }
    public Dum (string popis, int cena, int patra, int zahrada) : base (cena , popis)
    {
        Patra = patra;
        Zahrada = zahrada;
    }

    public void VypisInfo()
    {
        Console.WriteLine($"Cena domu je: {Cena} \nDum ma: {Patra} pater\nZahrada je velka: {Zahrada}m2\nPopis: {Popis}\n");
    }
}