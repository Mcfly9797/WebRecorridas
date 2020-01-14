using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class LlenarSoportistas
    {

        public List<String> NomSoportistas()
        {
            List<string> bdSoportistas = new BdSoportista().LlenarSoportistas();

            return bdSoportistas;
        }

       
        

    }
}
