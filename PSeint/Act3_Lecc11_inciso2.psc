Algoritmo Act3_Lecc11_inciso2
	Definir num, suma Como Entero
    suma = 0
    num = 0
    Escribir "Ingrese numeros para sumar (ingrese 9 para terminar):"
    Mientras num <> 9 Hacer
        Leer num
        Si num <> 9 Entonces
            suma = suma + num
        Fin Si
    Fin Mientras
    Escribir "La suma total es: ", suma
FinAlgoritmo
