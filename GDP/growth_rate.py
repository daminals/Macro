#inflation_rate.py

a = int(input("Real GDP Year 1: "))
b = int(input("Real GDP Year 2: "))

c = (a-b)/b
c*=100
d = input(f"Growth Rate: {c}")