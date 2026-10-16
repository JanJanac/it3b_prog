class ViteznyTrun : Mistnost
{
    public override void Aktivuj(Hrac hrac)
    {
        Console.WriteLine("Dorazil jsi k Viteznemu trunu!");
        Console.WriteLine($"Gratuluji, dohral jsi hru! Zustalo ti {hrac.Zivoty} HP a {hrac.Penize} peněz.");
    }
}