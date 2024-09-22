using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{

    public class CultivoComible : Cultivo, IGranja
    {
        public CultivoComible(string nombre, int crecimiento)
            : base(nombre, crecimiento) { }

        public override void crece()
        {
            Console.WriteLine($"{Nombre} está creciendo. Tardará {Crecimiento} días.");
        }

        public void Cosechar()
        {
            Console.WriteLine($"Has cosechado {Nombre}.");
        }

        public void Plantar()
        {
            Console.WriteLine($"Has plantado {Nombre}.");
        }
    }
}
