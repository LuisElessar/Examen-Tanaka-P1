using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{
    public abstract class Cultivo
    {
        public string Nombre { get; set; }
        public int Crecimiento { get; set; }
        public Cultivo(string nombre, int crecimiento)
        {
            Nombre = nombre;
            Crecimiento = crecimiento;
        }
        public abstract void crece();
    }
}
