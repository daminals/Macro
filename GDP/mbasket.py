# mbasket.py

print("Remember, if you're calculating the base basket, you have to use base year prices")

items_num = int(input("Number of Items: "))
mbasket_item_quantity = []
mbasket_item_price = []
for i in range(1,items_num+1):
    quantity = int(input(f"Quantity of item {i}: "))
    mbasket_item_quantity.append(quantity)
    quantity = int(input(f"Price of item {i}: "))
    mbasket_item_price.append(quantity)

gdp = 0
for i in range(len(mbasket_item_quantity)):
    gdp += (mbasket_item_quantity[i] * mbasket_item_price[i])

print("  ")
d = input(f"The Market Basket for this year is ${gdp}")