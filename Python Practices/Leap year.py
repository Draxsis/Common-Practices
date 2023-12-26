year = int(input('Enter the year you wanna check : '))


if year % 4 == 0:
    if year % 100 == 0:
        if year % 400 == 0:
            print('Leap')
        else:
            print('not leap')
    else:
        print('Leap')
else:
    print('not Leap')