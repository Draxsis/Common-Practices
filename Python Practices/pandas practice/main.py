import pandas

Data = pandas.read_csv("Central_Park_Data.csv")

color = Data['Primary Fur Color']

gray_s = len(Data[color == 'Gray'])
black_s = len(Data[color == 'Black'])
Cinnamon_s = len(Data[color == 'Cinnamon'])

data_frame = {

    'color' : ['gray', 'black', 'red'],
    'count' : [gray_s, black_s, Cinnamon_s]
}

df = pandas.DataFrame(data_frame)
df.to_csv('colors.csv')
