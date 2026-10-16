namespace CalculoNomina;

class Program
{
    static void Main(string[] args)
    {
        // variables
        string? nombreEmpleado = "";
        int horasTrabajadas = 0;
        decimal pagoPorHorasTrabajadas = 0m;
        
        
        Console.WriteLine("\t********** CALCULADOR DE HORAS TRABAJADAS **********");
        
        Console.WriteLine("\nInserte el nombre del Empleado: ");
        nombreEmpleado = Console.ReadLine(); // registra nombre empleado
        
        // saludo del sistema para el empleado
        Console.WriteLine($"\nBienvenido/a a Calculador de horas trabajadas {nombreEmpleado}!");
        
        Console.WriteLine("\nIntroduce el total de horas trabajadas: ");
        horasTrabajadas = int.Parse(Console.ReadLine()); // registra total de horas trabajadas
        
        Console.WriteLine("\nInserte el monto de pago por hora: ");
        pagoPorHorasTrabajadas = decimal.Parse(Console.ReadLine()); // registra precio de horas
        
      
        
        // representacion del resultado
        Console.WriteLine("*****************************************************");
        Console.WriteLine("\n \tTARJETA DE EMPLEADO");
        
        Console.WriteLine($"\nNombre: {nombreEmpleado}"); // muestra nombre de empleado
        
        Console.WriteLine($"Salario: $RD{horasTrabajadas *  pagoPorHorasTrabajadas:N1}"); // calcula horas trabajadas por precio de horas
        
        Console.WriteLine("\n*****************************************************");
        
        Console.WriteLine("\nProceso Terminado.");
        
        
        



    }
}