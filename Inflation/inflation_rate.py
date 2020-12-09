# inflation_rate.py

a = int(input("Nominal GDP Year 1: "))
b = int(input("Nominal GDP Year 2: "))

c = (a-b)/b
c*=100
d = input(f'Inflation Rate: {c}')
