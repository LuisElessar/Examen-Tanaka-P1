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
           if (Diasrestantes == 0)
            {
                Console.WriteLine($"{Nombre} está listo para cosechar.");
            }
           else
            {
                Console.WriteLine($"{Nombre} está creciendo. Tardará {Crecimiento} días.");
            }
        }

        public void Cosechar()
        {
            if (Diasrestantes == 0)
            {
                Console.WriteLine($"Has cosechado {Nombre}.");
                Diasrestantes = Crecimiento;
            }
            else
            {
                Console.WriteLine($"{Nombre} no está listo para cosechar.");
            }
        }

        public void Plantar()
        {
            Console.WriteLine($"Has plantado {Nombre}. Faltan {Diasrestantes} para que se coseche");
        }
    }
}
