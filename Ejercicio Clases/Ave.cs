using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases
{
    internal class Ave
    {
        public string? Nombre;

        public string? Color;

        public string? Tamano;

        public string? Familia;

        public string? SexoBiologico;

        public bool? EsVoladora;

        //Constructor
        public Ave()
        {
            EsVoladora = true;
        }

        public void imprimir()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Sexo: {SexoBiologico}");
            Console.WriteLine($"Es Voladora: {EsVoladora}");
        }
    }
}
