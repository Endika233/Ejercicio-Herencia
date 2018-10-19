using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    class Futbolista:SeleccionFutbol
    {
        private int dorsal;
        private string demarcacion;
        public Futbolista()
        {

        }
        public Futbolista(int id,string nombre,string apellido,int edad,int dorsal,string demarcacion) : base(id, nombre, apellido, edad)
        {
            this.dorsal = dorsal;
            this.demarcacion = demarcacion;
        }
        public void ShowAll1()
        {
            base.ShowAll();
            Console.WriteLine("Dorsal: " + dorsal + "\n Demarcación: " + demarcacion);
        }
    }
}
