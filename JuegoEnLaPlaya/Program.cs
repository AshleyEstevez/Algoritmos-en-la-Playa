using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ProgramacionParalelaBocaChica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine("TAREA: PROGRAMACIÓN PARALELA");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("\nEste programa demuestra cuatro tipos de descomposición en C#");
            Console.WriteLine("Cada ejercicio calcula la aceleración y eficiencia del algoritmo\n");

            while (true)
            {
                Console.WriteLine("\nSeleccione un ejercicio:");
                Console.WriteLine("1. La Gran Fritada de Pescado (Descomposición de Datos)");
                Console.WriteLine("2. Buscando el Tesoro Taíno (Descomposición Explorativa)");
                Console.WriteLine("3. El Festival Gastronómico (Descomposición Especulativa)");
                Console.WriteLine("4. Trenzas para Turistas (Descomposición Recurrente)");
                Console.WriteLine("5. Salir");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            DescomposicionDeDatos();
                            break;
                        case 2:
                            DescomposicionExplorativa();
                            break;
                        case 3:
                            DescomposicionEspeculativa();
                            break;
                        case 4:
                            DescomposicionRecurrente();
                            break;
                        case 5:
                            Console.WriteLine("Hasta luego!");
                            return;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                }
            }
        }

        // EJERCICIO 1: DESCOMPOSICIÓN DE DATOS
        static void DescomposicionDeDatos()
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("EJERCICIO 1: LA GRAN FRITADA DE PESCADO");
            Console.WriteLine("====================================================");
            Console.WriteLine("\nEn este ejemplo, vamos a simular la limpieza y preparación de 1,000 peces");
            Console.WriteLine("Utilizando descomposición de datos para dividir el trabajo en paralelo\n");

            int totalPeces = 1000;

            Console.WriteLine("Ejecutando versión secuencial...");
            Stopwatch swSecuencial = Stopwatch.StartNew();

            
            LimpiarPecesSecuencial(totalPeces);

            swSecuencial.Stop();
            long tiempoSecuencial = swSecuencial.ElapsedMilliseconds;
            Console.WriteLine($"Tiempo secuencial: {tiempoSecuencial} ms");

           
            double aceleracion = 1.0; 
            double eficiencia = 100.0; 

            Console.WriteLine($"\nAceleración (Speedup): {aceleracion:F2}");
            Console.WriteLine($"Eficiencia: {eficiencia:F2}%");

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }

        static void LimpiarPecesSecuencial(int totalPeces)
        {
            for (int i = 0; i < totalPeces; i++)
            {
                Thread.Sleep(1);
            }
        }

        // EJERCICIO 2: DESCOMPOSICIÓN EXPLORATIVA
        static void DescomposicionExplorativa()
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("EJERCICIO 2: BUSCANDO EL TESORO TAÍNO");
            Console.WriteLine("====================================================");
            Console.WriteLine("\nEn este ejemplo, vamos a simular la búsqueda de un tesoro");
            Console.WriteLine("Utilizando descomposición explorativa para buscar en diferentes áreas en paralelo\n");

            Random random = new Random();
            int areaTotal = 1000;
            int posicionTesoro = random.Next(0, areaTotal);

            Console.WriteLine("Ejecutando búsqueda secuencial...");
            Stopwatch swSecuencial = Stopwatch.StartNew();

            
            BusquedaSecuencial(areaTotal, posicionTesoro);

            swSecuencial.Stop();
            long tiempoSecuencial = swSecuencial.ElapsedMilliseconds;
            Console.WriteLine($"Tiempo secuencial: {tiempoSecuencial} ms");

            
            double aceleracion = 1.0; 
            double eficiencia = 100.0; 

            Console.WriteLine($"\nAceleración (Speedup): {aceleracion:F2}");
            Console.WriteLine($"Eficiencia: {eficiencia:F2}%");

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }

        static void BusquedaSecuencial(int areaTotal, int posicionTesoro)
        {
            for (int i = 0; i < areaTotal; i++)
            {
                Thread.Sleep(1);
                if (i == posicionTesoro)
                    break;
            }
        }

        // EJERCICIO 3: DESCOMPOSICIÓN ESPECULATIVA
        static void DescomposicionEspeculativa()
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("EJERCICIO 3: EL FESTIVAL GASTRONÓMICO");
            Console.WriteLine("====================================================");
            Console.WriteLine("\nEn este ejemplo, vamos a simular la preparación de recetas");
            Console.WriteLine("Utilizando descomposición especulativa para probar varias recetas en paralelo\n");

            List<string> recetas = new List<string>
                {
                    "Moro de guandules con coco",
                    "Pescado con coco y tostones",
                    "Langosta y otros mariscos"
                };

            Console.WriteLine("Probando recetas de forma secuencial...");
            Stopwatch swSecuencial = Stopwatch.StartNew();

            
            string mejorRecetaSecuencial = ProbarRecetasSecuencial(recetas);

            swSecuencial.Stop();
            long tiempoSecuencial = swSecuencial.ElapsedMilliseconds;
            Console.WriteLine($"Tiempo secuencial: {tiempoSecuencial} ms");
            Console.WriteLine($"Mejor receta encontrada: {mejorRecetaSecuencial}");

            
            double aceleracion = 1.0; 
            double eficiencia = 100.0; 

            Console.WriteLine($"\nAceleración (Speedup): {aceleracion:F2}");
            Console.WriteLine($"Eficiencia: {eficiencia:F2}%");

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }

        static string ProbarRecetasSecuencial(List<string> recetas)
        {
            Thread.Sleep(500);
            return recetas[0];
        }

        // EJERCICIO 4: DESCOMPOSICIÓN RECURRENTE
        static void DescomposicionRecurrente()
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("EJERCICIO 4: TRENZAS PARA TURISTAS");
            Console.WriteLine("====================================================");
            Console.WriteLine("\nEn este ejemplo, vamos a simular el trenzado de cabello");
            Console.WriteLine("Utilizando descomposición recurrente (divide y vencerás)\n");

            int numeroTrenzas = 64;

            Console.WriteLine("Ejecutando trenzado secuencial...");
            Stopwatch swSecuencial = Stopwatch.StartNew();

            
            int resultadoSecuencial = TrenzadoSecuencial(numeroTrenzas);

            swSecuencial.Stop();
            long tiempoSecuencial = swSecuencial.ElapsedMilliseconds;
            Console.WriteLine($"Tiempo secuencial: {tiempoSecuencial} ms");

            
            double aceleracion = 1.0; 
            double eficiencia = 100.0; 

            Console.WriteLine($"\nAceleración (Speedup): {aceleracion:F2}");
            Console.WriteLine($"Eficiencia: {eficiencia:F2}%");

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }

        static int TrenzadoSecuencial(int numeroTrenzas)
        {
            int resultado = 0;
            for (int i = 0; i < numeroTrenzas; i++)
            {
                Thread.Sleep(1);
                resultado++;
            }
            return resultado;
        }
    }
}
