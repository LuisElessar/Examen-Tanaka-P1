using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{
    public class Oveja : AnimalG
    {
        public Oveja() : base("Oveja", 5) { }
        public override void mataderocall()
        {
            Console.WriteLine("Ha llegado el momento de la oveja");
        }
        public new void Palmatadero()
        {
            base.Palmatadero();
            Console.WriteLine($"Has obtenido carne de oveja");
        }
    }
}
