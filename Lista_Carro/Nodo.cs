using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Carro
{
    public class Nodo
    {
        private Carro _valor;
        private Nodo _siguiente;

        public Carro Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

         public Nodo(Carro Valor)
        {
            _valor = Valor;
            _siguiente = null;
        }
        public Nodo(Carro Valor,Nodo Siguiente)
        {
            this._siguiente = Siguiente;
            this._valor= Valor;
        }

    }
}
