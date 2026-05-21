n = int(input("Podaj liczbę ocen: "))
suma = 0

for i in range(n):
    suma += float(input(f"Ocena {i + 1}: "))

srednia = suma / n
print(f"Średnia: {srednia:.2f}  {'Uczeń zdał.' if srednia >= 3.0 else 'Uczeń nie zdał.'}")

input("Naciśnij Enter aby zakończyć...")
