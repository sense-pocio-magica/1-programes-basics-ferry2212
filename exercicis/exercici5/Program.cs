namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Com et dius? ");
        var nom = Console.ReadLine();
        Console.WriteLine("Quin any vas neixer? ");
        var any = Console.ReadLine();
        int any2 = Convert.ToInt16(any);
        int edat = 2025 - any2;
        Console.WriteLine($"Hola {nom}! Ja tens {edat} anys? ");
    }
}
