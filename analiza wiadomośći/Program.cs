using System;

public class Kata
{
    public static bool Validate_hello(string greetings)
    {
        greetings = greetings.ToLower();
        return greetings.Contains("hello") ||
               greetings.Contains("ciao") ||
               greetings.Contains("salut") ||
               greetings.Contains("hallo") ||
               greetings.Contains("hola") ||
               greetings.Contains("ahoj") ||
               greetings.Contains("czesc");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowadź fragment tekstu:");
        string tekst = Console.ReadLine();

        if (Kata.Validate_hello(tekst))
        {
            Console.WriteLine("Tekst zawiera pozdrowienie!");
        }
        else
        {
            Console.WriteLine("Tekst nie zawiera pozdrowienia.");
        }
    }
}
