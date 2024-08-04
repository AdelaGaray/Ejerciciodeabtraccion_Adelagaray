// Ahora ejecutaremos el main principal para definir los metodos y operaciones matematicas//
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase derivada
        OperacionesMatematicas operaciones = new OperacionesMatematicas();

        // Solicitar al usuario las entradas para los cálculos
        Console.WriteLine("Ingrese la base del rectángulo:");
        double baseRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del rectángulo:");
        double alturaRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el lado del cubo:");
        double ladoCubo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el primer lado del triángulo:");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo lado del triángulo:");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer lado del triángulo:");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese un número para calcular la raíz cuadrada:");
        double numero = Convert.ToDouble(Console.ReadLine());

        // Realizar los cálculos y mostrar los resultados
        operaciones.CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);
        operaciones.CalcularVolumenCubo(ladoCubo);
        operaciones.CalcularPerimetroTriangulo(lado1, lado2, lado3);
        operaciones.CalcularRaizCuadrada(numero);

        operaciones.Imprimir();
    }
}


