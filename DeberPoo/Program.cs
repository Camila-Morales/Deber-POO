using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" ");
        Console.WriteLine("-- BIENVENIDO INGRESE LOS DATOS DEL EMPLEADO Y EL GERENTE --");
        Console.WriteLine(" ");

        // Obtener datos del empleado desde la entrada del usuario
        Console.Write("Ingrese el nombre del empleado: ");
        string nombreEmpleado = Console.ReadLine();

        Console.Write("Ingrese el salario del empleado: ");
        double salarioEmpleado = Convert.ToDouble(Console.ReadLine());

        // Crear instancia de Empleado
        Empleado empleado = new Empleado(nombreEmpleado, salarioEmpleado);

        Console.WriteLine(" ");

        // Obtener datos del gerente desde la entrada del usuario
        Console.Write("Ingrese el nombre del gerente: ");
        string nombreGerente = Console.ReadLine();

        Console.Write("Ingrese el salario del gerente: ");
        double salarioGerente = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el departamento que supervisa el gerente: ");
        string departamentoGerente = Console.ReadLine();

        Console.WriteLine(" ");

        // Crear instancia de Gerente
        Gerente gerente = new Gerente(nombreGerente, salarioGerente, departamentoGerente);

        // Mostrar información utilizando polimorfismo a través de la interfaz
        MostrarInformacion(empleado);
        MostrarInformacion(gerente);
    }

    // Método que utiliza polimorfismo a través de la interfaz
    static void MostrarInformacion(IMostrarInformacion entidad)
    {
        entidad.MostrarInformacion();
    }
}
