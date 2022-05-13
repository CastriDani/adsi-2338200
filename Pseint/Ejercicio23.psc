Proceso Ejercicio23
	// Pedir  tres  n ú meros  y  mostrarlos  ordenados  de  mayor  a  menor .
	Definir  num1 Como Real ;
	Definir  num2 Como Real ;
	Definir  num3 como real ;
	
	// Entrada
	Escribir  "Escriba el numero 1" ;
	Leer  num1 ;
	Escribir  "Escriba el numero 2" ;
	Leer  num2 ;
	Escribir  "Escriba el numero 3" ;
	Leer  num3 ;
	
	// Salida
	
	si (num1 == num2) y (num2 ==num3) Entonces
		Escribir "Los 3 numeros son iguales";
	SiNo
		Si  num1 > num2 y num2> num3 Entonces
			Escribir  "El orden de mayor a menor es " , num1 , "-" , num2 , "-" , num3 ;
		sino
			Si  num2 > num1 y num1> num3 Entonces
				Escribir  "El orden de mayor a menor es " , num2 , "-" , num1 , "-" , num3 ;
			SiNo
				Si  num3 > num1 y num1> num2 Entonces
					Escribir  "El orden de mayor a menor es " , num3 , "-" , num1 , "-" , num2 ;
				SiNo
					Si  num1 > num3 y num3> num2 Entonces
						Escribir  "El orden de mayor a menor es " , num1 , "-" , num3 , "-" , num2 ;
					SiNo
						Si  num3 > num2 y num2> num1 Entonces
							Escribir  "El orden de mayor a menor es " , num3 , "-" , num2 , "-" , num1 ;
						SiNo
							Si num2 > num3 y num3 > num1 Entonces
								Escribir "El orden de mayor a menor es " ,num2, "-" ,num3, "-" ,num1;
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi	
FinProceso
