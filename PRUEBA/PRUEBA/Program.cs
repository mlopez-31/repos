using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEBA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            int edad = 25;
            double peso = 70.5;
            float altura = 1.75f;
            bool esMayor = true;
            char inicial = 'K';
            string nombre = "Kevin";

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("¿Es mayor de edad?: " + esMayor);
            Console.WriteLine("Inicial: " + inicial);


        }


    }
}
