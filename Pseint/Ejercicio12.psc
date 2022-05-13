Proceso Ejercicio12
	//Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada y el número de
	//horas que trabajó. Se debe mostrar el nombre y el pago de la persona.
	
	//Variables
	Definir name_people Como Caracter;
	definir time_work_money Como Entero;
	definir hours_work Como Entero;
	Definir pay_total Como Entero;
	
	//Entradas
	Escribir "Write the name of people : ";
	leer name_people;
	escribir "Write work hours evalue : ";
	leer time_work_money;
	escribir "write hours worked : ";
	leer hours_work;
	
	//Operaciones
	pay_total = time_work_money * hours_work;
	
	//salidas
	Escribir "The name person is : " , name_people , " pay total : " , pay_total;
	
FinProceso
