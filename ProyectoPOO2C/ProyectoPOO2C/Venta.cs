using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO2C
{
    internal class Venta
    {
        public string Producto { get; set; }
        public double Precio { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; } 

        public Venta(string producto, double precio, int cantidad)
        {
            Producto = producto;
            Precio = precio;
            Cantidad = cantidad;
            Fecha = DateTime.Now;
        }
    }
}
