class Byt : Objekt
{
    public int Patro {  get; set; }
    public Byt(string popis, int cena, int patro) : base(cena, popis)
    {
        Patro = patro;
    }

    public void VypisInfo()
    {
        Console.WriteLine($"Cena bytu je: {Cena} \nByt je ve: {Patro}. patre\nPopis: {Popis}\n");
    }
}