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
        protected float energia;
        int xp;
        protected float level;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Num_vidas { get => num_vidas; set => num_vidas = value; }
        public int Capacidad_ataque { get => capacidad_ataque; set => capacidad_ataque = value; }
        public float Energia { get => energia; set => energia = value; }
        public int Xp { get => xp; set => xp = value; }
        public float Level { get => level; set => level = value; }
        internal ubicacion Coordenada { get => coordenada; set => coordenada = value; }

        public personajes()
        {
             coordenada = new ubicacion();
        }

        public personajes(string pnombre, int pnum_vidas, int pcapaciad_ataque,
            int penergia, int pxp, float plevel, ubicacion pcoordenada)
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

        public virtual void Atacar(personajes atacante, personajes atacado)//funciona
        {
            atacante.capacidad_ataque = atacante.capacidad_ataque / 100;
            if (atacado.energia > 0)
            {
               // return 4;//solo perdio energia
                atacado.energia = atacado.energia - atacante.capacidad_ataque;
            }
            else
            {

                atacado.num_vidas -= 1;
                if (atacado.num_vidas == 0)
                {
                    // return 1;//significa qeu murio del todo
                    atacado.energia = 100;
                }

                //perio energia pero no vida
            }
        }

        public string Moverse(int x, int y)//funciona
        {
            coordenada.X = x;
            coordenada.Y = y;
            return "se movio";
        }

       

        public virtual string Ver_estadisticas()//funciona
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

        public Magos():base("Mago", 3, 500, 90, 0, 10, new ubicacion(5,20))
        {
            mana = 20;
            pocimas = 3;
            mana = 20;
        }

        public string Curarse()//funciona//funciona
        {
            float cura;
            float suma;
            cura = level / 100;
            if(pocimas > 0 && energia > 0 && energia < 100 && num_vidas > 0)
            {
                suma = energia * cura + energia;//energia + cura;
                energia = suma;
                pocimas = pocimas - 1;
                return "esta es cura: " + cura;
               // return true;// se pudo curar

            }
            else
            {
                // return false;//no se pudo curar porque no tenia pocimas o
                //la energia estaba al max o no tnia vidas suficientes 
                return "lo que sea: ";
            }
        }

        public bool Lanzar_hechizos(personajes atacado)//funciona
        {
            if(mana > 10)
            {
                atacado.Capacidad_ataque = 0;
                mana-=10;

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
        public Arqueros():base("Arqueros", 3, 300, 100, 0, 7, new ubicacion(5,20))
        {
            cantidad_flechas = 5;
        }

        public override void Atacar(personajes atacante, personajes atacado)//funciona
        {
            base.Atacar(atacante, atacado);
            cantidad_flechas -= 1;
        }
        public override string Ver_estadisticas()
        {
            return base.Ver_estadisticas() + "\ncantidad de flechas: " + cantidad_flechas;
        }

    }

    class Guerreros:personajes
    {
        //string[] armas= new string[3];
        int espada = 0;
        int daga = 0;
        int hacha = 0;
        public Guerreros():base("guerrero", 3, 50, 100, 0, 10, new ubicacion(5,20))
        {

        }
        public void Aumentar_arsenal(int arma)//funciona
        {
            //armas[0] = "espada";
            //armas[1] = "daga";
            //armas[2] = "hacha";
            if (arma == 1)
                espada += 1;

            if (arma == 2)
                daga += 1;

            if (arma == 3)
                hacha += 1;
        }

        public override string Ver_estadisticas()//funciona
        {
            return base.Ver_estadisticas() + "\narmas: " + "\nespada: " + espada + "\ndaga:" +
                daga + "\nhacha: " + hacha;
        }

    }

    class Campesinos:personajes
    {
        int cantidad_comida;
        int capacidad_cosecha;

        public Campesinos():base("campesino", 3, 50, 100, 0, 10, new ubicacion(5,20))
        {
            capacidad_cosecha = 3;
            cantidad_comida = 1;
        }
        public void Cosechar()//FUNCIONA
        {
            cantidad_comida =capacidad_cosecha *2;
            
        }

        public override string Ver_estadisticas()
        {
            return base.Ver_estadisticas() + "\ncantidad de comida: " + cantidad_comida+
                "\ncapacidad de cosecha: " + capacidad_cosecha;
        }
    }
}
