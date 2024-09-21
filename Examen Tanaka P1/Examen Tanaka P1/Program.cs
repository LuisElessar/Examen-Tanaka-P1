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

        public void MostrarMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n--- Menú de la Granja ---");
                Console.WriteLine("1. Cosechar");
                Console.WriteLine("2. Plantar");
                Console.WriteLine("3. Alimentar Animales");
                Console.WriteLine("4. AnimalesAlMatadero");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Cosechar();
                        break;
                    case "2":
                        Plantar();
                        break;
                    case "3":
                        AlimentarAnimales();
                        break;
                    case "4":
                        AnimalesAlMatadero();
                        break;
                    case "5":
                        continuar = false;
                        Console.WriteLine("Saliendo del juego...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        public void Cosechar()
        {
            foreach (var cultivo in cultivos)
            {
                cultivo.Cosechar();
            }
        }

        public void Plantar()
        {
            foreach (var cultivo in cultivos)
            {
                cultivo.Plantar();
            }
        }

        public void AlimentarAnimales()
        {
            foreach (var animal in animales)
            {
                animal.Alimentar();
            }
        }

        public void AnimalesAlMatadero()
        {
            foreach (var animal in animales)
            {
                animal.Palmatadero();
            }
        }

        public static void Main(string[] args)
        {
            JuegoGranjero juego = new JuegoGranjero();
            Papas papas = new Papas();
            Trigo trigo = new Trigo();
            Zanahoria maiz = new Zanahoria();
            Vaca vaca = new Vaca();
            Oveja oveja = new Oveja();
            Caballo caballo = new Caballo();    

            juego.AñadirCultivo(trigo);
            juego.AñadirCultivo(maiz);
            juego.AñadirCultivo(papas);
            juego.AñadirAnimal(vaca);
            juego.AñadirAnimal(oveja);
            juego.AñadirAnimal(caballo);

            juego.MostrarMenu();

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

}
