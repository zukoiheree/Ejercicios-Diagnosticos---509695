using System;

abstract class AbstractSample
{
    private string message;

    public AbstractSample(string message)
    {
        this.message = message;
    }

    public abstract void PrintMessage(string message);

    public virtual string InvertMessage(string message)
    {
        char[] chars = message.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    // Acceso protegido al mensaje original
    protected string GetMessage()
    {
        return message;
    }
}

// Clase 1: imprime el mensaje tal cual
class SimplePrinter : AbstractSample
{
    public SimplePrinter(string message) : base(message) {}

    public override void PrintMessage(string message)
    {
        Console.WriteLine("Mensaje directo: " + message);
    }
}

// Clase 2: imprime el mensaje invertido y cambia mayúsculas/minúsculas
class FancyPrinter : AbstractSample
{
    public FancyPrinter(string message) : base(message) {}

    public override void PrintMessage(string message)
    {
        string transformed = "";
        foreach (char c in message)
        {
            if (char.IsUpper(c))
                transformed += char.ToLower(c);
            else if (char.IsLower(c))
                transformed += char.ToUpper(c);
            else
                transformed += c;
        }

        char[] chars = transformed.ToCharArray();
        Array.Reverse(chars);
        Console.WriteLine("Mensaje estilizado: " + new string(chars));
    }

    public override string InvertMessage(string message)
    {
        char[] chars = message.ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);
        string inverted = "";
        foreach (char c in reversed)
        {
            if (char.IsUpper(c))
                inverted += char.ToLower(c);
            else if (char.IsLower(c))
                inverted += char.ToUpper(c);
            else
                inverted += c;
        }
        return inverted;
    }
}

// Clase que administra los mensajes
class MessageManager
{
    public static void Main()
    {
        AbstractSample printer1 = new SimplePrinter("Hola Mundo!");
        AbstractSample printer2 = new FancyPrinter("Hola Mundo!");

        printer1.PrintMessage(printer1.InvertMessage("Hola Mundo!"));
        printer2.PrintMessage(printer2.InvertMessage("Hola Mundo!"));
    }
}

<img width="280" height="52" alt="image" src="https://github.com/user-attachments/assets/363d24b7-2fbb-423b-b5eb-d871556266bb" />
