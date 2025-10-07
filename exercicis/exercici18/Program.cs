namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quina hora es ara? 1-12 ");
        int horaactual = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Cuantes hores vols incrementar? ");
        int horesaincrementar = Convert.ToInt16(Console.ReadLine());
        int resultat = ((horaactual - 1 + horesaincrementar) % 12) + 1;
        Console.WriteLine($"Hora actual: {horaactual},  hores a incrementar: {horesaincrementar}, d'aqui {horesaincrementar} hores seran les {resultat}");
    }
}
