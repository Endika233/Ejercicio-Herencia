using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    class Masajista : SeleccionFutbol
    {
        private string idFederacion;
        public Masajista()
        {

        }
        public Masajista(int id, string nombre, string apellido, int edad, string idFederacion) : base(id, nombre, apellido, edad)
        {
            this.idFederacion = idFederacion;
        }
        public override void ShowAll()
        {
            base.ShowAll();
            Console.WriteLine("Id Federación: " + idFederacion);
        }
    }
}
