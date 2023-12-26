for i in range(1,101):

    if i % 5 == 0 and i % 3 == 0:
        print('fuzzbuzz')
    elif i % 3 == 0:
        print('fuzz')
    elif i % 5 == 0:
        print('buzz')
    else:
        print(i)
