using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA3_02
{
    class Nodo
    {
        private int dato;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        //apuntamos al siguiente nodo
        private Nodo siguiente;

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        //apuntodo al nodo anterior
        private Nodo atras;

        public Nodo Atras
        {
            get { return atras; }
            set { atras = value; }
        }

        public Nodo()
        {
            dato = 0;
            siguiente = null;
        }

        public Nodo (int dat, Nodo sigui)
        {
            Dato = dat;
            Siguiente = sigui;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
