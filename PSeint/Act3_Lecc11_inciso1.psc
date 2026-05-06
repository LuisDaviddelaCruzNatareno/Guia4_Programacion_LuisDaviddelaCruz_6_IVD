Algoritmo Act3_Lecc11_inciso1
	Definir i, j, suma, divisores Como Entero
    suma = 0
    Para i = 1 Hasta 22 Hacer
        divisores = 0
        Para j = 1 Hasta i Hacer
            Si i % j = 0 Entonces
                divisores = divisores + 1
            Fin Si
        Fin Para
        Si divisores = 2 Entonces
            suma = suma + i
        Fin Si
    Fin Para
    Escribir "La suma de los numeros primos del 1 al 22 es: ", suma
FinAlgoritmo
