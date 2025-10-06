namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Diguem quin nom d'usuari vols: ");
        var nomusuari = Console.ReadLine();
        Console.WriteLine("Diguem quin domini: ");
        var domini = Console.ReadLine();
        Console.WriteLine($"La teva adreça serà {nomusuari}@{domini}");
    }
}
