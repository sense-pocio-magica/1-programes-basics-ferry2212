namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digues un nom: ");
        string nom = Console.ReadLine();
        Console.WriteLine("Digues un cognom: ");
        string cognom = Console.ReadLine();
        char primeralletra = nom[0];
        string larestadelnom = nom.Substring(1);
        string nombenfet = primeralletra.ToString().ToUpper() + larestadelnom;
        char primeralletracognom = cognom[0];
        string larestadelcognom = cognom.Substring(1);
        string cognombenfet = primeralletracognom.ToString().ToUpper() + larestadelcognom;
        Console.WriteLine($"Et dius: {nombenfet} {cognombenfet}");
    }
}
