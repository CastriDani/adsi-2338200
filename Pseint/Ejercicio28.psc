Proceso Ejercicio28
	//Un trabajador recibe su pago, según la cantidad de horas trabajadas y su valor. Si la cantidad de
	//horas trabajadas es mayor que 40, éstas se consideran horas extra, y tienen un incremento de $10000
	//(diez mil) sobre el valor de la hora. Calcular y mostrar el salario (pago) del trabajador. Nota: leer horas
	//trabajadas y valor de la hora.
	
	//variables
	Definir cant_horas_trabajadas Como Entero;
	Definir valor_hora_paga Como Real;
	Definir pago_total Como Real;
	Definir pago_horas_extras Como Entero;
	Definir horas_extras_trabajadas Como Entero;
	
	//Entradas
	Escribir 'Ingrese cuantas horas trabajo';
	leer cant_horas_trabajadas;
	Escribir 'Escriba el valor por hora trabajada';
	leer valor_hora_paga;
	
	//Proceso 
	pago_total = cant_horas_trabajadas*valor_hora_paga;
	horas_extras_trabajadas=0;
	//salidas
	si (cant_horas_trabajadas > 40) Entonces
		horas_extras_trabajadas = cant_horas_trabajadas-40;
		pago_horas_extras = 10000*horas_extras_trabajadas;
		pago_total= pago_total+pago_horas_extras;
	FinSi
	Escribir 'su pago es ', pago_total;
	Escribir 'Horas extras realizadas ' , horas_extras_trabajadas;
FinProceso
