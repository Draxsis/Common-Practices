first_num = float(input('what is the first number? : '))

print('+\n -\n *\n /\n')

u_operation = str(input('pick an operation : '))
second_num = float(input('what os the second number? : '))

def add(first_num, second_num):
    return first_num + second_num

def multiply(first_num, second_num):
    return first_num * second_num

def divide(first_num, second_num):
    return first_num / second_num

def subtract(first_num, second_num):
    return first_num - second_num

operation = {
    '+': add,
    '-': subtract,
    '*': multiply,
    '/': divide
}

func = operation[u_operation]
answer = func(first_num, second_num)

print(f'{first_num} {u_operation} {second_num} = {answer}')