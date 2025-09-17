import math


def ejer1():
    edad =int(input("Ingrese su edad: "))
    if edad<18:
        print("Menor de edad.")
    else:
        if edad<= 64:
            print("Adulto.")
        else:
            print ("Adulto Mayor")


def ejer2():
    an=int(input("Ingrese el año: "))

    if (an % 4 == 0 and an % 100 != 0) or an % 400==0:
        print("El año es bisiesto")
    else:
        print("El año no es bisiesto")

    if(an % 2 == 0):
        print("El año es par")
    else:
        print("El año es inpar")

def ejer3():
    monto=float(input("Ingrese monto en soles: "))

    print("\n1. Dolares\n2. Euros")

    opción =int (input("Ingrese una opción: "))

    print() #es un salto pero para todo esto de abajo
    match opción:
        case 1:print("Dolares: ", round((monto/3.75),2))
        case 2:print("Euro: ", monto/4.05)
        case _:print("Opción incorecta!")
            

def ejer4():
    print("Bienvenidos al programa de desarrollo de áreas\n")

    print("1.cuadrado")
    print("2.Rectangulo")
    print("3.triangulo")
    print("4.circulo\n")

    opcion=int(input("Ingrese una opción: "))

    match opcion:
        case 1:
            lado= int(input("Ingrese lado: "))
            print("Área del cuadrado: ", lado*lado)
        case 2:
            bse=int(input("Ingrese la base: "))
            alt=int(input("Ingrese la altura: "))
            print("Área de rectangulo: ", bse* alt)
        case 3:
            bse2=int(input("Ingrese la base: "))
            alt2=int(input("Ingrese la altura: "))
            print("Área de rectangulo: ", (bse2* alt2)/2)
        case 4:
            radio=float(input("Ingrese la radio: "))
            print("Área del circulo: ", (round (math.pi*radio**2),2))
        case _:print("Opción incorrecta!")




ejer4()                                                                           