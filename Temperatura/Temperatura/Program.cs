using System;

class Zadanie2
{
    static void Main()
    {
        Console.Write("Kierunek konwersji (C = Celsjusz→Fahrenheit, F = Fahrenheit→Celsjusz): ");
        string kierunek = Console.ReadLine().ToUpper();
        Console.Write("Podaj temperaturę: ");
        double temp = double.Parse(Console.ReadLine());

        switch (kierunek)
        {
            case "C":
                Console.WriteLine($"{temp}°C = {temp * 1.8 + 32}°F");
                break;
            case "F":
                Console.WriteLine($"{temp}°F = {(temp - 32) / 1.8:F2}°C");
                break;
            default:
                Console.WriteLine("Nieznany kierunek konwersji.");
                break;
        }
        Console.ReadKey();
    }
}
