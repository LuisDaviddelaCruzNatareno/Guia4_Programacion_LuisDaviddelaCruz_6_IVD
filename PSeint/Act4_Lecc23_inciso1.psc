Algoritmo Act4_Lecc23_inciso1
	Definir num, mayor, menor Como Real
	Escribir "Ingrese un numero (negativo para terminar): "
	Leer num
	
	Si num >= 0 Entonces
		mayor = num
		menor = num
		Mientras num >= 0 Hacer
			Si num > mayor Entonces
				mayor = num
			Fin Si
			Si num < menor Entonces
				menor = num
			Fin Si
			Escribir "Ingrese otro numero: "
			Leer num
		Fin Mientras
		Escribir "El numero mayor es: ", mayor
		Escribir "El numero menor es: ", menor
	Sino
		Escribir "No se ingresaron numeros validos."
	Fin Si
FinAlgoritmo
