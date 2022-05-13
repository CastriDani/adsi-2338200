Proceso Ejercicio24
	//Pedir un número entre 0 y 9.999 y decir cuántas cifras tiene.
	
	//variables
	Definir num Como Entero;
	
	//Entradas
	Escribir 'Escriba un nuemero entre el 0 y el 9999 ';
	Leer num;
	
	//salidas
	si (num < 0)Entonces
		Escribir "El numero es negativo";
	SiNo
		si (num>9 y num<100) Entonces
			Escribir ,num, ' Tiene dos cifras';
		SiNo
			si (num>99 y num<1000) Entonces
				Escribir ,num, ' Tiene tres cifras';
			sino
				si (num>999 y num<10000) Entonces
					Escribir ,num, ' Tiene cuatro cifras';
				SiNo
					Escribir 'Este numero tiene 5 o mas cifras';
				FinSi
			FinSi
		FinSi
	FinSi
FinProceso
