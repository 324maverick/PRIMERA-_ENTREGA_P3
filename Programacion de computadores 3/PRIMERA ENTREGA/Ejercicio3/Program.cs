using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" VEAMOS SI PUEDES CONDUCIR ");
            //Console.WriteLine("introduce tu edad : ");
            //    int edad = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("tienes carnet ");
            //string carnet = Console.ReadLine();
            //if (edad >= 18 && carnet == "si")
            //{
            //    Console.WriteLine(" puedes cobnducir ");
            //}
            //else
            //{
            //    Console.WriteLine(" no puedes cobnducir ");
            //}

            //double saldoApertura = 5000000;
            //String nombre;
            //String numeroCuenta;
            //double  saldoFinal;

            //Console.WriteLine("INGRESA EL NOMBRE DEL CLIENTE  ");
            //        nombre = Console.ReadLine();
            //Console.WriteLine("INGRESE EL NUMERO DE CUENTA ");
            //numeroCuenta = Console.ReadLine();
            //Console.WriteLine("CUANTO VAS A RETIRAR  ");
            //double retiro = double.Parse(Console.ReadLine());
            // saldoFinal = (saldoApertura-retiro);


            //Console.WriteLine(" SEÑOR " + nombre +" le quedan " +saldoFinal+" en su cuenta "+numeroCuenta);





            Console.WriteLine("INGRESA EL NOMBRE DEL CLIENTE  ");
            String nombre = Console.ReadLine();

            Console.WriteLine("INGRESE EL NUMERO DE CUENTA ");
            String numeroCuenta = Console.ReadLine();

            Console.WriteLine("SALDO DE  APERTURA  ");
            double saldoApertura = double.Parse(Console.ReadLine());

            Console.WriteLine(" ¿ QUE DESEAS HACER ?\n " +
                              " (1)-> CONSIGNAR A TU CUENTA ::\n  " +
                              "(2)-> HACER UNA TRANSFERENCIA \n " +
                              "(3)-> RETIRO ");

            int opcion = Int32.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("INGRESE EL MONTO A CONSIGNAR ");
                double consignacion = double.Parse(Console.ReadLine());

                double saldoFinal = saldoApertura + consignacion;

                Console.WriteLine(" SEÑOR " + nombre +" SU SALDO ES DE : "+saldoFinal);

            }
            if(opcion == 2)
            {
                Console.WriteLine("INGRESE LA CUENTA A LA QUE VA A TRANFERIR ");

                string transferencia = (Console.ReadLine());

                Console.WriteLine("INGRESE EL MONTO A TRANFERIR ");

                double valorTranfe = double.Parse(Console.ReadLine());

                Console.WriteLine(" SEÑOR " + nombre + " SU SALDO ES DE : " +( saldoApertura-valorTranfe));


            }
            if (opcion == 3)
            {
                Console.WriteLine("INGRESE  EL VALOR QUE VA A RETIRAR ");
                double retiro = double.Parse(Console.ReadLine());

                Console.WriteLine(" SEÑOR " + nombre + " SU SALDO ES DE : " + (saldoApertura - retiro));


            }


        }

    }
}
