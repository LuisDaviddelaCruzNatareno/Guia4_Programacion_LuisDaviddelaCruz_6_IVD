Algoritmo Act3_Lecc10_inciso1
	Definir num, i, divisores, suma_primos Como Entero
	suma_primos = 0
	Para num = 1 Hasta 22 Hacer
		divisores = 0
		Para i = 1 Hasta num Hacer
			Si num % i = 0 Entonces
				divisores = divisores + 1
			FinSi
		FinPara
		Si divisores = 2 Entonces
			Escribir "Primo encontrado: ", num
			suma_primos = suma_primos + num
		FinSi
	FinPara
	Escribir "La suma total es: ", suma_primos
FinAlgoritmo
