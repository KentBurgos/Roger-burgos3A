using comidita.clasescomi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comidita.clasescomi;

namespace comidita
{
    class Program
    {
        static void Main(string[] args)
        {

            factura factura = new factura();
            cliente cliente = new cliente();
            producto producto = new producto();

            Console.WriteLine("Ingrese Identificación: ");
            cliente.Identificacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nombre: ");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Dirección: ");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese Telefono: ");
            cliente.Telefono = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el codigo del producto: ");
            producto.Codigo = int.Parse(Console.ReadLine());


            Console.WriteLine("Subtotal: "+factura.Subtotal);
            Console.WriteLine("Iva: "+factura.Iva);
            Console.WriteLine("Ingrese descuento"+factura.Descuento);
            factura.Descuento = int.Parse(Console.ReadLine());
            Console.WriteLine("Total final"+factura.Total);


        }
    }
}
