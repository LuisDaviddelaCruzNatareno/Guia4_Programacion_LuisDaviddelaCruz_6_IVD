Algoritmo Act2_Lecc10_inciso1
	Definir num, factorial, i Como Real
	Escribir "Ingrese un numero para factorial: "
	Leer num
	i = num
	factorial = 1
	Repetir
		factorial = factorial * i
		i = i - 1
	Hasta Que i = 0
	Escribir "El factorial es: ", factorial
FinAlgoritmo
