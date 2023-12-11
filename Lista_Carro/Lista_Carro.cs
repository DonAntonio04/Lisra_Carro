using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lista_Carro
{
     public class Lista_Carro
     {
        Nodo Primero;


        public Lista_Carro()
        {
            Primero = null;
        }

        public bool ListaVacia()
        {
            return Primero == null;
        }
        public void InsertarFlota(Carro nuevoCarro)
        {
            Nodo nodoActual = new Nodo(nuevoCarro);
            if (ListaVacia())
            {
                Primero = nodoActual;
                return;
            }

            Nodo actual = Primero;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = nodoActual;
        }
        public void BuscarMarca(string marca)
        {
            Nodo actual = Primero;
            int POSICION = 0;
            bool encontrado = false;

            while (actual != null)
            {
                if (actual.Valor.Marca == marca)
                {
                    Console.WriteLine($"Carro encontrado con la marca {marca}");
                    Console.WriteLine(actual.Valor);
                    encontrado = true;
                    break;
                }

                actual = actual.Siguiente;
                POSICION++;
            }

            if (!encontrado)
            {
                Console.WriteLine($"No se encontraron carros con la marca {marca}.");
            }
        }
      
        public void ordenarDecedente()
        {
            if (ListaVacia() || Primero.Siguiente == null)
            {
                // La lista está vacía o tiene un solo elemento, no es necesario ordenar.
                return;
            }

            bool ordenar;
            do
            {
                ordenar = false;
                Nodo Actual = Primero;
                Nodo siguiente = Primero.Siguiente;

                while (siguiente != null)
                {
                    if (Actual.Valor.Year < siguiente.Valor.Year)
                    {
                        Carro temp = Actual.Valor;
                        Actual.Valor = siguiente.Valor;
                        siguiente.Valor = temp;

                        ordenar = true;
                    }

                    Actual = siguiente;
                    siguiente = siguiente.Siguiente;
                }
            } while (ordenar);
        }

        public void Mostar()
        {
            Nodo actual = Primero;

            if (actual == null)
            {
                Console.WriteLine("La lista de carros está vacía.");
                return;
            }

            Console.WriteLine($"Lista de carros:");

            while (actual != null)
            {
                Console.WriteLine(actual.Valor);
                actual = actual.Siguiente;
            }
        }
    }
}
