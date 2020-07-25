using System;


namespace Examen1P
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Software para el control de los vehículos");
            Console.WriteLine();

            
            Console.WriteLine("Autos");
            Auto auto = new Auto(25000, "Kia", "Sedan", 2000);
            Auto auto1 = new Auto(23000, "Mazda", "Hatchback", 2004);
            auto.ListaVehículos.Add(auto);
            auto1.ListaVehículos.Add(auto1);
            foreach (var autos in auto.ListaVehículos)
            {
                Console.WriteLine("Vehículo: " +"Marca: "+ auto.Marca + " Modelo: "  + auto.Modelo + " Año: " + auto.AñoCreación + " Precio: " + auto.PrecioVehículo);
                Console.WriteLine(auto.Cobrar());
            }
            foreach (var autos in auto1.ListaVehículos)
            {
                Console.WriteLine("Datos: " +"Marca: "+ auto1.Marca + " Modelo: " + auto1.Modelo + " Año: " + auto1.AñoCreación + " Precio: " + auto1.PrecioVehículo);
                Console.WriteLine(auto1.Cobrar());
            }

            Console.WriteLine();
            Console.WriteLine("Camionetas");
            Camioneta camioneta = new Camioneta("Cabina Doble", "Toyota", "4x4", 1990);
            Camioneta camioneta1 = new Camioneta("Cabina Simple", "Toyota", "Hilux", 2020);
            camioneta.ListaVehículos.Add(camioneta);
            camioneta1.ListaVehículos.Add(camioneta1);

            foreach (var camionetas in camioneta.ListaVehículos)
            {
                Console.WriteLine("Datos: " +"Marca: " + camioneta.Marca + " Modelo: " + camioneta.Modelo + " Año: " + camioneta.AñoCreación + " Tipo: " + camioneta.TipoCabina);
                Console.WriteLine(camioneta.Cobrar1());
            }
            foreach(var camionetas in camioneta1.ListaVehículos)
            {
                Console.WriteLine("Datos: " +"Marca: "+ camioneta1.Marca + " Modelo: " + camioneta1.Modelo + " Año: " + camioneta1.AñoCreación + " Tipo: " + camioneta1.TipoCabina);
                Console.WriteLine(camioneta1.Cobrar1());
            }

            Console.WriteLine();
            Console.WriteLine("Furgonetas");
            Furgoneta furgoneta = new Furgoneta(8, 20000, 500, "Hyundai", "H1", 2013);
            Furgoneta furgoneta1 = new Furgoneta(14, 20000, 500, "Chevrolet", "N300", 2018);
            furgoneta.ListaVehículos.Add(furgoneta);
            furgoneta1.ListaVehículos.Add(furgoneta1);

            foreach (var furgonetas in furgoneta.ListaVehículos)
            {
                Console.WriteLine("Datos: " +"Marca: " + furgoneta.Marca + " Modelo: " + furgoneta.Modelo + " Año: " + furgoneta.AñoCreación + " Num. Asientos: " + furgoneta.NumAsientos + " Precio Asientos: " + furgoneta.PrecioAsiento + " Precio Base: " + furgoneta.PrecioBase);
                Console.WriteLine(furgoneta.Cobrar1());
            }
            foreach (var furgonetas in furgoneta1.ListaVehículos)
            {
                Console.WriteLine("Datos: " +"Marca: " + furgoneta1.Marca + " Modelo: " + furgoneta1.Modelo + " Año: " + furgoneta1.AñoCreación + " Num. Asientos: " + furgoneta1.NumAsientos + " Precio Asiento: " + furgoneta1.PrecioAsiento + " Precio Base: " + furgoneta1.PrecioBase);
                Console.WriteLine(furgoneta1.Cobrar1());
            } Console.ReadKey();
        }
    }
}
