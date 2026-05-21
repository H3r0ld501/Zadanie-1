using System;

class Program
{
    static void Zadanie1()
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
    }

    static void Zadanie2()
    {
        Console.Write("Kierunek konwersji (C = Celsjusz→Fahrenheit, F = Fahrenheit→Celsjusz): ");
        string kierunek = Console.ReadLine().ToUpper();
        Console.Write("Podaj temperaturę: ");
        double temp = double.Parse(Console.ReadLine());

        switch (kierunek)
        {
            case "C":
                double f = temp * 1.8 + 32;
                Console.WriteLine($"{temp}°C = {f}°F");
                break;
            case "F":
                double c = (temp - 32) / 1.8;
                Console.WriteLine($"{temp}°F = {c:F2}°C");
                break;
            default:
                Console.WriteLine("Nieznany kierunek konwersji.");
                break;
        }
    }

    static void Zadanie3()
    {
        Console.Write("Podaj liczbę ocen: ");
        int n = int.Parse(Console.ReadLine());
        double suma = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ocena {i}: ");
            suma += double.Parse(Console.ReadLine());
        }

        double srednia = suma / n;
        string status = srednia >= 3.0 ? "Uczeń zdał." : "Uczeń nie zdał.";
        Console.WriteLine($"Średnia: {srednia:F2}  {status}");
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Kalkulator");
            Console.WriteLine("2. Konwerter temperatur");
            Console.WriteLine("3. Średnia ocen");
            Console.WriteLine("0. Wyjście");
            Console.Write("Wybierz zadanie: ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1": Zadanie1(); break;
                case "2": Zadanie2(); break;
                case "3": Zadanie3(); break;
                case "0": return;
                default: Console.WriteLine("Nieprawidłowy wybór."); break;
            }
        }
    }
}