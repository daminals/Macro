#gdp_deflator.py

a = int( input("Nominal GDP: "))
b = int(input("Real GDP: "))

c = a/b
c *= 100

d = input(f"GDP Deflator: {c}")