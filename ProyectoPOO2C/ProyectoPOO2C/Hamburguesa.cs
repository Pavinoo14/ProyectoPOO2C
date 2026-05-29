using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoPOO2C
{
    internal class Hamburguesa : Producto
    {
        public int QuesoExtra { get; set; }

        public Hamburguesa(string nombre, double precio, int quesoExtra) : base(nombre, precio)
        {
            QuesoExtra = quesoExtra;
        }

        public override double CalcularPrecio()
        {
            return Precio + (QuesoExtra * 10);
        }

        public override string MostrarInfo()
        {
            return Nombre + " | Queso Extra: " + QuesoExtra + " | $" + CalcularPrecio();
        }
    }
}
