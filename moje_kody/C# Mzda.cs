class Program {
    static void Main() {

        const int HM = 220;
        const int HP = 350;
        int prescas = 0;

        Console.WriteLine("Kolik hodin mas ve smlouve?");
        int hod_smlouva = int.Parse(Console.ReadLine());

        Console.WriteLine("Kolik hodin jsi odpracoval?");
        int hod_odpracovane = int.Parse(Console.ReadLine());

        if (hod_odpracovane > hod_smlouva) {
            prescas = hod_odpracovane - hod_smlouva;
        }

        int vyplata = prescas * HP + HM * (hod_odpracovane - prescas);

        Console.WriteLine($"Vydelal jsi: {vyplata}");    
    }
}