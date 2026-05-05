Algoritmo Act3_Lecc9_inciso1
	Definir num, suma Como Real
	suma = 0
	Escribir "Ingrese un numero (0 para terminar): "
	Leer num
	Mientras num <> 0 Hacer
		suma = suma + num
		Escribir "Suma actual: ", suma
		Escribir "Ingrese otro numero: "
		Leer num
	Fin Mientras
	Escribir "Suma final: ", suma
FinAlgoritmo
