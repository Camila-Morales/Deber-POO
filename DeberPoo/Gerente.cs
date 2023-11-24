using System;

// Definición de la clase Gerente que hereda de Empleado
public class Gerente : Empleado, IMostrarInformacion
{
    // Nuevo atributo para el departamento que supervisa
    public string Departamento { get; set; }

    // Constructor
    public Gerente(string nombre, double salario, string departamento)
        : base(nombre, salario)
    {
        Departamento = departamento;
    }

    // Implementación del método de la interfaz
    public new void MostrarInformacion()
    {
        Console.WriteLine("---- INFORMACION DEL GERENTE ----");
        Console.WriteLine(" ");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Salario: {Salario:C}");
        Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
        Console.WriteLine($"Departamento: {Departamento}");
        Console.WriteLine(" ");
    }
}
