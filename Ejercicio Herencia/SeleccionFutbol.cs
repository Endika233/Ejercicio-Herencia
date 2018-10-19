using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    class SeleccionFutbol
    {
        private int id, edad;
        private string nombre, apellido;
        private static int contadorIntegrantes;
        public SeleccionFutbol()
        {
            contadorIntegrantes++;
        }
        public SeleccionFutbol(int id,string nombre,string apellido,int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            contadorIntegrantes++;
        }
        public void Concentrarse()
        {

        }
        public void Viajar()
        {

        }
        public void ShowAll()
        {
            Console.WriteLine("Id: "+id+"\nNombre: "+nombre+"\nApellido: "+apellido+"\nEdad: "+edad);
        }
        public int GetIntegrantes()
        {
            return contadorIntegrantes;
        }


    }
}
