using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1P
{
    public class Camioneta: Vehículo, IVehículo
    {
        public Camioneta(string tipoCabina, string marca, string modelo, int añoCreación) 
            : base(marca, modelo, añoCreación)
        {
            TipoCabina = tipoCabina;
        }

        private string tipoCabina;
        public string TipoCabina
        {
            get { return tipoCabina; }
            set { tipoCabina = value; }
        }

        int precio;
        public override string Cobrar()
        {
            if (TipoCabina == "Cabina Doble")
            {
                precio = 20000;
            }
            else
            {
                if (TipoCabina == "Cabina Simple")
                {
                    precio = 15000;
                }
            }
            return " El precio de la camioneta es: " +precio;
        }

        public string Cobrar1()
        {
            if (TipoCabina == "Cabina Doble")
            {
                precio = 20000;
            }
            else
            {
                if (TipoCabina == "Cabina Simple")
                {
                    precio = 15000;
                }
            }
            return " El precio de la camioneta es: " + precio;
        }
    }
}
