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

        public int Diasrestantes { get; set; }
        public Cultivo(string nombre, int crecimiento)
        {
            Nombre = nombre;
            Crecimiento = crecimiento;
            Diasrestantes = crecimiento;
        }

        public void PasarDia()
        {
            if (Diasrestantes > 0)
            {
                Diasrestantes--;
            }
        }
        public abstract void crece();
    }
}
