Algoritmo Act2_Lecc15_inciso2
	Definir num, i, suma Como Real
	Escribir "Ingrese el numero limite: "
	Leer num
	suma = 0
	Para i = 1 Hasta num Hacer
		Si i % 3 = 0 o i % 5 = 0 Entonces
			suma = suma + i
			Escribir "Multiplo encontrado: ", i
		Fin Si
	Fin Para
	Escribir "La suma total de los multiplos es: ", suma
FinAlgoritmo
