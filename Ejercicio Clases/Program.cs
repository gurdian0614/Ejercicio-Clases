using Ejercicio_Clases;

//Creamos un objeto
Ave ave = new Ave();
ave.Nombre = "Pajaro";
ave.Tamano = "Pequeño";
ave.Color = "Naranja";
ave.Familia.Nombre = "Ave";
ave.Familia.Grupo = "Voladoras";
ave.SexoBiologico = "Macho";
ave.imprimir();

Ave ave2 = new Ave("Pinguino");
ave2.Tamano = "Pequeño";
ave2.Color = "Negro y Blanco";
ave2.Familia.Nombre = "Pinguinos";
ave2.Familia.Grupo = "No Voladoras";
ave2.SexoBiologico = "Hembra";
ave2.EsVoladora = false;
ave2.imprimir();