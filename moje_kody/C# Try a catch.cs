class Program
{
    static void Main()
    {
        float cena = 0;
        float pocet = 0;

        Console.WriteLine("Zadej pocet osob:");
        try {
            pocet = float.Parse(Console.ReadLine());
        } catch (DivideByZeroException) {
            Console.WriteLine("ZaNulou nelze delit");
        } catch (FormatException) {
            Console.WriteLine("Musis zadat cislo");
        }

        Console.WriteLine("Zadej kolik stal skupinovy listek:");
        try {
            cena = float.Parse(Console.ReadLine());
        } catch (FormatException) {
            Console.WriteLine("Musis zadat cislo");
        } catch (DivideByZeroException) {
            Console.WriteLine("ZaNulou nelze delit");
        }

        float cena_osoba = (float)cena / pocet;

        Console.WriteLine($"Jedna osoba dala za listek: {cena_osoba} ");

    }
}