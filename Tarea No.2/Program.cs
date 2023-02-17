//Ejercicio 1
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿Cual es su edad?");
        string edadTexto = Console.ReadLine();

        int edad = int.Parse(edadTexto);

        byte edadByte = (byte)edad;

        Console.WriteLine("Wow no parece que tenga " + edadByte + " años");
    }
}







//Ejercicio 2
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Porfavor ingrese el primer número:");
        string num1Texto = Console.ReadLine();

        byte num1 = byte.Parse(num1Texto);

        Console.WriteLine("Porfavor ingrese el segundo número:");
        string num2Texto = Console.ReadLine();

        byte num2 = byte.Parse(num2Texto);

        ushort resultado = (ushort)(num1 * num2);

        Console.WriteLine("La multiplicación del número " + num1 + " y del número " + num2 + " es: " + resultado);
    }
}








//Ejercicio 3
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Porfavor ingrese el primer número:");
        string num1Texto = Console.ReadLine();
        long num1 = long.Parse(num1Texto);

        Console.WriteLine("Porfavor Ingrese el segundo número:");
        string num2Texto = Console.ReadLine();
        long num2 = long.Parse(num2Texto);

        long suma = num1 + num2;
        long resta = num1 - num2;
        long producto = num1 * num2;

        Console.WriteLine("La suma del número " + num1 + " y del número " + num2 + " es: " + suma);
        Console.WriteLine("La resta del número " + num1 + " y del número " + num2 + " es: " + resta);
        Console.WriteLine("El producto del número " + num1 + " y del número " + num2 + " es: " + producto);
    }
}
