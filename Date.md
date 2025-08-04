```csharp
using System;  
// Se importa el espacio de nombres necesario para usar funciones básicas como Console y String.

class Program  
{
    static void Main()  
    {
        int segundos = 7384;  
        // Declaramos una variable con la cantidad total de segundos.

        string resultado = FormatearTiempo(segundos);  
        // Llamamos a la función que convierte los segundos a formato HH:MM:SS.

        Console.WriteLine("Tiempo formateado: " + resultado);  
        // Mostramos el resultado final por pantalla.
    }

    static string FormatearTiempo(int totalSegundos)  
    {
        int horas = totalSegundos / 3600;  
        // Calculamos cuántas horas caben en totalSegundos (1 hora = 3600 s).

        int minutos = (totalSegundos % 3600) / 60;  
        // Usamos el residuo (lo que sobra tras quitar horas) para calcular los minutos.

        int segundos = totalSegundos % 60;  
        // Finalmente, los segundos son el residuo final que no cabe en horas ni minutos.

        return $"{horas:D2}:{minutos:D2}:{segundos:D2}";  
        // Retornamos un string con formato HH:MM:SS, asegurando dos dígitos por número (ej. 04:08:09).
    }
}

```
<img width="326" height="76" alt="image" src="https://github.com/user-attachments/assets/21a315f7-fc99-4df4-bbc5-2382d51adcec" />
