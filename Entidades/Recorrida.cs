using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recorrida
    {


        public Recorrida()
        {
        }

        public Recorrida(string nomSop, int idSalon, bool estado, string detalle)
        {
            this.NomSop = nomSop;
            this.IdSalon = idSalon;
            this.Estado = estado;
            this.Detalle = detalle;

        }

        public string NomSop { get; set; }
        public int IdSalon { get; set; }
        public bool Estado { get; set; }
        public string Detalle { get; set; }


}
}
