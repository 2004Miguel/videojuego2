using System;
namespace videojuego2
{
    class Program
    {
        public static void Main(string[] args)
        {
            personajes personaje= new personajes();
            Magos mago= new Magos();
            Arqueros arqueros= new Arqueros();
            Guerreros guerros= new Guerreros();
            Campesinos campesinos= new Campesinos();

            Console.WriteLine(personaje.Ver_estadisticas());
            Console.WriteLine("-------------------------");
            Console.WriteLine(mago.Ver_estadisticas());
            Console.WriteLine("-------------------------");
            Console.WriteLine(arqueros.Ver_estadisticas());
            Console.WriteLine("---------------------------");
            Console.WriteLine(guerros.Ver_estadisticas());
            Console.WriteLine("----------------------------");
            Console.WriteLine(campesinos.Ver_estadisticas());

        }
    }
}