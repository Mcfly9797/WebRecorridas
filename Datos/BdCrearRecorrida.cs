using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class BdCrearRecorrida
    {
       

        public int CrearRecorrida(string nomUser, string detalle)
        {
   
                using (BD_Recorridas_ITEntities db = new BD_Recorridas_ITEntities())
                {
                    int idRecorrida = db.SP_NUEVA_RECORRIDA(nomUser, detalle).FirstOrDefault().Value;

                return idRecorrida;
            }

     

            
        }

        //funcion con foreach que recorra objeto con lista de id y envie las query a un stored pro que inserte en la tabla intermedia
        public bool InsertarSalones(int idRecorrida, List<Recorrida> listRecorridas)
        {

            using (BD_Recorridas_ITEntities db = new BD_Recorridas_ITEntities())
            {


                try
                {
                    foreach (var s in listRecorridas)
                    {
                        db.SP_AGREGAR_SALON_RECORRIDA(idRecorrida, s.IdSalon, s.Estado);
                    }
                    return true;
                }
                catch (Exception ex)
                {

                    throw ex;
                    return false;
                }

               




            }

            return true;

        }


    }
}
