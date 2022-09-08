// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenidos al curso de C#");  /*Esto imprime un mensaje en consola*/
/* Prueba Comentario 1
 * Prueba comentario 2
 * Prueba comentario 3 */

int edad = 28;
//edad=edad+1;
edad = ++edad; /* uso del operador ++: si ponemos edad++ incrementa la variable, si ponemos edad=edad++ no la incrementa
            si invertimos el orden (edad=++edad) sí se incrementa la variable*/
int edad2 = 13;
Console.WriteLine(edad);
Console.WriteLine(7 * 5);//uso de operados * para multiplicar
float numerador = 5;
int denominador = 2;
Console.WriteLine(numerador / denominador); // el resultado es float porque numerador o denominador lo son
Console.WriteLine("El resultado de dividir 5 entre 2 es " + 5.0 / 2.0); // para que el resultado sea decimal hay que expresar numerador o denominador como decimal
Console.WriteLine("El resto de dividir 5 entre 2 es " + 5 % 2);// operador residuo %
Console.WriteLine("Tienes una edad de " + (edad + 1) + " años");// (edad+1) incrementa en 1 la variable, edad+1 concatena un 1 al valor de la variable
edad = edad + 8; // incrementar una variable

Console.WriteLine("Tienes una edad de " + edad + " años");// uso de operador + para concatenar
Console.WriteLine($"Ella tiene {edad2 + 2} años"); //uso de $ y {} para concatenar string y variables (interpolación)
edad -= 2; //uso de operado -= para decremento
Console.WriteLine("Tienes una edad de " + edad + " años");//operador + para concatenar

int edadPersona1; //declaración explícita de variables una a una
int edadPersona2;
int edadPersona3;
int edadPersona4;
edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 25; //declaración explícita de variables conjuntamente
Console.WriteLine($"Todas las personas del grupo tienen {edadPersona3} años");
/*int edadPersona1, edadPersona2, edadPersona3, edadPersona4 = 5; //declaración explícita de variables conjuntamente, solo asigna valor a la última
Console.WriteLine($"Todas las personas del grupo tienen { edadPersona4} años");*/