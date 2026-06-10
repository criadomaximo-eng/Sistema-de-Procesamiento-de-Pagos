using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Pago> pagos = new List<Pago>();

        int opcion;

        do
        {
            Console.WriteLine("===== SISTEMA DE PAGOS =====");
            Console.WriteLine("1 - Registrar Pago con Tarjeta");
            Console.WriteLine("2 - Registrar Pago por Transferencia");
            Console.WriteLine("3 - Mostrar Pagos");
            Console.WriteLine("4 - Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.Write("Ingrese titular: ");
                    string titularTarjeta = Console.ReadLine();

                    Console.Write("Ingrese monto: ");
                    double montoTarjeta = Convert.ToDouble(Console.ReadLine());

                    pagos.Add(new PagoTarjeta(titularTarjeta, montoTarjeta));

                    Console.WriteLine("Pago agregado correctamente.");
                    break;

                case 2:

                    Console.Write("Ingrese titular: ");
                    string titularTransferencia = Console.ReadLine();

                    Console.Write("Ingrese monto: ");
                    double montoTransferencia = Convert.ToDouble(Console.ReadLine());

                    pagos.Add(new PagoTransferencia(titularTransferencia, montoTransferencia));

                    Console.WriteLine("Pago agregado correctamente.");
                    break;
                case 3:

                    Console.WriteLine("\n===== LISTA DE PAGOS =====");

                    foreach (Pago pago in pagos)
                    {
                        pago.ProcesarPago();
                        Console.WriteLine("--------------------------------");
                    }

                    break;

                case 4:

                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:

                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 4);
    }
}