using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BdSalones
    {

        //Recibo objeto de salon de la bd y devuelvo un list of string con solamente los nombres
        public List<string> MostrarSalones()
        {
           
                using (BD_Recorridas_ITEntities db = new BD_Recorridas_ITEntities())
                {

                    List<string> NomSalones = new List<string>();

                var lst = db.TB_SALONES;

                    foreach (var Elemento in lst)
                    {
                        NomSalones.Add(Elemento.nombre_salon);
                    }

                    return NomSalones;
                }
           
            

            
        }
    }
}
