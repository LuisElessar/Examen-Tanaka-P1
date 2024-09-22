using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{
    public class Tienda
    {
        public void ComprarCultivo(Inventario inventario, Cultivo cultivo, int precio)
        {
            if (inventario.Monedas >= precio)
            {
                inventario.Monedas -= precio;
                inventario.AñadirCultivo((IGranja)cultivo);
                Console.WriteLine($"Has comprado {cultivo.Nombre} por {precio} monedas.");
            }
            else
            {
                Console.WriteLine("No tienes suficientes monedas.");
            }
        }

        public void ComprarAnimal(Inventario inventario, Animal animal, int precio)
        {
            if (inventario.Monedas >= precio)
            {
                inventario.Monedas -= precio;
                inventario.AñadirAnimal((IAnimal)animal);
                Console.WriteLine($"Has comprado un {animal.Nombre} por {precio} monedas.");
            }
            else
            {
                Console.WriteLine("No tienes suficientes monedas.");
            }
        }
    }
}
