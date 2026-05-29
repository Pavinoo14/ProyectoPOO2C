using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoPOO2C
{
    internal class Taco : Producto
    {
        public string TipoTaco { get; set; }
        public string TipoTortilla { get; set; }

        public Taco(string nombre, double precio, string tipoTaco, string tipoTortilla) : base(nombre, precio)
        {
            TipoTaco = tipoTaco;    
            TipoTortilla = tipoTortilla;
        }

        public override double CalcularPrecio()
        {
            return Precio;
        }

        public override string MostrarInfo()
        {
            return Nombre + " | Tortilla: " + TipoTortilla + " | $" + CalcularPrecio();
        }
    }
}
