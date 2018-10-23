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
            int eleccionMenu, eleccionCrear, edad, id, añosExperiencia;
            string nombre, apellido,titulacion,idFederacion,demarcacion;

            Console.WriteLine("\t\t\t**********Bienvenido a FIFA 1974**********\n\n");
            Console.WriteLine("Elija una de las siguientes opciones:\n\n\t1.Alta Participante.\n\t2.Baja Participante\n\t3.Mostrar Selección.\n\t4.Preparar Partido.\n\t5.Jugar Partido.\n\t6.Salir");
            eleccionMenu = Int32.Parse(Console.ReadLine());
            do
            {
                switch (eleccionMenu)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("\n\tQue tipo de participante desea dar de alta:\n\t1.Entrenador\n\t2.Masajista\n\t3.Futbolista\n\t4.Salir\n");
                            eleccionCrear = Int32.Parse(Console.ReadLine());
                            switch (eleccionCrear)
                            {
                                case 1:

                                    break;
                                case 2:

                                    break;
                                case 3:

                                    break;
                                case 4:
                                    Console.WriteLine("\nHa elegido volver al menú principal\n--------------------------------------");
                                    break;
                            }
                        } while (eleccionCrear<1&&eleccionCrear>4);
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    default:

                        break;
                }
            } while (eleccionMenu != 6);



            //SeleccionPais Uganda = new SeleccionPais("Uganda");
            //Entrenador e1 = CrearEntrenador(1, "Poter", "Lopez", 49, "Nivel Máximo", 18);
            //Masajista m1 = CrearMasajista(2, "Pitxon", "Llamosas", 38, "Club Artemis");
            //Masajista m2 = CrearMasajista(3, "Pezu", "González", 28, "Mesón Baytur");
            //Futbolista f1=CrearFutbolista(4, "Txema", "Bayón", 37, 18, "Delantero");
            //Futbolista f2 = CrearFutbolista(5, "Rakel", "Cortés", 29, 8, "Portero");
            //Futbolista f3 = CrearFutbolista(6, "Marpe", "Marcelino", 32, 0, "Defensa");
            //Futbolista f4 = CrearFutbolista(7, "Naiara", "Tataya", 30, 99, "Centro");
            //Uganda.AltaSeleccion(e1); Uganda.AltaSeleccion(e1); Uganda.AltaSeleccion(e1);//Prueba tope entrenadores
            //Uganda.AltaSeleccion(m1);
            //Uganda.AltaSeleccion(m2);
            //Uganda.AltaSeleccion(f1);
            //Uganda.AltaSeleccion(f2);
            //Uganda.AltaSeleccion(f3);
            //Uganda.AltaSeleccion(f4);
            //Uganda.MostrarDatosSeleccion();
            //Uganda.BajaSeleccionConObjeto(e1);
            //Uganda.BajaSeleccionConObjeto(e1);
            //Uganda.BajaSeleccionConObjeto(e1);
            //Uganda.BajaSeleccion(2);
            //Uganda.MostrarDatosSeleccion();


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
        public static Entrenador CrearEntrenador(int id,string nombre,string apellido,int edad,string titulacion,int añosExperiencia)//TODO:Tienes cambiados los atributos extra entre entrenador y masajista
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
