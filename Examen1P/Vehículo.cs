using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1P
{
    public abstract class Vehículo
    {
        public Vehículo(string marca, string modelo, int añoCreación) //constructor
        {
            this.marca = marca;
            this.modelo = modelo;
            this.añoCreación = añoCreación;
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }


        private int añoCreación;
        public int AñoCreación
        {
            get { return añoCreación; }
            set { añoCreación = value; }
        }

        public abstract string Cobrar(); //Método para mostrar los datos de las propiedades de la entidad
        

        public List<Vehículo> ListaVehículos = new List<Vehículo>();
    }
}
