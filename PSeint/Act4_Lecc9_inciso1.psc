Algoritmo Act4_Lecc9_inciso1
	Definir num, i, divisores Como Real
	Escribir "Ingrese un numero: "
	Leer num
	i = 1
	divisores = 0
	Mientras i <= num Hacer
		Si num % i = 0 Entonces
			divisores = divisores + 1
		FinSi
		i = i + 1
	Fin Mientras
	Si divisores = 2 Entonces
		Escribir "Es PRIMO"
	Sino
		Escribir "NO es primo"
	FinSi
FinAlgoritmo
