Proceso Ejercico06
	
	//Hacer un algoritmo que lea el nombre de un artículo, el valor unitario, la cantidad a comprar y muestre
	//el nombre y el total a pagar.
	
	//Variables
	Definir name_article Como Caracter;
	Definir unit_value Como Entero;
	definir amount_pay Como Entero;
	definir total_pay Como Entero;
	
	//Entradas
	Escribir " Enter the name of the article : ";
	leer name_article;
	escribir " Enter the unit value : ";
	leer unit_value;
	Escribir " Enter quantity to buy : ";
	leer amount_pay;
	
	//Operaciones
	total_pay = unit_value * amount_pay;
	
	//Salida
	Escribir " The product name is : " , name_article , " your total to pay is : " , total_pay;
FinProceso
