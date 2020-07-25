using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1P
{
    public class Furgoneta: Vehículo, IVehículo
    {
        public Furgoneta(int numAsientos, int precioBase, int precioAsiento, string marca, string modelo, int añoCreación) 
            : base(marca, modelo, añoCreación)
        {
            NumAsientos = numAsientos;
            PrecioAsiento = precioAsiento;
            PrecioBase = precioBase;
        }

        private int numAsientos;
        public int NumAsientos
        {
            get { return numAsientos; }
            set { numAsientos = value; }
        }

        private int precioBase;
        public int PrecioBase
        {
            get { return precioBase; }
            set { precioBase = value; }
        }

        private int precioAsiento;
        public int PrecioAsiento
        {
            get { return precioAsiento; }
            set { precioAsiento = value; }
        }

       
        public override string Cobrar()
        {
           int precio = precioBase + (precioAsiento * numAsientos);
            return "El precio de la furgoneta es: " +precio;
        }

        public string Cobrar1()
        {
            int precio = precioBase + (precioAsiento * numAsientos);
            return "El precio de la furgoneta es: " + precio;
        }
    }
}
