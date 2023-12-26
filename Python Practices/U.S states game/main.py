import pandas 
import turtle

data = pandas.read_csv("50_states.csv")
states = data.state.to_list()

screen = turtle.Screen()
screen.title("U.S States Game")

image = "blank_states_img.gif"
screen.addshape(image)
turtle.shape(image)

right_answers = []

score = 0
while len(right_answers) < 50:
    user_answer = screen.textinput(f'your score {score}/50', 'what is your guess ?').title()

    if user_answer == 'Exit':
        break  
    if user_answer in states:
        t = turtle.Turtle()
        t.hideturtle()
        t.penup()
        state_data = data[data.state == user_answer]
        t.goto(int(state_data.x), int(state_data.y))
        t.write(user_answer)
        right_answers.append(user_answer)
        score += 1
    else:
        loop_on = True

screen.exitonclick()

states_to_learn = [i for i in states if i not in right_answers]
# for i in states:
#     if i not in right_answers:
#         states_to_learn.append(i)
df = pandas.DataFrame(states_to_learn)
df.to_csv('learn.csv')