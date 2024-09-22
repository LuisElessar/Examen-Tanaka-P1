using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{
    public class Caballo : AnimalG
    {
        public Caballo() : base("Caballo", 10) { }
        public override void mataderocall()
        {
            Console.WriteLine("Ha llegado el momento de la caballo");
        }
        public new void Palmatadero()
        {
            Console.WriteLine($"Has obtenido carne de caballo, pero no te la comas, acá no hacemos eso");
        }
    }
}
