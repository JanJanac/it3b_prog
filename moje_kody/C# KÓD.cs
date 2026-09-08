class Program {
    static void Main() {

        const int kod = 987654321;
        int kod_uzivatel;
        int pokusy = 5;
        bool otevreno = false;

        for (int i = 0; i < pokusy; i++) {
            Console.WriteLine("Zadej kod do trezoru (9mistny):");
            kod_uzivatel = int.Parse(Console.ReadLine());

            if (kod == kod_uzivatel) {
                Console.WriteLine("Odhalil si kod, gratuluju");
                otevreno = true;
                break;
            }
        }

        if (otevreno == false) {
            Console.WriteLine("Kod si neodhalil");
        }
    }
}