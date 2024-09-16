class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el tipo de empleado (por hora/fijo/administrativo):");
        string tipoEmpleado = Console.ReadLine().ToLower();

        switch (tipoEmpleado)
        {
            case "por hora":
                CalcularSalarioPorHora();
                break;
            case "fijo":
            case "administrativo":
                CalcularSalarioFijoOAdministrativo(tipoEmpleado);
                break;
            default:
                Console.WriteLine("Tipo de empleado no reconocido.");
                break;
        }
    }

    static void CalcularSalarioPorHora()
    {
        Console.WriteLine("Ingrese las horas trabajadas:");
        int horas = int.Parse(Console.ReadLine());

        decimal salario = horas * 800;
        Console.WriteLine($"El salario total del docente por hora es: {salario}");
    }

    static void CalcularSalarioFijoOAdministrativo(string tipoEmpleado)
    {
        Console.WriteLine($"Ingrese el salario base del {tipoEmpleado}:");
        decimal salarioBase = decimal.Parse(Console.ReadLine());

        Console.WriteLine("¿Cumplió la meta? (sí/no):");
        string cumplioMeta = Console.ReadLine().ToLower();


        if (cumplioMeta == "si")
        {
            Console.WriteLine($"El salario final del {tipoEmpleado} es: {salarioBase}");
        }

        else
        {
        decimal salarioFinal =  salarioBase / 2;
        Console.WriteLine($"El salario final del {tipoEmpleado} es: {salarioFinal}");
        }
    }
}

//Pablo Enmanuel Cedano Hernandez 2023-1997