using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BdSoportista
    {


        public List<String> LlenarSoportistas()
        {
           
                using (BD_Recorridas_ITEntities db = new BD_Recorridas_ITEntities())
                {

                    List<string> NomSoportista = new List<string>();
                var lst = db.TB_USER_IT;
                    foreach (var Elemento in lst)
                    {
                        NomSoportista.Add(Elemento.nombre_user);
                    }

                    return NomSoportista;
                }
            

            
        }

      

    }
}
