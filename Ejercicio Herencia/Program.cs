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
            List<SeleccionFutbol> Uganda = new List<SeleccionFutbol>();
            List<Entrenador> UgandaEntrenador = new List<Entrenador>();
            List<Masajista> UgandaMasajista = new List<Masajista>();
            List<Futbolista> UgandaFutbolista = new List<Futbolista>();
            UgandaEntrenador.Add(CrearEntrenador(1, "Poter", "Lopez", 49, "Nivel Máximo", 18));
            UgandaMasajista.Add(CrearMasajista(2, "Pitxon", "Llamosas", 38, "Club Artemis"));
            UgandaMasajista.Add(CrearMasajista(3, "Pezu", "González", 28, "Mesón Baytur"));
            UgandaFutbolista.Add(CrearFutbolista(4, "Txema", "Bayón", 37, 18, "Delantero"));
            UgandaFutbolista.Add(CrearFutbolista(5, "Rakel", "Cortés", 29, 8, "Portero"));
            UgandaFutbolista.Add(CrearFutbolista(6, "Marpe", "Marcelino", 32, 0, "Defensa"));
            UgandaFutbolista.Add(CrearFutbolista(7, "Naiara", "Tataya", 30, 99, "Centro"));


//            Se va a celebrar un partido en Londres, por lo que todos deberán realizar las siguientes operaciones:
//Ø Viajar
//Ø Concentrarse
//Ø Una vez que han llegado al destino cada uno deberá hacer su tarea,
//o   si es futbolista à Entrenar
//o   si es entrenador à Dirigir entrenamiento
//o si es masajista à dar masajes


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
