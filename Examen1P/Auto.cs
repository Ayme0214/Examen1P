using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1P
{
    public class Auto: Vehículo, IVehículo
    {
        public Auto(int precioVehículo, string marca, string modelo, int añoCreación) 
            : base(marca, modelo, añoCreación)
        {
            PrecioVehículo = precioVehículo;
        }

        private double precioVehículo;
        public double PrecioVehículo
        {
            get { return precioVehículo; }
            set { precioVehículo = value; }
        }

        double precio, descuento;
        public override string Cobrar()
        {
            if (Marca == "Sedan")
            {
                precioVehículo = precio;
            }
            else
            {
                if (Marca == "Hatchback")
                {
                    descuento = precio * 0.10; 
                    precioVehículo = precio - descuento;
                }
            }
            return "El precio del auto es: " +precioVehículo;
        }

        public string Cobrar1()
        {
            if (Marca == "Sedan")
            {
                precioVehículo = precio;
            }
            else
            {
                if (Marca == "Hatchback")
                {
                    descuento = precio * 0.10; 
                    precioVehículo = precio - descuento;
                }
            }
            return "El precio del auto es: " + precioVehículo;
        }
    }
}
