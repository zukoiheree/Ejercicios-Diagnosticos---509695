```csharp
using System;  

class Program  
{
    static void Main()  
    {
        int n = 20; 
        Console.WriteLine("Numeros primos en la serie de Fibonacci hasta el termino " + n + ":");  
        FibonacciPrimos(n);  
    }

    static void FibonacciPrimos(int n)  
    {
        int a = 0;        
        int b = 1;        
        int contador = 0; 

        while (contador < n)  
        {
            int actual = a;  
            a = b;         
            b = actual + b;  

            if (EsPrimo(actual))  
            {
                Console.WriteLine(actual);  
            }

            contador++;  
        }
    }

    static bool EsPrimo(int numero)  
    {
        if (numero < 2) return false;  

        for (int i = 2; i <= Math.Sqrt(numero); i++)  
        {
            if (numero % i == 0) return false;  
        }

        return true;  
    }
}
```
