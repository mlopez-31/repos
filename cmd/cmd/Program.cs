using System;
using DLL1;
using DLL2;

namespace cmd
{
    class Program
    {
        static void Main(string[] args)
        {

            Proyecto1 p1 = new Proyecto1
            {
                Nombre = "Miguel",
                Edad =   30,
                Monto =  100.50,
                Fecha =  DateTime.Now,
                Extra =  new InfoExtra {  Nombre = "TechSoft"}
            
            };

            proyecto2 p2 = p1.Llenarproyecto2();

            Console.WriteLine("Esta es la dll 2");

            Console.WriteLine($"Nombre: {p2.Nombre}");
            Console.WriteLine($"Edad: {p2.Edad}");
            Console.WriteLine($"Monto: {p2.Monto}");
            Console.WriteLine($"Fecha: {p2.Fecha}");
            Console.WriteLine($"Extra.Nombre: {p2.Extra?.Nombre}");


            Console.ReadKey();
        }
    }
}
