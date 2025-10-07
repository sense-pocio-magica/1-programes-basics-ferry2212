namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        int numero, resultat, C, D, U;
        Console.WriteLine("Diguem un numero de 3 xifres: ");
        numero = Convert.ToInt32(Console.ReadLine());
        C = numero / 100;
        numero = numero % 100;
        D = numero / 10;
        U = numero % 10;
        resultat = (U * 100) + (D * 10) + C;
        Console.WriteLine($"El numero invertit és: {resultat}");

    }
}
