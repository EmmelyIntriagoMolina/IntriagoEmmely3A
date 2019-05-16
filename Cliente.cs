using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntriagoEmmely3A.Interfaces;


namespace IntriagoEmmely3A.clases
{
    class Cliente:IDatos
    {
        public Cliente(string nombres, string apellidos, int cédula, string direccion)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Cedula = cedula;
            Direccion = direccion;
        }

        private string nombres;
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        
        private int cedula;
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public void mostrar()
        {
            Console.WriteLine(" Nombres: " + nombres);
            Console.WriteLine(" Apellidos: " + apellidos);
            Console.WriteLine(" Numero de Cedula: " + cedula);
            Console.WriteLine(" Direccion: " + direccion);

        }
    }
}
