class car:
    def __init__(self, name, model, fuel, price):
        self.name = name
        self.model = model
        self.fuel = fuel
        self.price = price

bmw = car('BMW', 'I8', 60, '60K')

print(bmw.price)