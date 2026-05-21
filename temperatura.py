kierunek = input("Kierunek konwersji (C = Celsjusz→Fahrenheit, F = Fahrenheit→Celsjusz): ").upper()
temp = float(input("Podaj temperaturę: "))

if kierunek == "C":
    print(f"{temp}°C = {temp * 1.8 + 32}°F")
elif kierunek == "F":
    print(f"{temp}°F = {(temp - 32) / 1.8:.2f}°C")
else:
    print("Nieznany kierunek konwersji.")

input("Naciśnij Enter aby zakończyć...")
