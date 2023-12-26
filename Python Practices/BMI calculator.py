Height = float(input("please enter your Hight : "))
Weight =float(input("please enter your waight : "))

result = int(Weight // Height ** 2)

if result < 18:
    print("your BMI is low " + str(result))
elif result > 27:
    print("your BMI is too hight " + str(result))
else:
    print("your BMI is normal " + str(result))