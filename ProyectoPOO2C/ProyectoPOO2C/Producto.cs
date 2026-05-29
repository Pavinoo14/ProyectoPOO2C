using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO2C
{
    abstract class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public abstract double CalcularPrecio();

        public virtual string MostrarInfo()
        {
            return Nombre + " $" + Precio;
        }
    }
}
