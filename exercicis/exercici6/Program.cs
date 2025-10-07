namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats)
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina mida fa un costat del quadrat? ");
        var costat = Console.ReadLine();
        int costat2 = Convert.ToInt16(costat);
        int perimetre = costat2 * 4;
        Console.WriteLine($"El perímetre és de {perimetre}");
    }
}
