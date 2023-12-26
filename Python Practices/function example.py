import math

test_h = int(input('height : '))
test_w = int(input('Width : '))
coverage = int(input('how many? : '))

def paint_calc(h, w, c):
    x = math.ceil(h * w / c)
    print(x)

paint_calc(h=test_h, w=test_w, c=coverage)
