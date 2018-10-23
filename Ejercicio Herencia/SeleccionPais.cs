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
        private List<SeleccionFutbol> seleccion = new List<SeleccionFutbol>();
        private static int Participantes,EntrenadorContador,MasajistaContador,FutbolistaContador;
        public SeleccionPais(string nombreSeleccion)
        {
            this . NombreSeleccion = nombreSeleccion;
        }       
        public SeleccionPais(List<SeleccionFutbol>Seleccion,string NombreSeleccion)//Al usar este método se borraría la lista anterior
        {
            this.NombreSeleccion = NombreSeleccion;
            if (Seleccion.Count() > 30)
            {
                foreach (var item in Seleccion)
                {
                    Participantes++;
                    if (item.GetType().Name == "Entrenador")
                    {
                        EntrenadorContador++;
                        if (EntrenadorContador > 2)
                        {
                            Console.WriteLine("No puede haber más de dos etrenadores en la selección");
                        }
                        
                    }
                    else if (item.GetType().Name == "Masajista")
                    {
                        MasajistaContador++;
                        if (MasajistaContador > 4)
                        {
                            Console.WriteLine("No puede haber más de cuatro masajistas en la selección");
                        }
                    }
                    else if (item.GetType().Name == "Futbolista")
                    {
                        FutbolistaContador++;
                    }
                    else
                    {
                        Console.WriteLine("Si sale esto, es que ha debido de entrar un objeto extaño en la lista, revisa el constructor SeleccionPais con listas");
                    }
                }
                if (MasajistaContador <= 4 && EntrenadorContador <= 2)
                {
                    this.seleccion = Seleccion;
                }
                            
            }
            else
            {
                Console.WriteLine("No puede haber más de 30 integrantes en la selección");
            }
        }
        public void AltaSeleccion(SeleccionFutbol objeto)
        {
            
            if (objeto.GetType().Name == "Entrenador" && Participantes < 30 && EntrenadorContador < 2)
            {
                seleccion.Add(objeto);
                EntrenadorContador++;
                Participantes++;
            }
            else if (objeto.GetType().Name == "Masajista" && Participantes < 30 && MasajistaContador < 4)
            {
                seleccion.Add(objeto);
                MasajistaContador++;
                Participantes++;
            }
            else if (objeto.GetType().Name == "Futbolista" && Participantes < 30)
            {
                seleccion.Add(objeto);
                FutbolistaContador++;
                Participantes++;
            }
            else
            {
                Console.WriteLine("------------\nLímite de integrante superado");
                objeto.ShowAll();
                Console.WriteLine("No ha sido añadido \n----------------------");
            }
        }
        public bool BajaSeleccion(int id)
        {
            foreach (SeleccionFutbol item in seleccion)
            {
                if (item.GetId() == id)
                {
                    seleccion.Remove(item);
                    Participantes--;
                    Console.WriteLine("El seleccionado con ID "+id+" ha sido eliminado");
                    if (item.GetType().Name == "Entrenador")
                    {
                        EntrenadorContador--;
                    }
                    else if (item.GetType().Name == "Masajista")
                    {
                        MasajistaContador--;
                    }
                    else if (item.GetType().Name == "Futbolista")
                    {
                        FutbolistaContador--;
                    }
                    return true;
                }
            }
            Console.WriteLine("No pudo encontrarse ninguna coincidencia");
            return false;
        }
        public bool BajaSeleccionConObjeto(SeleccionFutbol c)//No has leido bien y era dar de baja con el id
        {
            if (seleccion.IndexOf(c)!=-1&&c.GetType().Name=="Entrenador")
            {
                EntrenadorContador--;
                Participantes--;
                seleccion.Remove(c);
                Console.WriteLine("-------------------------\nSe ha echado al entrenador");
                return true;
            }
            else if (c.GetType().Name == "Masajista" && seleccion.IndexOf(c) != -1)
            {
                MasajistaContador--;
                Participantes--;
                seleccion.Remove(c);
                Console.WriteLine("-------------------------\nSe ha echado al masajista");
                return true;
            }
            else if (c.GetType().Name == "Futbolista" && seleccion.IndexOf(c) != -1)
            {
                FutbolistaContador--;
                Participantes--;
                seleccion.Remove(c);
                Console.WriteLine("-------------------------\nSe ha echado al futbolista");
                return true;
            }
            Console.WriteLine("---------------\nNo se ha encontrado ningun " + c.GetType().Name + " en la seleccion");
            return false;//No hace falta meterlo en un else porque ya se para en el return si ha encontrado algún caso
        }
        public void MostrarDatosSeleccion()
        {
            Console.WriteLine("\t\t\tSelección de " + NombreSeleccion+" con "+Participantes+" integrantes");
            foreach (SeleccionFutbol miembros in seleccion)
            {
                miembros.ShowAll();
            }
        }

    }
}
