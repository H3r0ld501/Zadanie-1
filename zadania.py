def zadanie1():
    a = float(input("Podaj pierwszą liczbę: "))
    b = float(input("Podaj drugą liczbę: "))
    op = input("Podaj operację (+, -, *, /): ")
    if op == "+":
        print(f"Wynik: {a + b}")
    elif op == "-":
        print(f"Wynik: {a - b}")
    elif op == "*":
        print(f"Wynik: {a * b}")
    elif op == "/":
        if b != 0:
            print(f"Wynik: {a / b}")
        else:
            print("Błąd: dzielenie przez zero.")
    else:
        print("Nieznana operacja.")


def zadanie2():
    kierunek = input("Podaj kierunek konwersji (C = Celsjusz→Fahrenheit, F = Fahrenheit→Celsjusz): ").upper()
    temp = float(input("Podaj temperaturę: "))
    if kierunek == "C":
        wynik = temp * 1.8 + 32
        print(f"{temp}°C = {wynik}°F")
    elif kierunek == "F":
        wynik = (temp - 32) / 1.8
        print(f"{temp}°F = {wynik:.2f}°C")
    else:
        print("Nieznany kierunek konwersji.")


def zadanie3():
    n = int(input("Podaj liczbę ocen: "))
    suma = 0
    for i in range(n):
        ocena = float(input(f"Ocena {i + 1}: "))
        suma += ocena
    srednia = suma / n
    status = "Uczeń zdał." if srednia >= 3.0 else "Uczeń nie zdał."
    print(f"Średnia: {srednia:.2f}  {status}")


def menu():
    while True:
        print("\n=== MENU ===")
        print("1. Kalkulator")
        print("2. Konwerter temperatur")
        print("3. Średnia ocen")
        print("0. Wyjście")
        wybor = input("Wybierz zadanie: ")
        if wybor == "1":
            zadanie1()
        elif wybor == "2":
            zadanie2()
        elif wybor == "3":
            zadanie3()
        elif wybor == "0":
            break
        else:
            print("Nieprawidłowy wybór.")


menu()
