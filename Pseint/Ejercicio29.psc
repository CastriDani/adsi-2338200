Proceso Ejercicio29
	//Dado un monto, calcular el descuento considerando que por encima de 100 el descuento es del 10%
	//y por debajo de 100, el descuento es del 2%.
	
	//Variables
	Definir monto Como entero;
	
	//Entradas
	Escribir 'Escriba el monto';
	leer monto;
	
	//salidas
	si monto>100 Entonces
		Escribir 'El descuento es del 10% : ' ,monto*0.10;
	SiNo
		Escribir 'El descuento es del 2% : ' ,monto*0.02;
	FinSi
FinProceso
