using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO2C
{
    internal class Bebida : Producto
    {
        public string Tamaño { get; set; }

        public Bebida(string nombre, double precio, string tamaño) : base(nombre, precio)
        {
            Tamaño = tamaño;
        }

        public override double CalcularPrecio()
        {
            if (Tamaño == "Grande")
            {
                return Precio + 15;
            }

            return Precio;
        }

        public override string MostrarInfo()
        {
            return Nombre + " | Tamaño: " + Tamaño + " | $" + CalcularPrecio();
        }
    }
}
