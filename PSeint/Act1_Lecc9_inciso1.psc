Algoritmo Act1_Lecc9_inciso1
	Definir pmanzana, ptotal Como Real
	Escribir "*********BÁSCULA DE MANZANAS para 1kg*************"
	Mientras ptotal < 1 Hacer
		Escribir "Coloque una manzana en la bascula, coloque su peso en kg(ej 0.2): "
		Leer pmanzana
		ptotal = ptotal+pmanzana
		Escribir "Peso en la bascula: ",ptotal, "kg"
	Fin Mientras
	Escribir "Ya hay 1 kg de manzana "
FinAlgoritmo
