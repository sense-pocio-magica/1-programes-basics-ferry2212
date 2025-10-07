namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digues el primer numero: ");
        int primernumero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digues el segon numero: ");
        int segonnumero = Convert.ToInt32(Console.ReadLine());
        int suma = primernumero + segonnumero;
        int resta = primernumero - segonnumero;
        int multiplicació = primernumero * segonnumero;
        double divisió = primernumero / segonnumero;
        double divisióresta = primernumero % segonnumero;
        Console.WriteLine($"{primernumero} + {segonnumero} = {suma}");
        Console.WriteLine($"{primernumero} - {segonnumero} = {resta}");
        Console.WriteLine($"{primernumero} * {segonnumero} = {multiplicació}");
        Console.WriteLine($"{primernumero} / {segonnumero} = {divisió} i resta {divisióresta}");
    }
}
