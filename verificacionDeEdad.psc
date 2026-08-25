Algoritmo Verificar_MayorEdad
	Escribir " ingrese año actual:" 
	Leer anio_actual
	
	Escribir " ingrese su año de nacimiento:"
	leer anio_nacimiento
	
	edad = anio_actual - anio_nacimiento
	
	si edad >= 18 Entonces
		Escribir " el usuario es mayor de edad. edad :", edad  
		
	sino 
		
		Escribir " el usuario es menor de edad. Edad:", edad 
		
	FinSi
FinAlgoritmo
