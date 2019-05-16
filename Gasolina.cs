using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntriagoEmmely3A.Interfaces;

namespace IntriagoEmmely3A.clases
{
    
        class Gasolina : ICalculo, IDatos
        {
            private string tipo;
            public string Tipo
            {
                get { return tipo; }
                set { tipo = value; }
            }

            private int cantidadGal;
            public int CantGal
            {
                get { return cantidadGal; }
                set { cantidadGal = value; }
            }

            private double precioVenta;
            public double PreVenta
            {
                get { return precioVenta; }
                set { precioVenta = value; }
            }

        public Gasolina(string tipo, int cantGal, double preVenta)
        {
            Tipo = tipo;
            CantGal = cantGal;
            PreVenta = preVenta;
        }

        public void calculo()
            {
                double precio = 0;
                if (tipo == " Extra " || tipo == " extra ")
                {
                    precio = 1.5;
                    double Subtotal = precio * cantidadGal;
                    double IVA = (precio * cantidadGal) * 12 / 100;
                    double Total = Subtotal + IVA;

                    Console.WriteLine(" Subtotal: " + Subtotal);
                    Console.WriteLine(" IVA: " + IVA);
                    Console.WriteLine(" Total: " + Total);
                }
                else
                {
                    precio = 2.0;
                    double Subtotal = precio * cantidadGal;
                    double IVA = (precio * cantidadGal) * 12 / 100;
                    double Total = Subtotal + IVA;

                    Console.WriteLine(" Subtotal: " + Subtotal);
                    Console.WriteLine(" IVA: " + IVA);
                    Console.WriteLine(" Total: " + Total);
                }

            }
            public void mostrarDatos()
            {
                Console.WriteLine(" Tipo de gasolina: " + tipo);
                Console.WriteLine(" Cantidad de Galones:   " + cantidadGal);
                Console.WriteLine(" Precio de venta: " + precioVenta);
            }
        }


    }
}
