using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Docente : Persona
    {

        public string materia { get; set; }
        private long legajo { get; set; }
        public Docente(string Nom, long Du, DateTime FecNac, string Sex, string mat, long leg) : base(Nom, Du, FecNac, Sex)
        {
            materia = mat;
            legajo = leg;
        }

    }
}
