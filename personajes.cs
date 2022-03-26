using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojuego2
{
    class ubicacion
    {
        int x;
        int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public ubicacion()
        {

        }

        public ubicacion(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    class personajes
    {
        string nombre;
        protected int num_vidas;
        ubicacion coordenada;
        int capacidad_ataque;
        protected int energia;
        int xp;
        protected int level;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Num_vidas { get => num_vidas; set => num_vidas = value; }
        public int Capacidad_ataque { get => capacidad_ataque; set => capacidad_ataque = value; }
        public int Energia { get => energia; set => energia = value; }
        public int Xp { get => xp; set => xp = value; }
        public int Level { get => level; set => level = value; }
        internal ubicacion Coordenada { get => coordenada; set => coordenada = value; }

        public personajes()
        {
             coordenada = new ubicacion();
        }

        public personajes(string pnombre, int pnum_vidas, int pcapaciad_ataque,
            int penergia, int pxp, int plevel, ubicacion pcoordenada)
        {
            nombre = pnombre;
            num_vidas = pnum_vidas;
            capacidad_ataque = pcapaciad_ataque;
            energia = penergia;
            xp = pxp;
            level = plevel;
            coordenada = pcoordenada;
        }

        public personajes(int x, int y)//arreglos necesarios para el metodo moverse
        {
            coordenada.X = x;
            coordenada.Y = y;
        }

        public string Atacar(personajes enemigo)
        {
            return "";
        }

       

        public virtual string Ver_estadisticas()
        {
            return "nombre: " + nombre + "\nnumero de vidas: " + num_vidas +
                "\ncapacidad de ataque: " + capacidad_ataque + "\nenergia: " + energia +
                "\nexperencia: " + xp + "\nnivel: " + level + "\nposicion: " + "(" +
                coordenada.X + "," + coordenada.Y + ")";
        }


    }

    class Magos: personajes
    {
        int pocimas;
        int mana;

        public int Pocimas { get => pocimas; set => pocimas = value; }
        public int Mana { get => mana; set => mana = value; }

        public Magos():base("Mago", 3, 50, 100, 0, 10, new ubicacion(5,20))
        {

        }

        public Magos(int ppocimas, int pmana)
        {
            this.pocimas = ppocimas;
            this.mana = pmana;
        }

        public bool Curarse()
        {
            int cura;
            cura = level / 100;
            if(pocimas > 0 && energia > 0 && energia < 100 && num_vidas > 0)
            {
                energia = energia + cura;
                pocimas = pocimas - 1;
                return true;// se pudo curar

            }
            else
            {
                return false;//no se pudo curar porque no tenia pocimas o
                //la energia estaba al max o no tnia vidas suficientes 
            }
        }

        public bool Lanzar_hechizos()
        {
            if(mana > 10)
            {
                return true;//se muestra el mensaje de qeu lanzo el hechizo
            }
            else
            {
                return false;//se muestra un mensaje de qu hay mana insuficiente
            }
        }

        public override string Ver_estadisticas()
        {
            return base.Ver_estadisticas() + "\npocimas: " + pocimas + "\nmana: " + mana;
        }
    }

    class Arqueros:personajes
    {
        int cantidad_flechas;
        public Arqueros():base("Arqueros", 3, 80, 100, 0, 7, new ubicacion(5,20))
        {

        }
        public override string Ver_estadisticas()
        {
            return base.Ver_estadisticas() + "\ncantidad de flechas: " + cantidad_flechas;
        }

    }

    class Guerreros:personajes
    {
        string[] armas= new string[5];

        public Guerreros():base("Mago", 3, 50, 100, 0, 10, new ubicacion(5,20))
        {

        }
        public string Aumentar_arsenal()
        {
            return "el inventario de armas a sido expandido";
        }

        public override string Ver_estadisticas()
        {
            return base.Ver_estadisticas() + "\narmas: " + armas;
        }

    }

    class Campesinos:personajes
    {
        int cantidad_comida;
        int capacidad_cosecha;

        public Campesinos():base("campesino", 3, 50, 100, 0, 10, new ubicacion(5,20))
        {

        }
        public int Cosechar()//aumenta la cantidad de comida 
        {
            cantidad_comida =capacidad_cosecha *2;
            return cantidad_comida;
        }

        public override string Ver_estadisticas()
        {
            return base.Ver_estadisticas() + "\ncantidad de comida: " + cantidad_comida+
                "\ncapacidad de cosecha: " + capacidad_cosecha;
        }
    }
}
