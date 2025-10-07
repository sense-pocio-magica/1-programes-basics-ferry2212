namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A quin carrer vius? ");
        var carrer = Console.ReadLine();
        Console.WriteLine("Quin número es? ");
        var numero = Console.ReadLine();
        int numerocarrer = Convert.ToInt16(numero);
        Console.WriteLine("I quin es el codi postal? ");
        var codi = Console.ReadLine();
        int codipostal = Convert.ToInt16(codi);
        Console.WriteLine("I quina població? ");
        var poblacio = Console.ReadLine();
        Console.WriteLine($"Vius a {carrer}, número {numerocarrer}, {codipostal}, {poblacio}");

    }
}
