from typing import OrderedDict


print('Welcome to Python Pizza Delivery service !')

size = input('Small, Medium, Large? ')
add_peperoni = input('add_peperoni  Yes, No? ')
extra_cheese = input('extra_cheese  Yes, No? ')

S_pizza = 15
M_pizza = 20
L_pizza = 25

peperoni_price_S = 2
peperoni_price_ML = 3
cheese_price = 1

Order = 0
if size == "S":
    Order += S_pizza
    if add_peperoni == "Y":
        Order += peperoni_price_S
        if extra_cheese == "Y":
            Order += cheese_price
        else:
            Order == Order

    else:
        Order == Order
elif size == "M":
    Order += M_pizza
    if add_peperoni == "Y":
        Order += peperoni_price_ML
        if extra_cheese == "Y":
            Order += cheese_price
        else:
            Order == Order
    else:
        Order == Order
elif size == "L":
    Order += L_pizza
    if add_peperoni == "Y":
        Order += peperoni_price_ML
        if extra_cheese == "Y":
            Order += cheese_price
        else:
            Order == Order
    else:
        Order == Order
else:
    breakpoint

print(f"your Bill is ${Order}")