using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Carro
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Year { get; set; }

        public Carro(string modelo, string marca, int year)
        {
            Modelo = modelo;
            Marca = marca;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Marca}, {Modelo}, {Year}";
        }


    }
}
