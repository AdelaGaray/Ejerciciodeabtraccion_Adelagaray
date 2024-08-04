// vamos a definir la clase primero//
// en este caso sera matematicas//
public abstract class Matematicas
{
    // Métodos abstractos que deben ser implementados en la clase derivada
    public abstract double CalcularAreaRectangulo(double baseRectangulo, double alturaRectangulo);
    public abstract double CalcularVolumenCubo(double lado);
    public abstract double CalcularPerimetroTriangulo(double lado1, double lado2, double lado3);
    public abstract double CalcularRaizCuadrada(double numero);

    // Método para imprimir los resultados
    public abstract void Imprimir();
}
