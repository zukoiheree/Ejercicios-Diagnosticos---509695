using System;

class Program
{
    static void Main()
    {
        int apuesta = 1000;

        Console.Write("Ingrese el numero de 4 digitos que quiere apostar: ");
        string entrada = Console.ReadLine();

        if (entrada.Length != 4 || !int.TryParse(entrada, out int numeroApostado))
        {
            Console.WriteLine("Error: debe ingresar exactamente un número de 4 dígitos.");
            return;
        }

        Random rand = new Random();
        int resultado = rand.Next(1000, 10000);

        Console.WriteLine("Numero ganador: " + resultado);

        if (numeroApostado == resultado)
        {
            Console.WriteLine("¡Felicidades! ¡Ganaste!");
        }
        else
        {
            Console.WriteLine("Lo sentimos, no gano esta vez.");
        }
    }
}

