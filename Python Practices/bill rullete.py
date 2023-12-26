import random

names = str(input('enter your names (example >> name, name) : '))
lst = names.split(',')
print(random.choice(lst))

# temp = len(lst)
# temp == random.randint(0, temp)
# print(lst[temp - 1])