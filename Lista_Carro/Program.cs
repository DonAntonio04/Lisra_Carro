using System;

namespace Lista_Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista_Carro listaCarros = new Lista_Carro();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Ingrese los datos del carro {i}:");
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();

                Console.Write("Marca: ");
                string marca = Console.ReadLine();

                Console.Write("Año: ");
                int year = int.Parse(Console.ReadLine());

                Carro nuevoCarro = new Carro(modelo, marca, year);
                listaCarros.InsertarFlota(nuevoCarro);
            }

     
            listaCarros.Mostar();

            Console.Write("\nIngrese la marca a buscar: ");
            string marcaBuscar = Console.ReadLine();
            listaCarros.BuscarMarca(marcaBuscar);

            listaCarros.ordenarDecedente();

            Console.WriteLine("\nEsta es la lista de carros ordenada de manera descendente:");
            listaCarros.Mostar();

        }
    }
}
