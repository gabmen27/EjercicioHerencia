

using EjercicioHerencia;

Calculadora calculadora = new Calculadora();

Console.WriteLine("Calculado Area, Longitud y Volumen de un cubo");
Console.WriteLine("Ingrese el radio del circulo");
calculadora.Radio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese la Long de uno de los lados del cubo");
calculadora.Lado = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("****************************************************");

calculadora.imprimir();

Console.WriteLine("*****************************************************");
