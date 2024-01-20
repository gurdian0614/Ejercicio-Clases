using Ejercicio_Clases;

//Creamos un objeto
Ave ave = new Ave();
ave.Nombre = "Pajaro";
ave.Tamano = "Pequeño";
ave.Color = "Naranja";
ave.Familia = "Ave";
ave.SexoBiologico = "Macho";
ave.imprimir();

Ave ave2 = new Ave();
ave2.Nombre = "Pinguino";
ave2.Tamano = "Pequeño";
ave2.Color = "Negro y Blanco";
ave2.Familia = "Pinguinos";
ave2.SexoBiologico = "Hembra";
ave2.EsVoladora = false;
ave2.imprimir();

Ave ave3 = new Ave();
ave3.Nombre = "Pinguino";
ave3.Tamano = "Pequeño";
ave3.Color = "Negro y Blanco";
ave3.Familia = "Pinguinos";
ave3.SexoBiologico = "Hembra";
ave3.EsVoladora = false;
Imprimir(ave3);

void Imprimir(Ave ave)
{
    Console.WriteLine($"Nombre: {ave.Nombre}");
    Console.WriteLine($"Tamaño: {ave.Tamano}");
    Console.WriteLine($"Color: {ave.Color}");
    Console.WriteLine($"Familia: {ave.Familia}");
    Console.WriteLine($"Sexo: {ave.SexoBiologico}");
    Console.WriteLine($"Es Voladora: {ave.EsVoladora}");
}