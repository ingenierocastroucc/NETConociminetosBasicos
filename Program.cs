/****************************************************************************************************
 * Prueba tecnica certificacion platzi                                                       
 ****************************************************************************************************
 * Unidad        : <.NET conocimienots basicos>                                                                      
 * DescripciÓn   : <Logica de negocio para capturar e imprimir informacion>                                                      
 * Autor         : <Pedro Castro>
 * Fecha         : <04-05-2024>                                                                             
 ***************************************************************************************************/
using Humanizer;

//Propiedad que captura el nombre
Console.WriteLine("Ingrese su nombre:");
var nombre = Console.ReadLine();
//Propiedad que captura el cargo
Console.WriteLine("Ingrese su cargo:");
var cargo = Console.ReadLine();
//Propiedad que captura la edad
Console.WriteLine("Ingrese su edad:");
var edad = int.Parse(Console.ReadLine());
//Propiedad que captura el salario
Console.WriteLine("Ingrese su salario mensual:");
var salario = int.Parse(Console.ReadLine());

//Imprime en pantalla los datos
Console.WriteLine("Nombre:" + " " + nombre + " " + "Cargo:" + " " + cargo + " " + "Edad:" + " " 
+ edad.ToWords(new System.Globalization.CultureInfo("es")) +" " +"Salario anual:" + salario * 12);
