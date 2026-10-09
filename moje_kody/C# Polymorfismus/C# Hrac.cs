class Hrac
{
    public void Utok()
    {
        Console.WriteLine("Bojovnik utoci");
    }
    public void Utok(int sila)
    {
        Console.WriteLine($"Bojovnik utoci silou {sila}");
    }
    public void Utok(string zbran)
    {
        Console.WriteLine($"Bojovnik utoci pomoci {zbran}");
    }
    public void Utok(int sila, string zbran)
    {
        Console.WriteLine($"Bojovnik utoci pomoci {zbran} silou {sila}");
    }
}