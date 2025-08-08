using System;  
// Se importa el espacio de nombres necesario para usar funciones básicas como Console y String.

class Program  
{
    static void Main()  
    {
        int segundos = 7384;  
        string resultado = FormatearTiempo(segundos);  
        Console.WriteLine("Tiempo formateado: " + resultado);  
    }

    static string FormatearTiempo(int totalSegundos)  
    {
        int horas = totalSegundos / 3600;  

        int minutos = (totalSegundos % 3600) / 60;  

        int segundos = totalSegundos % 60;  

        return $"{horas:D2}:{minutos:D2}:{segundos:D2}";  
    }
}


