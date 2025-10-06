namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digues la primera nota: ");
        var primera = Console.ReadLine();
        int primera1 = Convert.ToInt16(primera);
        Console.WriteLine("Digues la Segona nota: ");
        var Segona = Console.ReadLine();
        int Segona1 = Convert.ToInt16(Segona);
        Console.WriteLine("Digues la tercera nota: ");
        var tercera = Console.ReadLine();
        int tercera1 = Convert.ToInt16(tercera);
        float mitjana = primera1 + Segona1 + tercera1;
        var mitjanafinal = mitjana / 3;
        Console.WriteLine($"La mitjana es {mitjanafinal}");
    }
}
