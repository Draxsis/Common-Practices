import random 
import time

player = int(input('0 for Rock, 1 for Paper, 2 for Scissors : '))
time.sleep(1.0)

lst = ['rock', 'paper', 'scissor']
Player = lst[player]

print(f'your choice is {Player}')
time.sleep(1.0)

computer = random.choice(lst)
print(f'Computer choice is {computer}\n')

if Player == 'paper' and computer == 'rock':
    print('!!! You Won !!!')

if Player == computer:
    print('Draw')

elif Player == 'scissor' and computer == 'paper':
    print('!!! You Won !!!')

elif Player == 'rock' and computer == 'scissor':
    print('!!! You Won !!!')

else:
    print(f'!!! you loose !!!')

   


