using System;

// Definición de la clase Empleado
public class Empleado : IMostrarInformacion
{
    // Atributos
    public string Nombre { get; set; }
    public double Salario { get; set; }

    // Constructor
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    // Método para calcular el salario anual
    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    // Implementación del método de la interfaz
    public void MostrarInformacion()
    {
        Console.WriteLine("---- INFORMACION DEL EMPLEADO ----");
        Console.WriteLine(" ");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Salario: {Salario:C}");
        Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
        Console.WriteLine(" ");
    }
}
