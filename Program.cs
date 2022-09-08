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