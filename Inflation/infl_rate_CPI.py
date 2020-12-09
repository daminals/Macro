# infl_rate_CPI.py

a = int(input("Current CPI: "))
b = int(input("Last Year CPI: "))

c = (a-b)/b
c*=100
d = input(f'Inflation Rate: {c}')
