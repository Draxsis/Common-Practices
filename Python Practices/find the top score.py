student_score = [78, 65, 89, 86, 88, 91, 64, 89]

temp = 0
for score in student_score:
    if temp < score:
        temp = score

print(f'the Highest number is the list is {temp}')
