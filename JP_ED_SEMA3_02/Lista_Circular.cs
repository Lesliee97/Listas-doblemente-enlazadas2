using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA3_02
{
    class Lista_Circular
    {
        private Nodo primero;

        private Nodo Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public Lista_Circular()
        {   //empieza la lista vacia
            primero = null;
        }

        public bool Agregar(Nodo n)
        {
            Nodo h = primero;
            //si la lista esta vacia agrega el primer nodo de la lista
            if(primero == null)
            {
                n.Atras = n;
                n.Siguiente = n;
                primero = n;
                return true;
            }
            if(Buscar(n.Dato))
            {
                return false;
            }
            if(n.Dato < primero.Dato)
            {
                primero.Atras.Siguiente = n;
                n.Atras = primero.Atras;
                n.Siguiente = primero;
                primero.Atras = n;
                primero = n;
                return true;
            }
            do
            {
                //agregar en medio o final
                if (n.Dato < h.Siguiente.Dato)
                {
                    break;
                }
            } while (h != primero);
            if(n.Dato < h.Siguiente.Dato)
            {
                h.Siguiente.Atras = n;
                n.Atras = h;
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
            }
            else
            {
                n.Siguiente = h;
                n.Atras = h.Atras;
                h.Atras.Siguiente = n;
                h.Atras = n; 
            }
            return true;
        }

        public bool Buscar(int b)
        {
            Nodo h = primero;
            if(h!=null)
            {
                do
                {
                    if (h.Dato == b)
                    {
                        return true;
                    }
                    h = h.Siguiente;
                } while (h != primero);
            }
            return false;
        }

        public int ContarNodos()
        {
            int cuenta = 0;
            if(primero != null)
            {
                Nodo h = primero;
                do
                {
                    cuenta++;
                    h = h.Siguiente;
                } while (h != primero);
            }
            return cuenta;
        }

        public string MostrarDatos()
        {
            Nodo h = primero;
            string s = "";
            do
            {
                s += h.Dato + "-";
                h = h.Siguiente;
            } while (h != primero);
            return s;
        }

        public string MostrarDatosAnt()
        {
            Nodo h = primero;
            string s = "";
            do
            {
                s += h.Atras.Dato;
                h = h.Atras;
            } while (h != primero);
            return s;
        }

        public void Vaciar()
        {
            primero = null;
        }
        public bool Eliminar(int b)
        {
            if(Buscar(b))
            {
                Nodo h = primero;
                while(h.Siguiente !=primero)
                {
                    if(h.Dato == b)
                    {
                        break;
                    }
                    h = h.Siguiente;
                }
                h.Atras.Siguiente = h.Siguiente;
                h.Siguiente.Atras = h.Atras;
                if(h == primero)
                {
                    primero = primero.Siguiente;
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string lista = "";
            Nodo h = primero;
            if (h != null)
            {
                do
                {
                    lista += h.Dato + "" + h.Dato;
                    h = h.Siguiente;
                } while (h != primero);
                return lista;
            }
            return lista = "No hay NADA";
        }
        
    }
}
