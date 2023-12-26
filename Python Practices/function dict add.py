travel_log = [
{
    'country': 'France',
    'visits': 12,
    'cities': ['paris, lille, Dijon'] 
},
{
    'country': 'Germany',
    'visits': 5,
    'cities': ['Berlin', 'Humburg']   
}
]

def add_new_country(country, visitedtimes, cities):
    temp = {
        'country':country,
        'visits': visitedtimes,
        'cities': cities,
    }
    travel_log.append(temp)

add_new_country('Russia', 2, ['Moscow', 'Others'])
print(travel_log)