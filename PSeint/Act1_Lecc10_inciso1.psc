Algoritmo Act1_Lecc10_inciso1
	Definir carros Como Real
	autos = 200
	Repetir
		Escribir "Cajones disponibles: ", carros
		Escribir "Presione 1 para ingresar auto: "
		Leer ingreso
		carros = carros - 1
	Hasta Que carros = 0
	Escribir "Ya no hay cajones libres"
FinAlgoritmo
