using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    class SeleccionPais
    {
        private string NombreSeleccion;
        private List<SeleccionFutbol> Seleccion = new List<SeleccionFutbol>();
        private static int Participantes,EntrenadorContador,MasajistaContador,FutbolistaContador;
        public SeleccionPais()
        {
            Participantes++;
        }
        public SeleccionPais(SeleccionFutbol objeto)
        {
            Participantes++;
            if (objeto.GetType().Name == "Entrenador"&&Participantes<30&&EntrenadorContador<2)
            {
                Seleccion.Add(objeto);
                EntrenadorContador++;
            }
            else if ( objeto.GetType().Name == "Masajista"&&Participantes<30&&MasajistaContador<4)
            {
                Seleccion.Add(objeto);
                MasajistaContador++;
            }
            else if (objeto.GetType().Name == "Futbolista"&&Participantes<30)
            {
                Seleccion.Add(objeto);
                FutbolistaContador++;
            }
        }
        public void MostrarDatosSeleccion()
        {
            Console.WriteLine("\t\t\tSelección de " + NombreSeleccion);
            foreach (SeleccionFutbol miembros in Seleccion)
            {
                miembros.ShowAll();
            }
        }
    }
}
