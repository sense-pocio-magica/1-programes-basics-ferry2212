namespace exercici8;

/* Assigna un nombre total de minuts a una variable.
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digues quants minuts: ");
        var minuts = Console.ReadLine();
        int minuts1 = Convert.ToInt32(minuts);

        int hores = minuts1 / 60;
        int Minutsrestants = minuts1 % 60;

        Console.WriteLine($"Son {hores} hores i queden {Minutsrestants} minuts.");
    }
}
