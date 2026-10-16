class Hrac
{
    public int Zivoty = 50;
    public int Penize = 50;

    public Hrac(int zivoty, int penize)
    {
        Zivoty = zivoty;
        Penize = penize;
    }

    public void PridejPenize(int pridej)
    {
        Penize = Penize + pridej;
        Console.WriteLine($"Gratuluji, ziskal jsi {pridej} penez.\n");
        Console.WriteLine($"Ted mas tolik penez:{Penize}\n");
    }

    public void VypisInfo()
    {
        Console.WriteLine($"Mas {Zivoty} HP a {Penize} Penez.\n");
    }
}