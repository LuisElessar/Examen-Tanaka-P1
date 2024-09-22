using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{
    public class AnimalG : Animal, IAnimal
    {
        public AnimalG(string nombre, int edad)
            : base(nombre, edad) { }

        public override void mataderocall()
        {
            Console.WriteLine($"{Nombre} está listo para ir al matadero");
        }

        public void Alimentar()
        {
            Console.WriteLine($"Has alimentado al {Nombre}");
        }

        public void Palmatadero()
        {
            if (Diasrestantes == 0)
            {
                Console.WriteLine($"Has enviado al {Nombre} al matadero");
            }
            else
            {
                Console.WriteLine($"{Nombre} aún no está listo para ir al matadero.");
            }
        }
    }
}
