using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class CrearRecorrida
    {



        public bool AgregarRecorrida(List<Recorrida> listRecorrida)
        {

            BdCrearRecorrida crearRecorrida = new BdCrearRecorrida();

            int idRecorrida = crearRecorrida.CrearRecorrida(listRecorrida.FirstOrDefault().NomSop, listRecorrida.FirstOrDefault().Detalle);

            bool resultado = crearRecorrida.InsertarSalones(idRecorrida, listRecorrida);
            
            return resultado;
        }


    }
}
