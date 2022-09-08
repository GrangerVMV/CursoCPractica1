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

var edadPersona = 50; //Declaración implícita de la variable, el programa elige el tipo de variable, pero una vez lo define ya no se le puede cambiar el tipo
                      // edadPersona = 50.5; // Esto daría error por intentar asociar un valor decimal cuando el programa la ha definido como int
Console.WriteLine($"Juan tiene {edadPersona} años");

double temperatura = 34.8;
int temperaturaSevilla;
temperaturaSevilla = (int)temperatura;  // Conversión explícita o casting (no redondea, desecha la parte decimal)
Console.WriteLine($"La temperatura en Sevilla es de {temperaturaSevilla} grados");

int numHabitantes = 1000000;
long numHabitantesSevilla2018;
numHabitantesSevilla2018 = numHabitantes;
Console.WriteLine($"El número de habitantes en Sevilla en 2018 es de {numHabitantesSevilla2018} de personas"); /*Esto es una conversión implícita
                                                                                                                       * mismo tipo de datos, distinto numero de bits*/

float pesoMaterial = 5.78F;
double pesoMaterialPrec = pesoMaterial;
Console.WriteLine($"El peso del material es de {pesoMaterialPrec} gramos"); // Otra conversión implícita. OJO al uso del sufijo F

int temperatura2 = 34;
double temperaturaSevilla2;
temperaturaSevilla2 = temperatura2;  // Otra conversión implícita
Console.WriteLine($"La temperatura en Sevilla es de {temperaturaSevilla} grados");


Console.WriteLine("Introduzca el primer sumando");
int num1 = int.Parse(Console.ReadLine()); // Conversión de tipos: pasa de un texto (ReadLine) a un número entero
Console.WriteLine("Introduzca el segundo sumando");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"La suma de {num1} y {num2} es {num1 + num2}");

const int VALOR = 5; // La constante se declara en MAYUSCULAS y se inicializa en la misma línea
const int VALOR2 = 7;
Console.WriteLine("El valor de la constante es {0}", VALOR); // Se usa el atajo CW+TAB+TAB para escribir Console.WriteLine y se pasa el VALOR de la constante como parámetro
Console.WriteLine("El valor de la segunda constante es {1}", VALOR, VALOR2);

const double PI = 3.1416; // Usamos PI como cte para calcular el área de un círculo
Console.WriteLine("Introduzca el valor del radio");
double radio = double.Parse(Console.ReadLine());
//Console.WriteLine($"El área del círculo es {radio*radio*pi}");
Console.WriteLine($"El área del círculo es {Math.Pow(radio, 2) * PI}"); //Usamos Math.Pow pa