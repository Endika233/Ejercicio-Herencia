using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    class Entrenador:SeleccionFutbol
    {
        private string titulacion;
        private int añosExperiencia;
        public Entrenador()
        {

        }
        public Entrenador(int id,string nombre,string apellido,int edad,string titulacion,int añosExperiencia) : base(id, nombre, apellido, edad)
        {
            this.titulacion = titulacion;
            this.añosExperiencia = añosExperiencia;
        }
        public void ShowAll1()
        {
            base.ShowAll();
            Console.WriteLine("Titulación: " + titulacion + "\nAños de experiencia: " + añosExperiencia);
        }
    }
}
