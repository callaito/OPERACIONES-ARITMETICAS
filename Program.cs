// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;


Console.WriteLine("OPERACIONES ARITMETICAS");
Console.WriteLine();

int resultado_suma, resultado_resta, resultado_multiplicacion;

suma suma = new suma();
Console.WriteLine("operacion suma");
Console.WriteLine();
Console.Write("Valor 1: ");
suma.Valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
suma.Valor2 = Convert.ToInt32(Console.ReadLine());
resultado_suma = suma.operar();
Console.WriteLine($"El resultado de la suma es {resultado_suma}");
Console.WriteLine();

Resta resta = new Resta();
Console.WriteLine("operacion suma");
Console.WriteLine();
Console.Write("Valor 1: ");
resta.Valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
suma.Valor2 = Convert.ToInt32(Console.ReadLine());
resultado_resta = resta.operar();
Console.WriteLine($"El resultado de la resta es {resultado_resta}");
Console.WriteLine();

Multiplicacion multiplicacion = new Multiplicacion();
Console.WriteLine("operacion multiplicacion");
Console.WriteLine();

public class suma : Operacion
{
    public int operar()
    {
        Resultado = Valor1 + Valor2;
        return Resultado;
    }
}
}

public class multiplicacion : Operacion
{
    public int operar()
    {
        Resultado = Valor1 * Valor2;
        return Resultado;
    }
}

public class Resta : Operacion
{
    public int operar()
    {
        Resultado = Valor1 - Valor2;
        return Resultado;
    }
}
}

   public class Operacion
{
    public int Valor1 { get; set; }
    public int Valor2 { get; set; }
    public int Resultado { get; set; }
}
}