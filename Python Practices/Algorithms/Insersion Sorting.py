# Insertion sort in Python

def insertion_sort(array):
    for i in range(1, len(array)): # Loop from the second element of the array until the last element

        key_item = array[i] # This is the element we want to position in its correct place

        # Initialize the variable that will be used to
        # find the correct position of the element referenced
        # by `key_item`
        j = i - 1

        # Run through the list of items (the left
        # portion of the array) and find the correct position
        # of the element referenced by `key_item`. Do this only
        # if `key_item` is smaller than its adjacent values.
        while j >= 0 and array[j] > key_item:
            # Shift the value one position to the left
            # and reposition j to point to the next element
            # (from right to left)
            array[j + 1] = array[j]
            j -= 1

        # When you finish shifting the elements, you can position
        # `key_item` in its correct location
        array[j + 1] = key_item

    return array

data = [1, 4, 6, 10, 29, 33, 35, 37, 2, 44, 48, 49, 56, 78, 93, 94, 98, 99]   
insertion_sort(data)
print(data)
