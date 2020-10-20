using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Alumno : Persona
    {
        private string carrera { get; set; }
        private long legajo { get; set; }

        public Alumno(string Nom, long Du, DateTime FecNac, string Sex, string car, long leg) : base(Nom, Du, FecNac, Sex)
        {
            carrera = car;
            legajo = leg;
        }

    }
}
