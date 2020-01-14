using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Negocio
{
    public class LlenarSalones
    {


            

        public List<string> TraerNombreSalones() 
        {
             
            List<string> nomSalones = new BdSalones().MostrarSalones();

            return nomSalones;
        }


}


}

