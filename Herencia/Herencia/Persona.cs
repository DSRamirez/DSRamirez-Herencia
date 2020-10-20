using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string nombre { get; set; }
        public long DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }

        public Persona(string Nom, long Du, DateTime FecNac, string Sex)
        {
            nombre = Nom;
            DNI = Du;
            FechaNacimiento = FecNac;
            Sexo = Sex;
        }

        public int Edad()
        {
            int edad;
            edad = FechaNacimiento.Year - DateTime.Now.Year;
            return edad;
        }
    }

    
}
