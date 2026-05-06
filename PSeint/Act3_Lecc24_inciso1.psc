Algoritmo Act3_Lecc24_inciso1
	Definir pin, intentos Como Entero
	intentos = 1
	Escribir "--- CAJERO AUTOMATICO ---"
	Repetir
		Escribir "Ingrese su PIN (Intento ", intentos, "/3): "
		Leer pin
		Si pin = 1234 Entonces
			Escribir "Acceso concedido. Bienvenido."
			intentos = 5 // Forzamos salida del ciclo
		Sino
			Escribir "PIN incorrecto."
			intentos = intentos + 1
		Fin Si
	Hasta Que intentos > 3
	Si intentos = 4 Entonces
		Escribir "Tarjeta bloqueada por seguridad."
	Fin Si
FinAlgoritmo
