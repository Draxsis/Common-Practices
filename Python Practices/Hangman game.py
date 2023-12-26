import random

print('''
 _                                             
| |                                            
| |__   __ _ _ __   __ _ _ __ ___   __ _ _ __  
| '_ \ / _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
|_| |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/                       
''')

list_of_words = ['mouse', 'beer', 'bear', 'car', 'watermelon', 'honey', 'phone']
generated_word = random.choice(list_of_words)

display = []
for i in range (len(generated_word)):
    display += '_'

print(f"the Generated word is : {' '.join(display)}\n")

end_of_game = False
life = 6
while not end_of_game:
    user_guess = str(input('Guess a letter : ')).lower()
    for pos in range(len(generated_word)):
        letter = generated_word[pos]
        if letter == user_guess:
            display[pos] = letter

    print(f"{' '.join(display)}")

    if "_" not in display: 
        print('You won!')
        end_of_game == True
    
    elif user_guess not in generated_word:
        life -= 1
        print(f'your life : {life}')  
        if life == 0:
            print('you loose!')
            end_of_game == True
