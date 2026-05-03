Algoritmo Act2_Lecc9_inciso1
	Definir monedas, total Como Real
	total = 0
	Escribir "***********Nivel 5 Bloqueado*************"
	Mientras total < 350 Hacer
		Escribir "moendas actuales: ",total
		Escribir "Ingrese monedas ganadas: "
		Leer monedas
		total = total + monedas
	Fin Mientras
	Escribir "Has desbloqueado el nivel 5 con: ",total "monedas"
FinAlgoritmo
