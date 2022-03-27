using System;
namespace videojuego2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int atacante;
            int atacado;

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
            Console.WriteLine("presiona una tecla para limpiar la pantalla");
            Console.ReadLine();
            Console.Clear();

            //probando el METODO MOVER y funciona

            //Console.WriteLine(personaje.Ver_estadisticas());
            //personaje.Moverse(8, 20);
            //Console.WriteLine("**************************");
            //Console.WriteLine(personaje.Ver_estadisticas());

            //Console.WriteLine("-------------------------");
            //Console.WriteLine(mago.Ver_estadisticas());
            //mago.Moverse(9, 60);
            //Console.WriteLine("***************************");
            //Console.WriteLine(mago.Ver_estadisticas());

            //PROBANDO EL METODO ATACAR Y FUNCIONA

            //Console.WriteLine("seleccione el personaje que quiere escoger: ");
            //Console.WriteLine("1.mago");
            //Console.WriteLine("2.arquero");
            //Console.WriteLine("3.guerrero");
            //Console.WriteLine("4.campesino");
            //atacante=int.Parse(Console.ReadLine());

            //Console.WriteLine("seleccione el personaje que quiere atacar: ");
            //Console.WriteLine("1.mago");
            //Console.WriteLine("2.arquero");
            //Console.WriteLine("3.guerrero");
            //Console.WriteLine("4.campesino");
            //atacado=int.Parse(Console.ReadLine());

            //if (atacante == 1 && atacado==1)    
            //    mago.Atacar(mago, mago);

            //if(atacante == 1 && atacado== 2)
            //    mago.Atacar(mago, arqueros);


            //Console.WriteLine(mago.Ver_estadisticas());
            //Console.WriteLine("----------------------");
            //Console.WriteLine(arqueros.Ver_estadisticas());

            //por que cuando pongo que el metodo retorne un entero, no funciona?¡


            //PROBANDO EL METOO DE LANZAR ECHIZOS Y FUNCIONA

            //Console.WriteLine("seleccione el personaje que quiere atacar: ");
            //Console.WriteLine("1.mago");
            //Console.WriteLine("2.arquero");
            //Console.WriteLine("3.guerrero");
            //Console.WriteLine("4.campesino");
            //atacado = int.Parse(Console.ReadLine());

            //if(atacado== 3)
            //{
            //    mago.Lanzar_hechizos(guerros);
            //}
            //Console.WriteLine(mago.Ver_estadisticas());
            //Console.WriteLine("--------------------");
            //Console.WriteLine(guerros.Ver_estadisticas());


            //PROBANDO EL METOO DE AUMENTO DE ARSENAL Y FUNCIONA

            //Console.WriteLine(guerros.Ver_estadisticas());
            //guerros.Aumentar_arsenal();
            //Console.WriteLine("------------------------");
            //Console.WriteLine(guerros.Ver_estadisticas());

            //PROBANDO EL METODO DE COSECHA Y FUNCIONA

            //Console.WriteLine(campesinos.Ver_estadisticas());
            //Console.WriteLine("------------------------");
            //campesinos.Cosechar();
            //Console.WriteLine(campesinos.Ver_estadisticas());

        }
    }
}