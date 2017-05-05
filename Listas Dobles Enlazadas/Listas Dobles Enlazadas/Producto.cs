using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Dobles_Enlazadas
{
    class Producto
    {
        private int _codigo;
        public int codigo { get { return _codigo; } set { _codigo = value; } }
        private string _nombre;
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        private int _cantidad;
        public int cantidad { get { return _cantidad; } set { _cantidad = value; } }
        private int _precio;
        public int precio { get { return _precio; } set { _precio = value; } }

        public Producto siguiente { get; set; }
        public Producto anterior { get; set; }

        public Producto()
        {
            _codigo = 0;
            _nombre = "";
            _cantidad = 0;
            _precio = 0;
            siguiente = null;
        }

        public override string ToString()
        {
            return "PRODUCTO: " + Environment.NewLine + "  Código:    " + _codigo + Environment.NewLine + "  Nombre:   " + _nombre + Environment.NewLine + "  Cantidad: " + _cantidad + Environment.NewLine + "  Precio:   $" + _precio + Environment.NewLine + Environment.NewLine;
        }
    }
}
