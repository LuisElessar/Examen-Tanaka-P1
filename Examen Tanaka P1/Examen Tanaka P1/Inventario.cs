using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{
    public class Inventario
    {
        public int Monedas { get; set; }
        public List<IGranja> Cultivos { get; set; }
        public List<IAnimal> Animales { get; set; }

        public Inventario(int monedasIniciales)
        {
            Monedas = monedasIniciales;
            Cultivos = new List<IGranja>();
            Animales = new List<IAnimal>();
        }

        public void AñadirCultivo(IGranja cultivo)
        {
            Cultivos.Add(cultivo);
        }

        public void AñadirAnimal(IAnimal animal)
        {
            Animales.Add(animal);
        }

        public void MostrarInventario()
        {
            Console.WriteLine("\n--- Inventario ---");
            Console.WriteLine($"Monedas: {Monedas}");
            Console.WriteLine($"Cultivos: {Cultivos.Count}");
            Console.WriteLine($"Animales: {Animales.Count}");
        }
    }
}
