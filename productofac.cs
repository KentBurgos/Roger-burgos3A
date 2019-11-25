using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comidita.clasescomi
{
    public class productofac
    {

        private producto producto;

        public producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        private factura factura;

        public factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }
   

        private float subtotal1;

        public float Subtotal1
        {
            get { return subtotal1; }
            set { subtotal1 = value; }
        }

    }
}
