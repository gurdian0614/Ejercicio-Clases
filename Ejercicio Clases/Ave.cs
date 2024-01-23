using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases
{
    internal class Ave
    {
        public string Nombre { get; set; }

        public string Color { get; set; }

        public string Tamano { get; set; }
        
        public FamiliaAve Familia { get; set; }

        public string SexoBiologico { get; set; }

        public bool EsVoladora { get; set; }

        //Constructor
        public Ave()
        {
            EsVoladora = true;
            Familia = new FamiliaAve();
        }

        public Ave(string nombre)
        {
            Nombre = nombre;
            EsVoladora = true;
            Familia = new FamiliaAve();
        }

        public void imprimir()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Familia: {Familia.Nombre}");
            Console.WriteLine($"Grupo Familia: {Familia.Grupo}");
            Console.WriteLine($"Sexo: {SexoBiologico}");
            Console.WriteLine($"Es Voladora: {EsVoladora}");
        }
    }
}
