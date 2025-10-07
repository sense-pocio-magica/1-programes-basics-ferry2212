namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Diguem una paraula: ");
        string paraula =  Console.ReadLine();
        char primeralletra = paraula[0];
        char ultimalletra = paraula[^1];
        int parauladelcentre = paraula.Length;
        int lletramig = (parauladelcentre - 1) / 2;
        char lletracentral = paraula[lletramig];
        Console.WriteLine($"Aquesta es la primera lletra: {primeralletra}, aquesta es la última: {ultimalletra} i la del mig es aquesta: {lletracentral} ");
    }
}
