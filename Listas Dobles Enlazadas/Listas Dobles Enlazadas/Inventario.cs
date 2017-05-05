using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Dobles_Enlazadas
{
    class Inventario
    {//Buscar y borrar igual.
        public Producto inicio { get; set; }
        public Producto ultimo { get; set; }
        //Producto temp;

        public void Agregar(Producto nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = inicio;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;
                ultimo = nuevo;
            }
        }

        public void AgregarEnInicio(Producto nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = inicio;
            }
            else
            {
                nuevo.siguiente = inicio;
                inicio = nuevo;
                inicio.anterior = null;
            }
        }

        public Producto Buscar(int cod)
        {
            Producto x = null;
            Producto b = inicio;

            while (b != null && b.codigo <= cod)
            {
                if (b.codigo == cod)
                {
                    x = b;
                    break;
                }
                else
                    b = b.siguiente;
            }
            return x;
        }

        public void Insertar(Producto nuevo, int pos)
        {
            int contador = 1;
            Producto tem = inicio;

            if (pos == 1)
            {
                nuevo.siguiente = inicio;
                inicio = nuevo;
            }
            else
            {
                while (tem.siguiente != null && contador < pos - 1)
                {
                    tem = tem.siguiente;
                    contador++;
                }
                nuevo.siguiente = tem.siguiente;
                tem.siguiente = nuevo;
            }
        }

        public void Borrar(int cod)
        {
            if (inicio != null)
            {
                Producto b = inicio;
                if (inicio.codigo == cod)
                {
                    inicio = inicio.siguiente;

                }
                else
                    while (b != null && b.codigo <= cod)
                    {

                        if (b.siguiente.codigo == cod)
                        {
                            b.siguiente = b.siguiente.siguiente;
                            break;
                        }
                        else
                            b = b.siguiente;
                    }
            }
        }

        public string Reporte()
        {
            string datos = "";
            Producto t = inicio;
            while (t != null)
            {
                datos += t.ToString();
                t = t.siguiente;
            }
            return datos;
        }

        public string ReporteInvertido()
        {
            string datos = "Reporte Vacio";
            Producto temp = inicio;
            if (temp == null)
                return datos;
            else
                return ReporteInvertido(temp);
        }

        private string ReporteInvertido(Producto temp)
        {
            if (temp.siguiente == null)
                return temp.ToString();
            else
            {
                return ReporteInvertido(temp.siguiente) + temp.ToString();
            }
        } 

        public void eliminarPrimero()
        {
            if (inicio != null)
            {
                inicio = inicio.siguiente;
                inicio.anterior = null;
            }
        }

        public void eliminarUltimo()
        {
            if(inicio != null)
            {
                ultimo = ultimo.anterior;
                ultimo.siguiente = null;
            }
        }
    }
}
