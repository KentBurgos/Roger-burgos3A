using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comidita.clasescomi
{
    public class producto
    {
       

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private float precio;

        
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }


    }
}
