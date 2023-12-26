import random 

def check_answer():
    level = input('you wanna play easy or hard ? : ')
    if level == 'easy':
        life = 10
    elif level == 'hard':
        life = 5

    number = random.randint(1,100)

    end_of_game = False
    while not end_of_game:

        guess = int(input(f'guess the number please, your lifes are {life}: '))
        if guess > number:
            print('too High')
            life -= 1
        elif guess < number:
            print('too Low')
            life -= 1
        elif guess == number:
            print(f'you guess Right! the number is {number}')
            break
        
        if life == 0:
            print('you loose and run out of lifes !')
            break

check_answer()