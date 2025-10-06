namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin es el nom del producte? ");
        var nom = Console.ReadLine();
        Console.WriteLine("I el preu? ");
        var preu = Console.ReadLine();
        double preu2 = Convert.ToDouble(preu);
        bool enEstock = false;
        Console.WriteLine("Està en estoc? ");
        var estoc = Console.ReadLine();
        Console.WriteLine($"El producte es diu {nom}, te un preu de {preu} i {estoc} està en estoc");
    }
}
