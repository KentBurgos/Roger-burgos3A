using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comidita.clasescomi
{
     public class factura
    {
       

        public factura()
        {
        }

        private int numerofac;

        public int Numerofac
        {
            get { return numerofac; }
            set { numerofac = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private cliente cliente;

        public cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private List<producto> listaproducto;
       
        public List<producto> ListaProducto
        {
            get { return listaproducto; }
            set { listaproducto = value; }
        }

        private float subtotal;

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        private float descuento;

        public float Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        private float subtotaldesc;

        public float SubtotalDesc
        {
            get { return subtotaldesc; }
            set { subtotaldesc = value; }
        }

        private float iva;

        public float Iva
        {
            get { return iva= subtotaldesc* 0.12f ; }
            set { iva = value; }
        }

        private float total;

        
        public float Total
        {
            get { return total; }
            set { total = value; }
        }


    }
}
