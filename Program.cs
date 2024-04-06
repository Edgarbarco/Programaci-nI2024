using System;

public class Calculadora
{
    // Atributos
    public string Marca { get; set; } = "";
    public string Serie { get; set; } = "";

    // Métodos
    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("No se puede dividir por cero.");
            return double.NaN; // Devuelve Not-a-Number (NaN) si se intenta dividir por cero
        }
    }
}

public class CalculadoraCientifica : Calculadora
{
    // Métodos adicionales de la calculadora científica
    public double Potencia(double baseNumber, double exponente)
    {
        return Math.Pow(baseNumber, exponente);
    }

    public double Raiz(double numero)
    {
        return Math.Sqrt(numero);
    }

    public double Modulo(double dividendo, double divisor)
    {
        return dividendo % divisor;
    }

    public double Logaritmo(double numero)
    {
        return Math.Log10(numero);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Crear instancias de las subclases
        Calculadora calculadoraBasica = new Calculadora();
        CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();

        // Ejemplo de uso de la calculadora básica
        Console.WriteLine("Calculadora Básica:");
        Console.WriteLine("Suma: " + calculadoraBasica.Sumar(5, 3));
        Console.WriteLine("Resta: " + calculadoraBasica.Restar(5, 3));
        Console.WriteLine("Multiplicación: " + calculadoraBasica.Multiplicar(5, 3));
        Console.WriteLine("División: " + calculadoraBasica.Dividir(5, 3));

        // Ejemplo de uso de la calculadora científica
        Console.WriteLine("\nCalculadora Científica:");
        Console.WriteLine("Potencia: " + calculadoraCientifica.Potencia(2, 3));
        Console.WriteLine("Raíz cuadrada: " + calculadoraCientifica.Raiz(9));
        Console.WriteLine("Módulo: " + calculadoraCientifica.Modulo(10, 3));
        Console.WriteLine("Logaritmo base 10: " + calculadoraCientifica.Logaritmo(100));
    }
}
