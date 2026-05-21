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

input("Naciśnij Enter aby zakończyć...")
