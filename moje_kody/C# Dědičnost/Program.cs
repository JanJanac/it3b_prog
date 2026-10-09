class Program
{
    static void Main(string[] args)
    {
        Byt mujByt = new Byt("Slunný 2+kk", 3500000, 3);
        mujByt.VypisInfo();

        Dum mujDum = new Dum("Rodinný dům se sklepem", 7200000, 2, 500);
        mujDum.VypisInfo();
    }
}