using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMaritaAñoBisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VERIFICACIÓN DEL AÑO BISIESTO");
            Console.WriteLine("Si desea salir de la aplicacion presione Ctrl+c");
            int anio;

            do
            {
                Console.Write("Ingrese el año deseado ");
                anio = int.Parse(Console.ReadLine());

                if (Esbisiesto(anio))
                {
                    Console.WriteLine(VerificarTiempoAnio(anio, Esbisiesto(anio)));
                }
                else
                {
                    Console.WriteLine(VerificarTiempoAnio(anio, Esbisiesto(anio)));
                }
                Console.WriteLine("Presione ENTER para continuar....");
                Console.ReadLine();

            } while (true);
        }

        private static string VerificarTiempoAnio(int anio, bool valido)
        {

            if (anio == DateTime.Now.Year && valido)
            {
                return $"El año {anio} es Bisiesto";
            }
            else
            {
                if (anio==DateTime.Now.Year && !valido)
                {
                    return $"El año {anio} NO es Bisiesto";
                }
                else
                {
                    if (anio < DateTime.Now.Year && valido)
                    {
                        return $"El año {anio} fue Bisiesto";
                    }
                    else
                    {
                        if (anio < DateTime.Now.Year && !valido)
                        {
                            return $"El año {anio} NO fue Bisiesto";
                        }
                        else
                        {
                            if (anio > DateTime.Now.Year && valido)
                            {
                                return $"El año {anio} sera Bisiesto";
                            }
                            else
                            {
                                return $"El año {anio} NO sera Biesto";
                            }
                        }
                    }
                }
                    
                
            }
        }

        private static bool Esbisiesto(int anio)
        {
            if(anio % 4 == 0)
            {
                if(anio % 100 == 0)
                {
                    if(anio % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
