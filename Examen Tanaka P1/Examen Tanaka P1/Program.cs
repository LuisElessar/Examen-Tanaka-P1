using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tanaka_P1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            JuegoGranjero juego = new JuegoGranjero();
            juego.IniciarJuego();
        }
    }
    public class JuegoGranjero
    {
        private Inventario inventario;
        private Tienda tienda;
        private int dias;
        private const int DiasPorCobro = 30;
        private const int MonedasPorCobro = 10;

        public JuegoGranjero()
        {
            inventario = new Inventario(50);
            tienda = new Tienda();
            dias = 0;
        }

        public void PasarDia()
        {
            dias++;
            foreach (var cultivo in inventario.Cultivos)
            {
                if (cultivo is CultivoComible cultivoComestible)
                {
                    cultivoComestible.PasarDia();
                }
            }

            foreach (var animal in inventario.Animales)
            {
                if (animal is AnimalG mamifero)
                {
                    mamifero.PasarDia();
                }
            }

            if (dias % DiasPorCobro == 0)
            {
                Pagar();
            }
        }

        public void Pagar()
        {
            if (inventario.Monedas >= MonedasPorCobro)
            {
                inventario.Monedas -= MonedasPorCobro;
                Console.WriteLine($"Has pagado {MonedasPorCobro} monedas.");
            }
            else
            {
                Console.WriteLine("No tienes suficientes monedas para pagar. Has perdido el juego.");
                Environment.Exit(0);
            }
        }

        public void MostrarMenu()
        {
            Console.WriteLine("\n--- Menú del Día ---");
            Console.WriteLine("1. Plantar o Cosechar cultivos.");
            Console.WriteLine("2. Alimentar o Recolectar productos de los animales.");
            Console.WriteLine("3. Comprar cultivos o animales.");
            Console.WriteLine("4. Ver inventario.");
            Console.WriteLine("5. Pasar al siguiente día.");
            Console.WriteLine("Selecciona una opción:");
        }

        public void IniciarJuego()
        {
            while (true)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ManejarCultivos();
                        break;
                    case "2":
                        ManejarAnimales();
                        break;
                    case "3":
                        ManejarCompras();
                        break;
                    case "4":
                        inventario.MostrarInventario();
                        break;
                    case "5":
                        PasarDia();
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        public void ManejarCultivos()
        {
            foreach (var cultivo in inventario.Cultivos)
            {
                if (cultivo is CultivoComible cultivoComestible)
                {
                    cultivoComestible.crece();
                    cultivoComestible.Cosechar();
                }
            }
        }

        public void ManejarAnimales()
        {
            foreach (var animal in inventario.Animales)
            {
                if (animal is AnimalG mamifero)
                {
                    mamifero.Alimentar();
                    mamifero.Palmatadero();
                }
            }
        }

        public void ManejarCompras()
        {
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Comprar Trigo (5 monedas).");
            Console.WriteLine("2. Comprar Zanahoria (7 monedas).");
            Console.WriteLine("3. Comprar Papas (10 monedas)");
            Console.WriteLine("4. Comprar Vaca (15 monedas).");
            Console.WriteLine("5. Comprar Oveja (12 monedas).");
            Console.WriteLine("6. Comprar Caballo (20 monedas).");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    tienda.ComprarCultivo(inventario, new Trigo(), 5);
                    break;
                case "2":
                    tienda.ComprarCultivo(inventario, new Zanahoria(), 7);
                    break;
                case "3":
                    tienda.ComprarCultivo(inventario, new Papas(), 10);
                    break;
                case "4":
                    tienda.ComprarAnimal(inventario, new Vaca(), 15);
                    break;
                case "5":
                    tienda.ComprarAnimal(inventario, new Oveja(), 12);
                    break;
                case "6":
                    tienda.ComprarAnimal(inventario, new Caballo(), 20);
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}

