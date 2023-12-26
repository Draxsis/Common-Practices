print("welcome to the tip calculator.")

total = float(input('what was the total bill? '))
tip = int(input("what percentage tip would you like to give? 10, 12, or 15? "))
split = int(input("How many people to slpite the bill? "))

result = round((((tip / 100) * total) + total) / split, 2)
bill = "{:.2f}".format(result)

print(f"Each person should pay: ${bill}")