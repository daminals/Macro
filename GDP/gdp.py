# gdp.py

print("Remember, illegal activities, government transfer payments (social security, welfare,  etc.) sale of used goods, financial payments (bonds, stocks) are not counted in GDP")
items_num = int(input("Number of Items: "))
gdp_item_quantity = []
gdp_item_price = []
for i in range(1,items_num+1):
    quantity = int(input(f"Quantity of item {i}: "))
    gdp_item_quantity.append(quantity)
    quantity = float(input(f"Price of item {i}: "))
    gdp_item_price.append(quantity)

gdp = 0
for i in range(len(gdp_item_quantity)):
    gdp += (gdp_item_quantity[i] * gdp_item_price[i])

print("  ")
d = input(f"The GDP for this year is ${gdp}")
