Algoritmo Act3_Lecc15_inciso1
	Definir n1, n2, suma, i, aux Como Entero
    Escribir "Ingrese primer numero:"
    Leer n1
    Escribir "Ingrese segundo numero:"
    Leer n2
    
    Si n1 > n2 Entonces
        aux = n1
        n1 = n2
        n2 = aux
    Fin Si
    
    suma = 0
    Para i = n1 Hasta n2 Hacer
        suma = suma + i
    Fin Para
    Escribir "La suma de los valores entre ambos es: ", suma
FinAlgoritmo
