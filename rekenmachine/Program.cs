using System;

class Program
{
    static void Main(string[] args)
    {
        // Vraag de gebruiker om het eerste getal in te voeren
        Console.WriteLine("Voer het eerste getal in:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Vraag de gebruiker om het tweede getal in te voeren
        Console.WriteLine("Voer het tweede getal in:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Vraag de gebruiker welke bewerking hij/zij wil uitvoeren
        Console.WriteLine("Welke bewerking wil je uitvoeren? (+, -, x, /)");
        char operation = Convert.ToChar(Console.ReadLine());

        // Uitvoeren van de gekozen bewerking
        double result = 0;
        switch (operation)
        {
            case '+':
                result = number1 + number2;
                break;
            case '-':
                result = number1 - number2;
                break;
            case 'x':
                result = number1 * number2;
                break;
            case '/':
                // Controleer deling door nul
                if (number2 != 0)
                    result = (double)number1 / number2;
                else
                    Console.WriteLine("Kan niet delen door nul.");
                break;
            default:
                Console.WriteLine("Ongeldige bewerking.");
                break;
        }

        // Toon het resultaat aan de gebruiker
        if (operation != '/')
            Console.WriteLine($"Het resultaat van {number1} {operation} {number2} is: {result}");

        // Houd het programma open totdat de gebruiker een toets indrukt om af te sluiten
        Console.WriteLine("Druk op een toets om af te sluiten...");
        Console.ReadKey();
    }
}