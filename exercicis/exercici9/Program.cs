namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres)
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Diguem un valor en metres: ");
        int metres = Convert.ToInt16(Console.ReadLine());
        const double peus = 3.28084;
        double resultat = metres * peus;
        Console.WriteLine($"El resulat es {resultat} peus");
    }
}
