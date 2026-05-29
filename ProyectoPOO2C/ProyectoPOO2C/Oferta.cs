using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO2C
{
    internal class Oferta
    {
        public static double AplicarOferta(double total)
        {
            DayOfWeek dia = DateTime.Now.DayOfWeek;

            switch (dia)
            {
                case DayOfWeek.Monday:
                    return total * 0.90;
                case DayOfWeek.Tuesday:
                    return total * 0.85;
                case DayOfWeek.Friday:
                    return total * 0.80;
                default:
                    return total;
            }
        }

        public static string MostrarOferta()
        {
            DayOfWeek dia = DateTime.Now.DayOfWeek;

            switch (dia)
            {
                case DayOfWeek.Monday:
                    return "Lunes 10% en bebidas";
                case DayOfWeek.Tuesday:
                    return "Martes 15% en tacos";
                case DayOfWeek.Friday:
                    return "Viernes 20% en hamburguesas";
                default:
                    return "Sin ofertas";
            }
        }
    }
}
