using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL2;

namespace DLL1
{
    public class Proyecto1
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public InfoExtra Extra { get; set; }

        public Proyecto1()
        {
            Console.WriteLine("Esta es la dll 1");
        }

        public proyecto2 Llenarproyecto2()
        {
            proyecto2 p2 = new proyecto2
            {
                Nombre = this.Nombre,
                Edad = this.Edad,
                Monto = this.Monto,
                Fecha = this.Fecha,
                Extra = this.Extra
            };
            return p2;
        }
    }
}

