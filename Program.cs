namespace CalculoNomina;

class Program
{
    static void Main(string[] args)
    {
        // variables
        string? nombreEmpleado = "";
        int horasTrabajadas = 0;
        decimal pagoHorasTrabajadas = 0m;
        
        
        Console.WriteLine("\t********** CALCULADOR DE HORAS TRABAJADAS **********");
        
        Console.WriteLine("\nInserte el nombre del Empleado: ");
        nombreEmpleado = Console.ReadLine(); // registra nombre empleado
        
        Console.WriteLine("\nIntroduce el horas trabajadas: ");
        horasTrabajadas = int.Parse(Console.ReadLine()); // registra total de horas trabajadas
        
        Console.WriteLine("\nInserte el monto de pago por hora: ");
        pagoHorasTrabajadas = decimal.Parse(Console.ReadLine()); // registra precio de horas
        
        Console.WriteLine("\n \t********** Su salario acumulado hasta el momento es: **********");
        
        



    }
}