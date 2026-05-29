using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO2C
{
    internal class Papas : Producto
    {
        public string Tamaño { get; set; }

        public Papas(string nombre, double precio, string tamaño) : base(nombre, precio)
        {
            Tamaño = tamaño;
        }

        public override double CalcularPrecio()
        {
            return Precio;
        }

        public override string MostrarInfo()
        {
            return Nombre + " | Picante: " + Tamaño + " | $" + CalcularPrecio();
        }
    }
}
