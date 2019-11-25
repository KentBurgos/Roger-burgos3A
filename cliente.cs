using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comidita.clasescomi
{
    public class cliente
    {
       


        private int identificacion;

        public int Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private productofac productofac;

        public productofac Productofac
        {
            get { return productofac; }
            set { productofac = value; }
        }



    }
}
