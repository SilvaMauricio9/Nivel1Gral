using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using System.Xml;

namespace Nivel1Gral
{
    class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIOS 2:
            // 1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
            // float n1, n2, resultado;

            // Console.WriteLine("Ingrese un numero: ");
            // n1 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otro: ");
            // n2 = float.Parse(Console.ReadLine());

            // resultado = n1 + n2;

            // Console.WriteLine("El resultado es: " + resultado);

            // 2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
            // float n1, resultado;
            // Console.WriteLine("Ingrese numero: ");
            // n1 = float.Parse(Console.ReadLine());
            
            // resultado = n1 * n1 * n1;

            // Console.WriteLine("El resultado elevado al cubo es: " + resultado);

            // 3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
            // Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            // float kilómetros, velocidad, resultado;
            // Console.WriteLine("Ingrese los kilometros: ");
            // kilómetros = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la velocidad: ");
            // velocidad = float.Parse(Console.ReadLine());

            // resultado = kilómetros / velocidad;

            // Console.WriteLine("El tiempo estimado para llegar es: " + resultado);

            // 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado.
            //  Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            // float facturado, totalFacturado;
            // Console.WriteLine("Ingrese total facturado:");
            // facturado = float.Parse(Console.ReadLine());

            // totalFacturado = facturado * 0.05f + 15000;
            
            // Console.WriteLine("El sueldo total a pagar es de: " + totalFacturado);

            // 5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.
            // float n1, n2, n3, promedio, promedioFinal;
            // Console.WriteLine("Ingrese primer nota: ");
            // n1 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese segunda nota: ");
            // n2 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese ultima nota: ");
            // n3 = float.Parse(Console.ReadLine());

            // promedio = n1 + n2 + n3;
            // promedioFinal = promedio / 3;

            // Console.WriteLine("El promedio final es: " + promedioFinal);

            // CONDICIONALES:
            // 1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
            // int n1;
            // Console.WriteLine("Ingrese numero: ");
            // n1 = int.Parse(Console.ReadLine());

            // if (n1 > 10)
            // {
            //     Console.WriteLine("Es mayor a 10");
            // }else
            // {
            //     Console.WriteLine("No es mayor a 10");
            // }

            // 2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
            // float n1;
            // Console.WriteLine("Ingrese numero:");
            // n1 = float.Parse(Console.ReadLine());

            // if (n1 > 0)
            // {
            //     Console.WriteLine("Positivo");
            // }else if (n1 < 0)
            // {
            //     Console.WriteLine("Negativo");
            // }else
            // {
            //     Console.WriteLine("Cero");
            // }

            // 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
            // Si el importe es menor a ARS 1000, no hay descuento.
            // Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            // Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            // Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.
            // float importe;
            // Console.WriteLine("Ingrese el importe de la compra: ");
            // importe = float.Parse(Console.ReadLine());

            // if (importe < 1000)
            // {
            //     Console.WriteLine("No tiene descuento");
            // }else if (importe >= 1000 && importe < 5000)
            // {
            //     importe = importe * 0.90f;
            // }else
            // {
            //     importe = importe * 0.82f;
            // }
            // Console.WriteLine("El importe total a pagar es de: " + importe);

            // 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
            // int n1, n2, n3, n4;
            // Console.WriteLine("Ingrese un numero: ");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otro numero: ");
            // n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otro numero: ");
            // n3 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el ultimo numero: ");
            // n4 = int.Parse(Console.ReadLine());

            // if (n1 < n2 && n1 < n3 && n1 < n4)
            // {
            //     Console.WriteLine("El numero menor es: " + n1);
            // }
            // if (n2 < n1 && n2 < n3 && n2 < n4)
            // {
            //     Console.WriteLine("El numero menor es: " + n2);
            // }
            // if (n3 < n1 && n3 < n2 && n3 < n4)
            // {
            //     Console.WriteLine("El numero menor es: " + n3);
            // }else if (n4 < n1 && n4 < n2 && n4 < n3)
            // {
            //     Console.WriteLine("El numero menor es: " + n4);
            // }
            
            // 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

            // int n1, n2, n3, n4;
            // Console.WriteLine("Ingrese un numero: ");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otro: ");
            // n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otro: ");
            // n3 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el ultimo: ");
            // n4 = int.Parse(Console.ReadLine());

            // if (n1 > 100)
            // {
            //     Console.WriteLine(n1 + " Es mayor a 100");
            // }
            // if (n2 > 100)
            // {
            //     Console.WriteLine(n2 + " Es mayor a 100");
            // }
            // if (n3 > 100)
            // {
            //     Console.WriteLine(n3 + " Es mayor a 100");
            // }
            // if (n4 > 100)
            // {
            //     Console.WriteLine(n4 + " Es mayor a 100");
            // }

            // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            // La resta si el primero es mayor que el segundo.
            // La suma si son iguales.
            // El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            // int n1, n2, resultado = 0;
            // Console.WriteLine("Ingrese un numero: ");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otro: ");
            // n2 = int.Parse(Console.ReadLine());

            // if (n1 > n2)
            // {
            //     resultado = n1 - n2;
            // }else if (n1 == n2)
            // {
            //     resultado = n1 + n2;
            // }else
            // {
            //     resultado = n1 * n2;
            // }
            // Console.WriteLine("El resultado es: " + resultado);

            // 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            // Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
            // float importe, litros;
            // Console.WriteLine("Ingrese los litros vendidos: ");
            // litros = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el importe de la venta ");
            // importe = int.Parse(Console.ReadLine());

            // if (litros < 100)
            // {
            //     Console.WriteLine("No tiene descuento, el total a pagar es: " + importe);
            // }else if (litros > 100 && litros <= 300)
            // {
            //     importe = importe * 0.90f;
            //     Console.WriteLine("El descuento es del 10% OFF y el total a pagar es: " + importe);
            // }else if (litros > 300 && litros <= 500)
            // {
            //     importe = importe * 0.85f;
            //     Console.WriteLine("El descuento es del 15% OFF y el total a pagar es: " + importe);
            // }else68
            // {
            //     importe = importe * 0.75f;
            //     Console.WriteLine("El descuento es del 25% OFF y el total a pagar es: " + importe);
            // }

            // 3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
            // i5 (1)	i7 (2)	i9 (3)
            // 8 RAM (1)	USD 800	USD 900	USD 1200
            // 16 RAM (2)	USD 900	USD 1000	USD 1400
            // 32 RAM (3)	USD 1000	USD 1400	USD 2000
            // Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
            // Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.
            // int procesador, memoriaRam, importe = 0, disco = 0;
            // Console.WriteLine("Ingrese el procesador que desea: ");
            // procesador = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la Memoria RAM que desea: ");
            // memoriaRam = int.Parse(Console.ReadLine());
            // Console.WriteLine("Desea ampliar el disco? ");
            // disco = int.Parse(Console.ReadLine());

            // switch (procesador){
            //     case 1:
            //         switch (memoriaRam)
            //         {
            //         case 1:
            //             importe = 800;
            //             break;
            //         case 2:
            //             importe = 900;
            //             break;
            //         default:
            //             importe = 1000;
            //             break;
            //         }
            //         break;
            //     case 2:
            //         switch (memoriaRam)
            //         {
            //         case 1:
            //             importe = 900;
            //             break;
            //         case 2:
            //             importe = 1200;
            //             break;
            //         default:
            //             importe = 1400;
            //             break;
            //         }
            //         break;
            //     case 3:
            //         switch (memoriaRam)
            //         {
            //         case 1: 
            //             importe = 1200;
            //             break;
            //         case 2: 
            //             importe = 1400;
            //             break;
            //         default:
            //             importe = 2000;
            //             break;
            //         }
            //         break;
            // }
            // if (disco == 1)
            // {
            //     importe = importe + 300;
            // }
            // Console.WriteLine("El importe total a pagar es de: " + importe);

            // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            // int n1, n2, n3;
            // Console.WriteLine("Ingrese un numero: ");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otro: ");
            // n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el ultimo: ");
            // n3 = int.Parse(Console.ReadLine());
            
            // if (n1 + n2 > n2 * n3)
            // {

            //     Console.WriteLine("La suma de los dos primeros es mayor al producto..");
            // }
            // Console.WriteLine("Fin del programa!!");

            // 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente.
            // int n1, n2, n3, n4;
            // Console.WriteLine("Ingrese un numero: ");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otro: ");
            // n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otro: ");
            // n3 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el ultimo: ");
            // n4 = int.Parse(Console.ReadLine());

            // if (n1 > n2 && n2 > n3 && n3 > n4)
            // {
            //     Console.WriteLine("Se encuentran ordenados en forma decreciente...");
            // }else{
            //     Console.WriteLine("No se encuentran en forma decreciente..");
            // }
            // Console.WriteLine("Fin del Programa!!");

            // 1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.
            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine(x + 1);
            // }

            // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            // int n, mayor = 0;
            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: ");
            //     n = int.Parse(Console.ReadLine());
            //     if (n > mayor)
            //     {
            //         mayor = n;
            //     }
                
            // }
            // Console.WriteLine("El mayor es: " + mayor);

            // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            // int edad, conEdad = 0, promedio = 0;
            // for (int x = 0; x < 20; x++)
            // {
            //     Console.WriteLine("Ingrese la edad: ");
            //     edad = int.Parse(Console.ReadLine());
            //     if (edad > 18)
            //     {
            //         conEdad += edad;
            //         promedio++;
            //     }
            // }
            // promedio = conEdad / promedio;
            // Console.WriteLine("El promedio de edades mayores a 18 es:" + promedio);

            // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
            // int n, conPrimo = 0;
            // Console.WriteLine("Ingrese un numero: ");
            // n = int.Parse(Console.ReadLine());
            // for (int x = 1; x <= n; x++)
            // {
            //     if (n % x == 0)
            //     {
            //         conPrimo++;
            //     }
            // }
            // if (conPrimo == 2){
            //     Console.WriteLine("Es numero Primo!!");
            // }else
            //     {
            //     Console.WriteLine("NO es numero Primo!!");
            //     }
            
            
            // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            // int n, maximoPar = 0, minimoImpar = 0, minimo = 0;
            // for (int x = 0; x < 5; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: ");
            //     n = int.Parse(Console.ReadLine());
            //     if (n % 2 == 0)
            //     {
            //         if (n > maximoPar)
            //         {
            //             maximoPar = n;
            //         }
            //     }else
            //     {
            //         minimo++;
            //         if (minimo == 1)
            //         {
            //             minimoImpar = n;
            //         }else if (n < minimoImpar)
            //         {
            //             minimoImpar = n;
            //         }
            //     }
            // }
            // Console.WriteLine("El maximo par es: " + maximoPar);
            // Console.WriteLine("El minimo impar es: " + minimoImpar);

            // 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            // int n;
            // int conPrim = 0, con = 0;
            // for (int x = 0; x < 5; x++)
            // {
            // Console.WriteLine("Ingrese un numero: ");
            // n = int.Parse(Console.ReadLine());
            // con = 0;
            // for (int y = 1; y <= n; y++)
            // {
            //     if(n % y == 0)
            //         con++;
            // }
            //     if (con == 2)
            //         conPrim++;
            
            // }
            // Console.WriteLine("Los numeros primos son: " + conPrim);
            
            // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            // int n, impar, con, minimo, grupoImparMaximo = 0, contadorOrdenados = 0;
            // double porcentajeImpar = 0, porcentajeMaximo = -1;
            // bool banderaOrdenados;
            // Console.WriteLine("Ingrese lista: ");
            // n = int.Parse(Console.ReadLine());
            
            // for (int x = 0; x < 5; x++)
            // {
            //     impar = 0;
            //     banderaOrdenados = true;
            //     con = 0;
            //     minimo = n;
            //     Console.WriteLine("Ingrese lista: ");
            //     n = int.Parse(Console.ReadLine());
            //     while (n != 0)
            //     {
            //         con++;
            //         if (n % 2 == 1)
            //         {
            //             impar++;
            //         }
                
            //         if (n <= minimo)
            //         {
            //             minimo = n;
            //         }else
            //         {
            //             banderaOrdenados = false;
            //         }
            //     Console.WriteLine("Ingrese lista: ");
            //     n = int.Parse(Console.ReadLine());
            //     }
            //     porcentajeImpar = impar * 100 / con;
            //     if (porcentajeImpar > porcentajeMaximo)
            //     {
            //         porcentajeMaximo = porcentajeImpar;
            //         grupoImparMaximo = x + 1;
            //     }
            //     if (banderaOrdenados)
            //     {
            //         contadorOrdenados++;
            //     }
            // }
            // Console.WriteLine("El grupo con mayor porcentaje es: " + grupoImparMaximo);
            // Console.WriteLine("La cantidad de grupos ordenados son: " + contadorOrdenados);

            // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            // int n = 1, conPositivo = 0, lista = 0;
            // Console.WriteLine("Ingrese numero: ");
            // n = int.Parse(Console.ReadLine());
            // while (n >= 0)
            // {
            //     lista++;
            //     conPositivo = 0;
            //     n = int.Parse(Console.ReadLine());
            //     while (n > 0)
            //     {
            //         conPositivo++;
            //         Console.WriteLine("Ingrese otro numero: ");
            //         n = int.Parse(Console.ReadLine());   
            //     }
            //     Console.WriteLine("La lista Nº: " + lista + " Contiene: " + conPositivo + " positivos..");
            //}

            // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            // int[] numeros = new int[10];
            // int n, maximo = 0, posicion = 0;

            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: ");
            //     n = int.Parse(Console.ReadLine());
            //     numeros[x] = n;
                
            // }
            // for (int x = 0; x < 10; x++)
            // {
                
            //     if (numeros[x] > maximo)
            //     {
            //         maximo = numeros[x];
            //         posicion = x;
            //     }
            // }
            // Console.WriteLine("El valor maximo es: " + maximo + " y su posicion es: " + (posicion + 1));

            // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio.
            //  Mostrar por pantalla los valores que son mayores al promedio.
            // int n, acuProm = 0;
            // int[] vector = new int[5];
            // for (int x = 0; x < 5; x++)
            // {
            //     Console.WriteLine("Ingrese numero: ");
            //     n = int.Parse(Console.ReadLine());
            //     vector[x] = n;
            // }
            // for (int x = 0; x < 5; x++)
            // {
            //     acuProm += vector[x];

            // }
            // acuProm = acuProm / 5;
            // Console.WriteLine("El promedio es: " + acuProm);
            // for (int x = 0; x < 5; x++)
            // {
            //     if (vector[x] > acuProm)
            //     {
            //         Console.WriteLine("Los mayores al promedio son : " + vector[x]);
            //     }
            // }

            // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.
           
            // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. 
            // Usar la función.
            // int n1, n2, resultado;
            // Console.WriteLine("Ingrese el precio del articulo: ");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la cantidad vendida: ");
            // n2 = int.Parse(Console.ReadLine());

            // resultado = producto(n1, n2);

            // Console.WriteLine("El producto de los articulos es: " + resultado);

            // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            // int n1, resultado, conPares = 0;
            
            // for (int x = 0; x < 5; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: ");
            //     n1 = int.Parse(Console.ReadLine());
            //     resultado = par(n1);
            //     if (resultado == 1)
            //     {
            //         conPares++;
            //     }
                
            // }
            // Console.WriteLine("la cantidad de numeros pares es: " + conPares);

            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            // Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
            // Informar el promedio teniendo en cuenta sólo los números primos.
            // int n1, acuPrimo = 0, acu = 0, promedio = 0;
            // Console.WriteLine("Ingrese un numero: ");
            // n1 = int.Parse(Console.ReadLine());

            // while (n1 > 0)
            // {
            //     if (primo(n1))
            //     {
            //         acu++;
            //         acuPrimo += n1;
            //     }
            //     Console.WriteLine("Ingrese un numero: ");
            //     n1 = int.Parse(Console.ReadLine());
               
            // }
            // promedio = acuPrimo / acu;
            // Console.WriteLine("El promedio de numeros primos es: " + promedio);

            // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
            // Que analice el número y escriba variable recibida por referencia con:
            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.
        //     int n1, n2 = 0;
        //     Console.WriteLine("Ingrese un numero: ");
        //     n1 = int.Parse(Console.ReadLine());

        //     positivoNegativoCero(n1, ref n2);

        //     Console.WriteLine("El valor del numero es: " + n1 + " y su estado: " + n2);
        // }   
        // static void positivoNegativoCero (int a, ref int b){
        //     if (a > 0){
        //         b = 1;
        //     }else if (a == 0){
        //         b = 0;
        //     }else{
        //         b = -1;
        //     }
        }
    }
}
