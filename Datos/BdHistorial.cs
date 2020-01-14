using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;



namespace Datos
{
    public class BdHistorial
    {



        public Recorrida TraerHistorial( Recorrida recorrida)
        {

          
                using (BD_Recorridas_ITEntities db = new BD_Recorridas_ITEntities())
                {
                    //var lst = db.traer_historial_recorridas();
                    //foreach (var Elemento in lst)
                    //{
                    //    recorrida.Id = Elemento.id;
                    //    recorrida.Nombre_user = Elemento.nombre_user;
                    //    recorrida.Nombre_salon = Elemento.nombre_salon;
                    //    recorrida.Fecha = Elemento.fecha;
                    //    recorrida.Detalle = Elemento.detalle;
                    //}
                }
                return recorrida;
           
            
        }
    }
}
