using System;
namespace videojuego2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int atacante;
            int atacado;

            int decision = 1;
            int eleccion_personaje = 0;
            int accion = 0;
            int personajePara_atacar=0;
            int x;
            int y;
            int arma;

            personajes personaje= new personajes();
            Magos mago= new Magos();
            Arqueros arqueros= new Arqueros();
            Guerreros guerros= new Guerreros();
            Campesinos campesinos= new Campesinos();

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


            // CUANDO LOS ARQUEROS ATACAN PIERDEN UNA FLECHA. FUNCIONA

            //Console.WriteLine(arqueros.Ver_estadisticas());
            //Console.WriteLine("*************************");
            //Console.WriteLine(mago.Ver_estadisticas());
            //Console.WriteLine("**********************");
            //arqueros.Atacar(arqueros, mago);
            //Console.WriteLine(arqueros.Ver_estadisticas());
            //Console.WriteLine("*******************");
            //Console.WriteLine(mago.Ver_estadisticas());

            while (decision != 0)
            {
                do
                {
                    Console.WriteLine("estos son los personajes que estan disponibles: ");
                    //Console.WriteLine("1." + personaje.Ver_estadisticas());
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("1.mago"); //+ mago.Ver_estadisticas());
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("2.arquero"); //+ arqueros.Ver_estadisticas());
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("3.guerrero"); //+ guerros.Ver_estadisticas());
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("4.campesino"); //+ campesinos.Ver_estadisticas());
                    Console.Write("\ningrese el numero del peronaje que quiere elegir: ");
                    eleccion_personaje = int.Parse(Console.ReadLine());
                    if(eleccion_personaje < 1 || eleccion_personaje > 4)
                    {
                        Console.WriteLine("error, las opciones solo estan disponibles del 1 al 4");
                    }
                    Console.WriteLine("presione enter para continuar");
                    Console.ReadKey();
                    Console.Clear();

                } while(eleccion_personaje<1 || eleccion_personaje>4);

                Console.WriteLine("acciones que puede realizar con TODOS los personaje: ");
                Console.WriteLine("1.Atacar");
                Console.WriteLine("2.Moverse");
                Console.WriteLine("3.Ver estadisticas de los personajes");
                Console.WriteLine("---------------------------------");
                switch (eleccion_personaje)
                {
                    case 1: Console.WriteLine("estas acciones son unicas de los magos: ");
                        Console.WriteLine("4.Curarse");
                        Console.WriteLine("5.Lanzar hechizos");
                        Console.Write("\ningrese el numero de la accion que quire hacer: ");
                        accion=int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;

                        case 2: Console.WriteLine("los arqueros no tienen acciones especiales");
                        break;

                        case 3: Console.WriteLine("estas acciones son unicas de los guerreros: ");
                        Console.WriteLine("6.Aumentar arsenal");
                        Console.Write("ingrse el numero de la accion que quire hacer: ");
                        accion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;

                    case 4: Console.WriteLine("estas acciones son unicas de los campesinos: ");
                        Console.WriteLine("7.Cosechar");
                        Console.Write("ingrse el numero de la accion que quire hacer: ");
                        accion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                }

                if (accion == 1)
                {
                    Console.WriteLine("estos son los personajes que puede atacar: ");
                    Console.WriteLine("1.mago");
                    Console.WriteLine("2.arqueros");
                    Console.WriteLine("3.guerreros");
                    Console.WriteLine("4.campesinos");
                    personajePara_atacar=int.Parse(Console.ReadLine());
                    if(eleccion_personaje == 1 && personajePara_atacar == 1)//funciona pero solo para atacar un mago a otro mago porque no hemos hecho las otras validaciones
                    {
                        mago.Atacar(mago, mago);
                        Console.WriteLine("el enemigo a sufrido daño");
                        Console.WriteLine("presione enter");
                        Console.ReadKey();                       
                        Console.Clear();
                    }
                }

                if (accion == 2)//solo se puede mover el mago porque solo tenemos esa validacion
                {
                    Console.Write("ingrese la cordenada x: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("ingrese la cordenada y: ");
                    y=int.Parse(Console.ReadLine());

                    if (eleccion_personaje == 1)
                    {
                        mago.Moverse(x, y);
                        Console.WriteLine("el personaje se a movido");
                        Console.WriteLine("\npresione enter para continuar");
                        Console.ReadKey();                       
                        Console.Clear();
                    }
                }

                if(accion == 3)
                {
                    Console.WriteLine( mago.Ver_estadisticas());
                    Console.WriteLine("-------------------------");
                    Console.WriteLine( arqueros.Ver_estadisticas());
                    Console.WriteLine("---------------------------");
                    Console.WriteLine( guerros.Ver_estadisticas());
                    Console.WriteLine("----------------------------");
                    Console.WriteLine( campesinos.Ver_estadisticas());
                    Console.WriteLine("\npresione enter para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }

                if(accion == 4)
                {
                    mago.Curarse();
                    Console.WriteLine("el mago se a curado");
                    Console.WriteLine("\npresione enter para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (accion == 5)
                {
                    Console.WriteLine("puede hechizar a estos personajes: ");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("1.mago");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("2.arquero");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("3.guerrero");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("4.campesino");
                    Console.Write("ingrese el numero del personaje a hechizar: ");
                    atacado=int.Parse(Console.ReadLine());

                    if (atacado == 1)
                    {
                        mago.Lanzar_hechizos(mago);
                        Console.WriteLine("el mago a sido hechizado");
                        Console.WriteLine("\npresione enter para continuar");
                        Console.ReadLine();
                        Console.Clear();                     
                    }
                }

                if(accion == 6)
                {
                    Console.WriteLine("estas son las armas que puede adquirir: ");
                    Console.WriteLine("1.espada");
                    Console.WriteLine("2.daga");
                    Console.WriteLine("3.hacha");
                    Console.Write("ingrese el numero del arma que quiere obtener: ");
                    arma=int.Parse(Console.ReadLine());
                    guerros.Aumentar_arsenal(arma);
                    Console.WriteLine("EL ARSENAL DEL GUERRERO A INCREMENTADO");
                    Console.WriteLine("\npresione enter para continuar");
                    Console.ReadKey();
                    Console.Clear();                    
                }

                if (accion == 7)
                {
                    Console.WriteLine(campesinos.Ver_estadisticas());
                    campesinos.Cosechar();
                    Console.WriteLine("--------------");
                    Console.WriteLine(campesinos.Ver_estadisticas());//por qeu cuando el metodo es void, da error cuando lo invoco?¡
                }
               

                Console.WriteLine("\nquiere seguir jugano ¡?");
                Console.WriteLine("0.no");
                Console.WriteLine("1.si");
                Console.Write("escriba su respuesta: ");
                decision=int.Parse(Console.ReadLine());

            }
        }
    }
}