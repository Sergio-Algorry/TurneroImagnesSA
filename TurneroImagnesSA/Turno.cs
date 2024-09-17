using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurneroImagnesSA
{
    public class Turno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Practica { get; set; }
        public string Estudio { get; set; }
        public DateTime Fecha { get; set; }

        public string InformeTurnos()
        {
            string mensaje = "";
            mensaje = Nombre + " "
                + Apellido + " "
                + Practica + " "
                + Estudio + " "
                + Fecha.ToString("dd/MM/yyyy HH:mm");

            return mensaje;

        }
    }
}
