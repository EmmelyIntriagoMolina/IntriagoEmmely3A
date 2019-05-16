using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntriagoEmmely3A.clases;
using IntriagoEmmely3A.Interfaces;

namespace IntriagoEmmely3A
{
    class Program
    {
        static void Main(string[] args)
        {
            
            new Cliente("Emmely","Intriago Moliina", 1317910071, "Cdla Elegolé").mostrar();
            new Gasolina("Extra", 10, 1.5).mostrar();
            new Gasolina("Super", 3, 2.0).calculo();
            Console.ReadKey();
            

        }
    }
}
