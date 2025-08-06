using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL2
{
    public class InfoExtra
    {
        public string Nombre { get; set; }
    }
    public class Proyecto2
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public InfoExtra Extra { get; set; }
        public void MostrarMensaje()
        {
            Console.WriteLine("Este es el mensaje desde la DLL 2");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Monto: {Monto}");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Extra.Nombre: {Extra?.Nombre}");
        }
    }
}

