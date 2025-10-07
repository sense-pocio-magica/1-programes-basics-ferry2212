namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Diguem una paraula: ");
        string paraula = Console.ReadLine();
        int paraula1 = paraula.Length;
        Console.WriteLine($"La paraula és {paraula}, i te {paraula1} caracters");
    }
}
