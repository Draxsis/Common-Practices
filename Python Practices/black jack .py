import random 
import time
from replit import clear

print('welcome to Mostafa black jack!\n')
time.sleep(2)

cards = {
    "1": 1,
    "2": 2,
    "3": 3,
    "4": 4,
    "5": 5,
    "6": 6,
    "7": 7,
    "8": 8,
    "9": 9,
    "10": 10,
    "K": 10,
    "Q": 10,
    "J": 10
}


def main():

    player_cards = []
    dealer_cards = []
    player_card_count = 0
    player_card_sum = 0
    dealer_choice = ['yes', 'no']
    dealer_card_sum = 0

    for i in range(0, 2): # Player First to cards 
        player_cards.append(random.choice(list(cards.values())))
        player_card_count += 1
    for i in player_cards:
        player_card_sum += i
    print(f'you have {player_card_count} cards now.') 
    print(f'your Cards are {player_cards} ---> {player_card_sum}.')
    time.sleep(1)

    dealer_card_sum = 0
    for i in range(0, 2): # Dealer First to cards 
        dealer_cards.append(random.choice(list(cards.values())))
    for i in dealer_cards:
        dealer_card_sum += i
    print(f'dealer first card is {dealer_cards[0]}')
    time.sleep(1)

    end_of_loop= False
    while not end_of_loop:

        # Add one card
        add_card = input('type hit or stand to continue : ').lower()
        dealer_add_card = random.choice(dealer_choice)
        if add_card == 'hit': 
            player_cards.append(random.choice(list(cards.values()))) 
            player_card_count += 1
            player_card_sum = 0
            for i in player_cards:
                player_card_sum += i

            # Over 21 and Fold
            if player_card_sum > 21: 
                print(f'you lose and your cards {player_cards} is {player_card_sum}')
                restart()
                break

            # 21 Black Jacked
            elif player_card_sum == 21: 
                print(f'you got Black Jacked! {player_card_sum}')
                restart()
                break
            
            # Continue to other hit
            elif player_card_sum < 21:
                print(f'you have {player_card_count} cards now.') 
                time.sleep(1)
                print(f'your Cards are {player_cards} ---> {player_card_sum}.') 
                end_of_loop = False
                
        if dealer_card_sum < 16:
            dealer_cards.append(random.choice(list(cards.values()))) 
            dealer_card_sum = 0
            for i in dealer_cards:
                dealer_card_sum += i

            if dealer_card_sum == 21: 
                print(f'Dealer got Black Jacked! {player_card_sum}')
                restart()
                break
                
            elif dealer_card_sum > 21:
                print(f'you lose and your cards {player_cards} is {player_card_sum}')
            
        if add_card == 'stand':

            if player_card_sum <= dealer_card_sum: # Continue to other hit   
                print(f'your Cards are {player_cards} ---> {player_card_sum}.')
                time.sleep(1)
                print(f'Dealer cards are {dealer_cards} ---> {dealer_card_sum}.')
                time.sleep(3)
                clear()
                print('the winner is Dealer.')
                restart()
                break

            elif  player_card_sum > dealer_card_sum:
                print(f'your Cards are {player_cards} ---> {player_card_sum}.')
                time.sleep(1)
                print(f'Dealer cards are {dealer_cards} ---> {dealer_card_sum}.')
                time.sleep(3)
                clear()
                print('the winner is Player.')
                restart()
                break
        

    player_cards = []
    dealer_cards = []
    player_card_count = 0
    player_card_sum = 0

def restart():
    play_again = input('yes to play again, no for exit : ').lower()
    if play_again == 'yes':
        clear()
        return main()
    elif play_again == 'no': 
        clear()
        print('Good buy and have a nice day!')

main()
