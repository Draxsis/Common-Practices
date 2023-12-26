n = int(input('enter your number : '))

def prime_checker(number):
    is_prime = True
    for i in range(2, number):
        if number % i == 0:
            print("number is Prime!")
        else:
            print('number is not Prime!')

prime_checker(number=n)