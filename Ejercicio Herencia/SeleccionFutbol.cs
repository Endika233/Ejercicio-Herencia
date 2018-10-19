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
        private bool concentrarse=true, viajar=true;//TODO:Le he asignado viajar true para no cambiarlo en el main uno a uno
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
        public void SetConcentrarse(bool concentrarse)
        {
            this.concentrarse = concentrarse;
        }
        public void SetViajar(bool viajar)
        {
            this.viajar = viajar;
        }
        public bool GetConcentrarse()
        {
            return concentrarse;
        }
        public bool GetViajar()
        {
            return viajar;
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
