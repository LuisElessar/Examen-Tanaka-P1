using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{
    public class JuegoGranjero
    {
        private List<IGranja> cultivos = new List<IGranja>();
        private List<IAnimal> animales = new List<IAnimal>();

        public void AñadirCultivo(IGranja cultivo)
        {
            cultivos.Add(cultivo);   
        }

        public void AñadirAnimal(IAnimal animal)
        {
            animales.Add(animal);
        }

        public void Dia()
        {
            Console.WriteLine("Comienza un nuevo día en tu granjita :)");

            foreach (var cultivo in cultivos)
            {
                cultivo.Cosechar(); 
            }
            foreach (var animal in animales)
            {
                animal.Alimentar();
                animal.Palmatadero();
            }
        }
        public static void Main(string[] args)
        {
            JuegoGranjero juego = new JuegoGranjero();

            Trigo trigo = new Trigo();
            Zanahoria zanahoria = new Zanahoria();
            Papas papas = new Papas();

            Vaca vaca = new Vaca();
            Caballo caballo = new Caballo();  
            Oveja oveja = new Oveja();

            juego.AñadirAnimal(oveja);
            juego.AñadirAnimal(vaca);
            juego.AñadirAnimal(caballo);
            
            juego.AñadirCultivo(trigo);
            juego.AñadirCultivo(papas);
            juego.AñadirCultivo(zanahoria);

            juego.Dia();

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

}
