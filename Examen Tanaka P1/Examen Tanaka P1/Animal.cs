using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public int Diasrestantes { get; set; }

        public Animal(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            Diasrestantes = edad;
        }

        public void PasarDia()
        {
            if(Diasrestantes > 0)
            {
                Edad--;
            }
        }
        public abstract void mataderocall();
    }
}
