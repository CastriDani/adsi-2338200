Proceso Ejercicio25
	//Pedir una nota de 0 a 5 y mostrarla de la forma: Insuficiente (0 - 2,9), Suficiente (3 - 4,5) y Bien (4,6
	//- 5)
	
	//Variables
	Definir nota Como Real;
	
	//entradas
	Escribir 'Digite la nota desde 0 - 5';
	leer nota;
	
	//salidas
	si nota>0 y nota<3 Entonces
		Escribir ,nota,' Su nota es insuficiente'; 
	SiNo
		si nota>2.9 y nota<4.6 Entonces
			Escribir ,nota, ' Su nota es suficiente';
		SiNo
			si nota>4.5 y nota<5.1 Entonces
				Escribir ,nota, ' Su nota es bien';
			Finsi
		FinSi
	FinSi	
FinProceso
