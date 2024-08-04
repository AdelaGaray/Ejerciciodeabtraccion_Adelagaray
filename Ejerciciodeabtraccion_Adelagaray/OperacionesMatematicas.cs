// En esta clase derivada definiremos lo que es las operaciones matematicas//
// Aqui definiremos los metodos abtractos// 
using System;

public class OperacionesMatematicas : Matematicas
{
    private double _baseRectangulo;
    private double _alturaRectangulo;
    private double _ladoCubo;
    private double _lado1;
    private double _lado2;
    private double _lado3;
    private double _numero;

    // Implementación del método para calcular el área de un rectángulo
    public override double CalcularAreaRectangulo(double baseRectangulo, double alturaRectangulo)
    {
        _baseRectangulo = baseRectangulo;
        _alturaRectangulo = alturaRectangulo;
        return _baseRectangulo * _alturaRectangulo;
    }

    // Implementación del método para calcular el volumen de un cubo
    public override double CalcularVolumenCubo(double lado)
    {
        _ladoCubo = lado;
        return Math.Pow(_ladoCubo, 3);
    }

    // Implementación del método para calcular el perímetro de un triángulo
    public override double CalcularPerimetroTriangulo(double lado1, double lado2, double lado3)
    {
        _lado1 = lado1;
        _lado2 = lado2;
        _lado3 = lado3;
        return _lado1 + _lado2 + _lado3;
    }

    // Implementación del método para calcular la raíz cuadrada
    public override double CalcularRaizCuadrada(double numero)
    {
        _numero = numero;
        return Math.Sqrt(_numero);
    }

    // Implementación del método para imprimir los resultados
    public override void Imprimir()
    {
        Console.WriteLine($"Área del rectángulo: {CalcularAreaRectangulo(_baseRectangulo, _alturaRectangulo)}");
        Console.WriteLine($"Volumen del cubo: {CalcularVolumenCubo(_ladoCubo)}");
        Console.WriteLine($"Perímetro del triángulo: {CalcularPerimetroTriangulo(_lado1, _lado2, _lado3)}");
        Console.WriteLine($"Raíz cuadrada: {CalcularRaizCuadrada(_numero)}");
    }
}
