import random 

letters = 'qwertyuiopasdfghjklzxcvbnm'
symbols = '~!@#$%^&*()_+'
numbers = '1234567890'

user_letter = int(input('How many letters would you like in your password? : \n')) # 4
user_symbol = int(input('How many letters would you like in your password? : \n')) # 2
user_numbers = int(input('How many letters would you like in your password? : \n')) # 2

password = ''
for i in range(0, user_letter):
    password += random.choice(letters)

for i in range(0, user_symbol):
    password += random.choice(symbols)

for i in range(0, user_numbers):
    password += random.choice(numbers)

print(f"this is your password {password}")


# Second Code

# import random

# def password_generator(number, len):

#     chars = ("qwertyuioplkjhgfdsazxcvbnm1234567890!@")

#     for i in range(number):
#         password = ""
#         for i in range(len):
#             password += random.choice(chars)
#         print(password)       

# password_generator() #you need to enter two arguments 
