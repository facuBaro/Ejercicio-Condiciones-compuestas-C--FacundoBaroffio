using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {   //EJERCICIO 1
        /* Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.*/
        /* int dia, mes, año;
         Console.WriteLine("Ingrese el dia");
         dia = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ingrese el numero del mes");
         mes = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ingrese el año");
         año = Convert.ToInt32(Console.ReadLine());
         if(dia!=24 && mes != 12)
         {
             Console.WriteLine("La fecha ingresada no corresponde a navidad");

         }
         else
         {
             Console.WriteLine("La fecha ingresada corresponde a navidad");
         }
         Console.ReadKey(); */

        //EJERCICIO 2

        /*Se ingresan tres valores por teclado, si todos son iguales se
         * imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.*/

        /* int num1, num2, num3;
         Console.WriteLine("Ingrese el 1° numero");
         num1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ingrese el 2° numero");
         num2 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ingrese el 3° numero");
         num3 = Convert.ToInt32(Console.ReadLine());
         if(num1== num2 && num1 == num3)
         {
             Console.WriteLine("El resultado de la suma del primer y segundo numero es: " + (num1 + num2) );
             Console.WriteLine("Y si lo multiplicamos por el tercero: " + (num1 + num2) * num3);
         }
         else
         {
             Console.WriteLine("Los numeros ingresados no son iguales");

         }
         Console.ReadKey(); */

        //EJERCICIO 3
        /*Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10,
         * imprimir en pantalla la leyenda "Todos los números son menores a diez"*/

        /*  int num1, num2, num3;
          Console.WriteLine("Ingrese el 1° numero");
          num1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Ingrese el 2° numero");
          num2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Ingrese el 3° numero");
          num3 = Convert.ToInt32(Console.ReadLine());
          if(num1<10 && num2<10 && num3< 10)
          {
              Console.WriteLine("Todos los numeros son menores a diez");
          }
          else
          {
              Console.WriteLine("Todos los numeros NO son menores a diez");
          }
          Console.ReadKey();*/

        //EJERCICIO 4
        /*Se ingresan por teclado tres números, si al menos 
         * uno de los valores ingresados es menor a 10, imprimir en pantalla la leyenda "Alguno de los números es menor a diez".*/
        /*   int num1, num2, num3;
           Console.WriteLine("Ingrese el 1° numero");
           num1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Ingrese el 2° numero");
           num2 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Ingrese el 3° numero");
           num3 = Convert.ToInt32(Console.ReadLine());
           if (num1 < 10 || num2 < 10 || num3 < 10)
           {
               Console.WriteLine("Alguno/s de los numeros son menores a diez");
           }
           else
           {
               Console.WriteLine("Todos los numeros NO son menores a diez");
           }
           Console.ReadKey(); */

        //EJERCICIO 5
        /*Escribir un programa que pida ingresar la coordenada de un punto en el plano, 
         * es decir dos valores enteros x e y (distintos a cero).
Posteriormente 
        imprimir en pantalla en que cuadrante se ubica dicho punto. 
        (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0, etc.)*/

        /*     int x, y;
             Console.WriteLine("Ingrese el valor de x");
             x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Ingrese el valor de y");
             y = Convert.ToInt32(Console.ReadLine());
             if(x>0 && y > 0)
             {
                 Console.WriteLine(("El punto esta en el 1° cuadrante"));
             }
             if (x < 0 && y > 0)
             {
                 Console.WriteLine(("El punto esta en el 2° cuadrante"));
             }
             if (x < 0 && y < 0)
             {
                 Console.WriteLine(("El punto esta en el 3° cuadrante"));
             }
             if (x > 0 && y < 0)
             {
                 Console.WriteLine(("El punto esta en el 4° cuadrante"));

             }
             Console.ReadKey(); */

        //EJERCICIO 6
        /*De un operario se conoce su sueldo y los años de antigüedad.
         * Se pide confeccionar un programa que lea los datos de entrada e informe:
a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años,
        otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
b) Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.*/

        /*  double sueldo;
          int antiguedad;
          Console.WriteLine("Ingrese el sueldo del operario");
          sueldo = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Ingrese la antiguedad del operario");
          antiguedad = Convert.ToInt32(Console.ReadLine());
          if(sueldo<500 && antiguedad >= 10)
          {
              sueldo = sueldo + ((sueldo * 20) / 100);
          }
          if(sueldo<500 && antiguedad < 10)
          {
              sueldo = sueldo + ((sueldo * 5) / 100);
          }
          Console.WriteLine("El sueldo a pagar al operario es de: " + sueldo);
          Console.ReadKey(); */

        //EJERCICIO 7
        /*Escribir un programa en el cual: dada una lista de tres valores numéricos 
         * distintos se calcule e informe su rango de variación (debe mostrar el mayor y el menor de ellos).*/

      /*  int num1, num2, num3,max,min;
        Console.WriteLine("Ingrese el 1° numero");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el 2° numero");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el 3° numero");
        num3 = Convert.ToInt32(Console.ReadLine());
        max = num1;
        min = num1;
        if (max < num2)
        {
            max = num2;
        }
        if (max < num3)
        {
            max = num3;
        }
        if (min > num2)
        {
            min = num2;
        }
        if (min > num3)
        {
            min = num3;
        }
        Console.WriteLine("El maximo es: " + max);
        Console.WriteLine("El minimo es: " + min);
        Console.WriteLine("El rango de variacion es de: " + (max - min));
        Console.ReadKey(); */
     
    }
}