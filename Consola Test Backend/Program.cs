using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;


namespace Consola_Test_Backend
{
    class Program
    {
        static void Main(string[] args)
        {



            MostrarSoportistas();
            Console.WriteLine("--------------------------");
            MostrarSalones();
            Console.WriteLine("--------------------------");
            //CrearRecorrida();
            //Console.WriteLine("--------------------------");
            MostrarHistorial();


            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }



            void MostrarHistorial()
            {

                using (BD_Recorridas_ITEntities db = new BD_Recorridas_ITEntities())
                {
                    var lst = db.traer_historial_recorridas();
                    foreach (var Elemento in lst)
                    {
                        Console.WriteLine("---Recorrida "+Elemento.id+"--------");
                        Console.WriteLine(Elemento.id);
                        Console.WriteLine(Elemento.nombre_user);
                        Console.WriteLine(Elemento.nombre_salon);
                        Console.WriteLine(Elemento.fecha);
                        Console.WriteLine(Elemento.detalle);
                        Console.WriteLine("--------------------------");
                    }

                }
            }

            void CrearRecorrida()
            {

                using (BD_Recorridas_ITEntities db = new BD_Recorridas_ITEntities())
                {
                    db.sp_nueva_recorrida(1, 1, "Ninguno");
                }
            }



            void MostrarSoportistas()
            {

                using (BD_Recorridas_ITEntities db = new BD_Recorridas_ITEntities())
                {
                    var lst = db.tb_user_it;
                    foreach (var Elemento in lst)
                    {
                        Console.WriteLine(Elemento.id);
                        Console.WriteLine(Elemento.nombre_user);
                    }

                }
            }

            void MostrarSalones()
            {

                using (BD_Recorridas_ITEntities db = new BD_Recorridas_ITEntities())
                {
                    var lst = db.tb_salon;
                    foreach (var Elemento in lst)
                    {

                        Console.WriteLine(Elemento.id);
                        Console.WriteLine(Elemento.nombre_salon);
                    }

                }
            }




        }

        
        
    }
}


