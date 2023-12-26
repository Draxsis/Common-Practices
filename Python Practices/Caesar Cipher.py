def main():
    letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g','h', 'i', 'j', 'k',
 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
    diraction = input('Type "encode" to encrypt, type "decode" to decrypt:\n')
    text = input('Type your massage :\n').lower()
    shift = int(input('Type the shift number: \n'))
    code = ""
    if diraction =='decode':
        shift *= -1
    for letter in text: 
        pos = letters.index(letter)
        new_pos = pos + shift
        new_letter = letters[new_pos]
        code += new_letter
    print(f'your massage {diraction}d and the result is : {code}')

main()
