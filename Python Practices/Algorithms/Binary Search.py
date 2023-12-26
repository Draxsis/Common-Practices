# sorted array for testing binary search
array = [1, 4, 6, 10, 29, 33, 35, 37, 41, 44, 48, 49, 56, 78, 93, 94, 98, 99]   

def number(array, first_index, last_index, x):
    cnt = 0 # the static variable of count
    cnt += 1 # this is for counting the number of trys
    if last_index >= first_index: 
        provit = first_index + (last_index - first_index) // 2 # we are trying to take AVG for provit and use (-) indexing to counting
        if array[provit] == x: # if the provit was the exact number that we want 
            return provit

        if array[provit] > x: # if the provit was bigger than our number do ...
            return number(array, first_index, provit - 1, x) # return to main function and this time the last index is -1 

        return number(array, provit + 1, last_index, x) # return is also use here for else and said if the provit was smaller than x 
    print('not Found!')
    return -1 # it means if the array length is 1, cuase it just has 1 provit 

print(number(array, 0, 17, 41)) 