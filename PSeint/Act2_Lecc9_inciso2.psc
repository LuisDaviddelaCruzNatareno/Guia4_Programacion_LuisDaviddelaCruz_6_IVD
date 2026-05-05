Algoritmo Act2_Lecc9_inciso2
	Definir num, contador Como Real
	Escribir "Ingrese el numero limite: "
	Leer num
	contador = 20
	Mientras contador <= num Hacer
		Si contador % 2 <> 0 Entonces
			Escribir "Impar encontrado: ", contador
		Fin Si
		contador = contador + 1
	Fin Mientras
FinAlgoritmo
