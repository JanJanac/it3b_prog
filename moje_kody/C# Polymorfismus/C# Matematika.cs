static class Matematika
{
    public static void Max(int cislo1, int cislo2)
    {
        if (cislo1 < cislo2)
        {
            Console.WriteLine($"Maximum je {cislo2}");
        }else
        {
            Console.WriteLine($"Maximum je {cislo1}");
        }
    }

    public static void Max(int cislo1, int cislo2, int cislo3)
    {
        if (cislo1 < cislo2 && cislo3 < cislo2)
        {
            Console.WriteLine($"Maximum je {cislo2}");
        }
        else if (cislo1 < cislo3)
        {
        Console.WriteLine($"Maximum je {cislo3}");
        } else
        {
            Console.WriteLine($"Maximum je {cislo1}");
        }
    }
}