using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{
    public class Vaca : AnimalG
    {
        public Vaca() : base("Vaca", 2) { }
        public override void mataderocall()
        {
            Console.WriteLine("Ha llegado el momento de la vaca");
        }
        public new void Palmatadero()
        {
            Console.WriteLine($"Has obtenido carne de vaca");
        }
    }
}
