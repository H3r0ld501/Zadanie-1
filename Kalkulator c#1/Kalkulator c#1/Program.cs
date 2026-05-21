using System;

class Zadanie1
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Podaj operację (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+": Console.WriteLine($"Wynik: {a + b}"); break;
            case "-": Console.WriteLine($"Wynik: {a - b}"); break;
            case "*": Console.WriteLine($"Wynik: {a * b}"); break;
            case "/":
                if (b != 0) Console.WriteLine($"Wynik: {a / b}");
                else Console.WriteLine("Błąd: dzielenie przez zero.");
                break;
            default: Console.WriteLine("Nieznana operacja."); break;
        }
        Console.ReadKey();
    }
}
