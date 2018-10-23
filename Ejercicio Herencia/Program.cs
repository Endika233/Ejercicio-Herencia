using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            SeleccionPais Uganda = new SeleccionPais("Uganda");
            Entrenador e1 = CrearEntrenador(1, "Poter", "Lopez", 49, "Nivel Máximo", 18);
            Masajista m1 = CrearMasajista(2, "Pitxon", "Llamosas", 38, "Club Artemis");
            Masajista m2 = CrearMasajista(3, "Pezu", "González", 28, "Mesón Baytur");
            Futbolista f1=CrearFutbolista(4, "Txema", "Bayón", 37, 18, "Delantero");
            Futbolista f2 = CrearFutbolista(5, "Rakel", "Cortés", 29, 8, "Portero");
            Futbolista f3 = CrearFutbolista(6, "Marpe", "Marcelino", 32, 0, "Defensa");
            Futbolista f4 = CrearFutbolista(7, "Naiara", "Tataya", 30, 99, "Centro");
            Uganda.AltaSeleccion(e1); Uganda.AltaSeleccion(e1); Uganda.AltaSeleccion(e1);//Prueba tope entrenadores
            Uganda.AltaSeleccion(m1);
            Uganda.AltaSeleccion(m2);
            Uganda.AltaSeleccion(f1);
            Uganda.AltaSeleccion(f2);
            Uganda.AltaSeleccion(f3);
            Uganda.AltaSeleccion(f4);
            Uganda.MostrarDatosSeleccion();
            Uganda.BajaSeleccion(e1);
            Uganda.BajaSeleccion(e1);
            Uganda.MostrarDatosSeleccion();
            //SeleccionFutbol Seleccion = new SeleccionFutbol();
            //List<SeleccionFutbol> Uganda = new List<SeleccionFutbol>();
            //List<Entrenador> UgandaEntrenador = new List<Entrenador>();
            //List<Masajista> UgandaMasajista = new List<Masajista>();
            //List<Futbolista> UgandaFutbolista = new List<Futbolista>();
            //UgandaEntrenador.Add(CrearEntrenador(1, "Poter", "Lopez", 49, "Nivel Máximo", 18));
            //UgandaMasajista.Add(CrearMasajista(2, "Pitxon", "Llamosas", 38, "Club Artemis"));
            //UgandaMasajista.Add(CrearMasajista(3, "Pezu", "González", 28, "Mesón Baytur"));
            //UgandaFutbolista.Add(CrearFutbolista(4, "Txema", "Bayón", 37, 18, "Delantero"));
            //UgandaFutbolista.Add(CrearFutbolista(5, "Rakel", "Cortés", 29, 8, "Portero"));
            //UgandaFutbolista.Add(CrearFutbolista(6, "Marpe", "Marcelino", 32, 0, "Defensa"));
            //UgandaFutbolista.Add(CrearFutbolista(7, "Naiara", "Tataya", 30, 99, "Centro"));
            //Console.WriteLine("\nDirigiendo entrenamiento:\n");
            //foreach (Entrenador item in UgandaEntrenador)
            //{
            //    if (item.GetConcentrarse() && item.GetViajar())
            //    {
            //        item.ShowAll();
            //    }
            //}
            //Console.WriteLine("\nEntrenando:\n");
            //foreach (var item in UgandaMasajista)
            //{
            //    if (item.GetConcentrarse() && item.GetViajar())
            //    {
            //        item.ShowAll();
            //    }
            //}
            //Console.WriteLine("\nMasajeando:\n");
            //foreach (var item in UgandaFutbolista)
            //{
            //    if (item.GetConcentrarse() && item.GetViajar())
            //    {
            //        item.ShowAll();
            //    }
            //}
            //Console.WriteLine(Seleccion.GetIntegrantes()-1+" integrantes");//Restas uno poque has creado otro objeto para poder usar GetIntegrantes
            Console.ReadLine();
        }
        public static Entrenador CrearEntrenador()
        {
            return new Entrenador();
        }
        public static Masajista CrearMasajista()
        {
            return new Masajista();
        }
        public static Futbolista CrearFutbolista()
        {
            return new Futbolista();
        }
        public static Entrenador CrearEntrenador(int id,string nombre,string apellido,int edad,string titulacion,int añosExperiencia)
        {
            return new Entrenador(id,nombre,apellido,edad,titulacion,añosExperiencia);
        }
        public static Masajista CrearMasajista(int id,string nombre,string apellido,int edad,string idFederacion)
        {
            return new Masajista(id,nombre,apellido,edad,idFederacion);
        }
        public static Futbolista CrearFutbolista(int id,string nombre,string apellido,int edad,int dorsal,string demarcacion)
        {
            return new Futbolista(id,nombre,apellido,edad,dorsal,demarcacion);
        }
    }
}
