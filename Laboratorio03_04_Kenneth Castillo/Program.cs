using System;

object textBoxNumero = null;

Console.WriteLine("a. Sumatoria");
Console.WriteLine("b. tablas de multiplicar");
Console.WriteLine("c. números perfectos");

char opcion = Convert.ToChar(Console.ReadLine());

switch (opcion)
{
    case 'a':

        // n -> sumatoria = 1 + 2 + ... n
        Console.WriteLine("Ingrese un numero");
        int n = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        int resultado = 0;

        do
        {
            resultado = resultado + n;
            n--;
        } while (n > 0);
        Console.WriteLine("sumatoria= " + resultado);
        break;
    case 'b':
        for (i = 1; i < 11; i++)
        {
            Console.Write(i + ":  ");
            for (int j = 1; j < 11; j++)
            {
                Console.Write((i * j) + "\t");
            }
            Console.Write("\n");
        }
        break;
        
        case'c':
        Console.WriteLine("Ingrese un numero");
        int numero = Convert.ToInt32(Console.ReadLine()); 

        int sumaFactores = 0;
        for (int c = 1; c < numero; c++)
        {
            if (numero % c == 0)
            {
                sumaFactores += c;
            }
        }
        if (sumaFactores == numero)
        {
            Console.WriteLine(numero + " es un número perfecto");
        }
        else
        {
            Console.WriteLine(numero + " no es un número perfecto");


        }
        break;
    






}