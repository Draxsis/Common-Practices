student_scores = {
    'harry': 81,
    'Ron':78,
    'Bob':99,
    'Draco':74,
    'Neville':62,
}

student_grades = {}
for student in student_scores:
    score = student_scores[student]
    if score > 90:
        student_grades[score] = 'exellent'
    elif score > 80:
        student_grades[score] = 'very good'
    elif score > 70:
        student_grades[score] = 'good'
    else:
        student_grades[score] = 'faild'

print(student_grades)