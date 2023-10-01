using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace UPITarea2Progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Digite una opcion");
                Console.WriteLine("1- Ejercicio1");
                Console.WriteLine("2- Ejercicio2");
                Console.WriteLine("3- Ejercicio3");
                Console.WriteLine("4- Salir");
                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        Console.Clear(); 
                        Ejercicio1();
                        break;
                    case 2:
                        Console.Clear(); 
                        Ejercicio2();
                        break;
                    case 3:
                        Console.Clear(); 
                        Ejercicio3();
                        break;
                    default:
                        break;

                }

            } while (opcion!=4); //Mientras que la opcion sea diferente de 4

        }

        public static void Ejercicio1()
        {

            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("**************************************************");
            Console.WriteLine("Tienda Americana de camisas, calculador de precios");
            Console.WriteLine("**************************************************");
            Console.WriteLine("Digite el precio de la camisa: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad ==1)
            {
                Console.WriteLine($"Total a pagar: {cantidad * precio}");
                Console.WriteLine("Si llevas mas de 1 camisa obtendras un descuento!");
                Console.WriteLine("Gracias por su compra, vuelva pronto!");
            }

            if (cantidad > 1 && cantidad < 6)
            {
                total = (cantidad * precio) * 0.15f;
                total = (cantidad * precio) - total;

                Console.WriteLine($"Total a pagar: - {total}");
                Console.WriteLine($"El descuento es del 15% por compras de 2 a 5 camisas!");
                Console.WriteLine("Gracias por su compra, vuelva pronto!");
            }

            if (cantidad >= 6)
            {
                total = (cantidad * precio) * 0.20f;
                total = (cantidad * precio) - total;

                Console.WriteLine($"Total a pagar: - {total}");
                Console.WriteLine($"Se realizo un descuento maximo del 20% por comprar mas de 6 camisas!");
                Console.WriteLine("Gracias por su compra, vuelva pronto!");
            }
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("Sistema para calcular promedios de estudiantes");
            Console.WriteLine("**********************************************");

            Console.WriteLine("Ingrese el carnet del estudiante:");
            string carnet = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del estudiante:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la nota del Quiz 1:");
            double quiz1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Quiz 2:");
            double quiz2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Quiz 3:");
            double quiz3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de la Tarea 1:");
            double tarea1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de la Tarea 2:");
            double tarea2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota de la Tarea 3:");
            double tarea3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Examen 1:");
            double examen1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Examen 2:");
            double examen2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Examen 3:");
            double examen3 = Convert.ToDouble(Console.ReadLine());

            // Calcular porcentajes
            double porcentajeQuices = ((quiz1 + quiz2 + quiz3) * 0.0833);
            double porcentajeTareas = ((tarea1 + tarea2 + tarea3) * 0.1);
            double porcentajeExamenes = ((examen1 + examen2 + examen3) * 0.15);

            // Calcular promedio final
            double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            // Calcular Aprobacion, Aplazo o Reprobacion
            string condicion;
            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            // Mostrar resultados

            Console.WriteLine("**********************************************");
            Console.WriteLine("Resultados finales del estudiante ingresado");
            Console.WriteLine("**********************************************");
            Console.WriteLine("Carnet: " + carnet);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Porcentaje de Quices: " + porcentajeQuices + "%");
            Console.WriteLine("Porcentaje de Tareas: " + porcentajeTareas + "%");
            Console.WriteLine("Porcentaje de Examenes: " + porcentajeExamenes + "%");
            Console.WriteLine("Promedio Final: " + promedioFinal);
            Console.WriteLine("Condición: " + condicion);
        }

        public static void Ejercicio3()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("Bienvenido a la tienda de Abarrotes EL BUEN PRECIO");
            Console.WriteLine("**************************************************");
            Console.WriteLine("Por favor ingrese la cantidad de productosque decea llevarse:");
            int cantidad = int.Parse(Console.ReadLine());

            double precioPorProducto;
            double total;

            if (cantidad <= 10)
            {
                precioPorProducto = 20;
            }
            else
            {
                precioPorProducto = 15;
            }

            total = cantidad * precioPorProducto;

            Console.WriteLine("******************************************************************");
            Console.WriteLine("Total de compra basado en la cantidad d productos que desea llevar");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("Precio por producto: $" + precioPorProducto);
            Console.WriteLine("Total a pagar: $" + total);
        }

    }
}

       
    