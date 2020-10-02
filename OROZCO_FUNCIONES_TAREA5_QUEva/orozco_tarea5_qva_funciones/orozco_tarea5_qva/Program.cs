using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// tarea 1  Crea una función llamada "Signo", que reciba un número real, y devuelva un 
//número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.
namespace orozco_tarea5_qva
/*
{
    public class Program
    {
       public static int signo(float n)
       {
            if (n == 0)
            {
                   return 0;
            }
            else
            {
                if (n > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        public static void Main(string[] args)
        {
            float numero;
            Console.WriteLine("Ingrese un número: ");
            numero = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(signo(numero));
        }
    }
}

*/

// tarea 2  Crea una función "Menor" que calcule el menor de dos números 
//enteros que recibirá como parámetros. El resultado será otro número entero.
/*
{
    public class Program
    {
        public static void Menor(int num1, int num2){

if(num1 > num2){
 Console.WriteLine("El numero {0} es menor",num2);
}
else{
  Console.WriteLine("El numero {0} es menor", num1);

}
}
public static void Main(string[]args){
  int num1;
  int num2;
Console.WriteLine("Digite un numero: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite otro numero: ");
num2 = Convert.ToInt32(Console.ReadLine());
Menor(num1,num2);

 }
}

*/

// tarea 3  Crea una función "EsPrimo", que reciba un número y devuelva 
//el valor booleano "true" si es un número primo o "false" en caso contrario.
/*
{
    public static bool EsPrimo(int num)
    {

        if (num == 2 || num % 2 != 0)
        {
            return true;
        }
        else
        {
            return false;

        }
    }
    public static void Main(string[] args)
    {

        int num;
        Console.WriteLine("Ingrese un numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(EsPrimo(num));

    }
}

*/

// tarea 4  Tarea 4: Analice el código ¿Qué hace este código? 
//Realizar captura de pantalla del código con su resultado y análisis del mismo.
/*
{
    class Program
    {

        static void Main(string[] args)
        {
       Console.Clear();
     //dibujo de cada línea (bucle externo)
           for (int fila=1; fila <= 7; fila ++)
           {
                //dibuja espacios en blanco (1er bucle interno)
                for (int espacios = 7 - fila; espacios > 0; espacios--)
              Console.WriteLine("  ");//espacio en blanco
                Console.ReadKey();
                //dibuja estrellas (2do bucle interno)
                for (int conta = 1; conta <(2 * fila); conta ++)
              Console.WriteLine(" * ");
              Console.WriteLine("  ");
                Console.ReadKey();
           }
        }
    }
}

*/

//tarea 5  Crea una calculadora básica, llamada "calcula", que deberá sumar, restar, 
//multiplicar o dividir los dos números que se le indiquen como parámetros.
//Ejemplos de su uso sería "calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones)

/*
{
    class Program
    {
        static int sumar(int a, int b)
        {
            int suma = a + b;
            return suma;

        }
        static int resta(int a, int b)
        {
            int resta = a - b;
            return resta;
            
        }

        static int multiplicar(int a, int b)
        {
            int multipli = a * b;
            return multipli;

        }

        static int division(int a, int b)
        {
            int divid = a / b;
            return divid;

        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("\n" + "Introduce el 1er número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\n" + "Introduce el 2do número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("\n" + "Seleccione una opción: " + "\n" + "\n");
            Console.Write("\n" + "     1) sumar" + "\n" + "     2) resta" + "\n" + "     3) multiplicar" + "\n" + "     4) division" + "\n" + "     5) Salir del Programa" + "\n" + "\n");

            switch (Console.Read())

            {
                case '1':
                    Console.Write("\n" + "    Suma = " + sumar(a, b));
                    break;

                case '2':
                    Console.Write("\n" + "    Resta = " + resta(a, b));
                    break;

                case '3':
                    Console.Write("\n" + "    Multiplicación = " + multiplicar(a, b));
                    break;

                case '4':
                    Console.Write("\n" + "    División = " + division(a, b));
                    break;
                case '5':
                    Console.Write("\n" + "    ( Salir )");
                    break;

            }
            

            Console.ReadKey();
        }

    }
}

*/

//tarea 6  Crea una función "SumaCifras" que reciba un numero cualquiera y que devuelva como 
//resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la suma sería 6.
/*

{
    public static int SumaCifras(String n)
    {
        int num = int.Parse(n);
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Digite un numero: ");

        Console.WriteLine(SumaCifras("678"));
    }
}

*/

//tarea 7   (Opcional): Crea una función "Triángulo" que reciba una letra y un número, 
//y escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la 
//que se ha indicado. Por ejemplo, si la letra es * y la anchura es 4, debería escribir 
//****
//***
//**
//*
namespace orozco_tarea5_qva

{
    public static void Triangulo(int numero, string letra)
    {
        for (int i = numero; i >= 1; i--)
        {
            for (int a = i; a >= 1; a--)
            {

                Console.Write(letra);
            }
            Console.WriteLine();
        }
    }
    public static void Main(string[] args)
    {
        Triangulo(10, "z");

    }

}
