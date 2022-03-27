el  programa que se pidio en cuesetion fue el siguiente:
Se desea desarrollar un videojuego en el cual se cuenta con diferentes personajes  cuyas características son: nombre, número de vidas, ubicación dada por una  coordenada (x,y), capacidad de ataque, energía, experiencia, nivel. 
Los personajes que tiene el juego son: magos, arqueros, guerreros y campesinos.  Los arqueros además de las características ya mencionadas tienen una cantidad de  flechas. 
Los magos tienen pócimas, y cierta cantidad de maná que usará para lanzar hechizos. 
Los guerreros cuentan con armas (espada, daga, hacha).  
Los campesinos tienen una capacidad de cosechar y una cantidad de comida. Todos los personajes tienen la posibilidad de:  
● Atacar para producir un daño al enemigo y esto depende de su capacidad de  ataque. La acción de atacar consistirá en recibir un personaje como parámetro  y disminuir su nivel de energía. Por ejemplo, si un personaje tiene una capacidad  de ataque de 2 quiere decir que en cada ataque le resta el 2% de energía al  enemigo. Si un personaje pierde el 100% de energía perderá una vida y la  energía se reinicia. Cuando un arquero lanza un ataque se supone que lo hace  lanzando una flecha por lo cual cuando este ataca, la cantidad de flechas  disminuye. 
● Moverse: para lo cual le se debe indicar una coordenada xy y los personajes  actualizarán su posición a esta nueva coordenada.  
● Mostrar Estadísticas: Mostrará la información asociada a cada personaje. 
Habilidades especiales de cada personaje: 
Adicional a las habilidades generales de todos los personajes, algunos pueden  realizar acciones específicas. 
● Los magos pueden curarse usando una pócima, el hecho de curarse implica un  aumento en la energía, este aumento depende del nivel del personaje, si el  mago es nivel 1 el uso de una pócima produce un aumento de la energía en 1%, así sucesivamente. El uso de una pócima implica una disminución de la cantidad  de pócimas, si el mago no cuenta con pócimas no podrá usar la habilidad para  curarse.  
● Adicionalmente los magos podrán lanzar hechizos que proceden bloqueo en los  enemigos inhabilitando su capacidad de atacar. El hechizo lo puede lanzar si  cuenta con maná y el hecho de lanzar un hechizo disminuirá su capacidad de  maná, se requieren de 10 unidades de maná para lanzar un hechizo.  
● Los guerreros pueden aumentar su arsenal, esto es, aumentar el inventario de  armas. 
● Los campesinos poseen la habilidad para cosechar y el hecho de cosechar le  permite aumentar la cantidad de comida en dos veces la capacidad de cosechar.  Si la capacidad de cosechar es 2 la cantidad de comida aumenta en 4, si la  capacidad de cosechar es 3 la cantidad de comida aumenta en 6, etc. 
La imagen muestra un resumen de cómo se seria la tarjeta de cada personaje. 
Trabajo a desarrollar: 
1. Inicialmente defina un diagrama de clase que defina las diferentes entidades  identificadas y sus relaciones. 
2. A continuación, debe programar las clases definidas en las que, además, de los  constructores deberá identificar los atributos de cada clase y desarrollar los  métodos correspondientes. 
3. Finalmente realice un programa de prueba para las clases desarrolladas, para  lo cual deberá realizar una implementación en la que cree instancias de los  diferentes personajes y pruebe los métodos implementados.  
