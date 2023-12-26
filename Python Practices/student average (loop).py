student_heights = [180, 124, 165, 173, 189, 169, 146]
student_sum = 0

count = 0
for height in student_heights:
    student_sum += height
    count += 1

student_average = round(student_sum / count)

print(student_average)