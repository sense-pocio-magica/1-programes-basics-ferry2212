namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Diguem la teva nota de pràciques: ");
        string practiques = Console.ReadLine();
        double notapractiques = double.Parse(practiques);
        Console.WriteLine("Diguem la teva nota d'examens: ");
        string examens = Console.ReadLine();
        double notaexamens = double.Parse(examens);
        double mitjana = notapractiques + notaexamens;
        double mitjanafinal = mitjana / 2;
        int notafinal = (int)Math.Round(mitjanafinal, 0, MidpointRounding.AwayFromZero);
        Console.WriteLine($"La teva mitjana es {mitjanafinal} es a dir {notafinal}");

    }
}
