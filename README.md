# GENERALA TIMBA
## **Sobre Mi**
Hola soy Nicolas Boullon estoy actualmente cursando la Tecnicatura Superior en Programacion en la Universidad Tecnologica Nacional.
Mi experiencia programando para este trabajo practico/parcial, fue mucha mejor y mas divertida que el primero. Senti que el tiempo que se atribuyo para realizar el trabajo fue "bueno".
Si bien el plan para este trabajo no era enfocarse tanto en el diseño, tambien le puse empeño.

## **Resumen**
La aplicacion es el juego clasico de la Generala. Llamada Generala Timba. Lo que se puede hacer dentro de esta app es jugar Jugador vs Jugador, estos pueden ser creados con un nombre de fantasia si se quiere o un nombre propio. 
No se pueden enfrentar los mismos jugadores, si o si, deberan ser distintos. Los puntos se calculan de modo automatico, primero evaluando si es una jugada especial (Generala, Poker, Full o Escalera), si no es ninguna de estas
pasara a calcular los puntos y calcular de esta manera a que numero se asignaran los puntos.
Tambien se puede crear partidas de forma simultanea, sin entorpecer el resultado o la jugabilidad de estas mismas. Se puede cancelar las partidas, y de esta forma no se vera afectado ningun jugador, ni ranking, ni historial de partidas.
En el apartado Historial, se podra observar el ranking de victorias con los jugadores, de forma descendente. Y tambien se puede observar el historial de partidas que contiene la informacion necesaria (Jugador Ganador, Jugador perdedor, 
puntos del jugador ganador, puntos del jugador perdedor, el ganador, y la fecha y hora en la que se jugo).
Los jugadores y usuarios estan conectados con la base de datos, de la cual trae los datos para poder ingresar a la aplicacion, consultando a travez de las query.
La app tiene una funcionalidad para poder crear un usuario e ingresar seguido de esto. Validando que el nombre de usuario a crear no exista.
Para el guardado del historial de las partidas esta serializado con formato JSON.
#Primera Vista

![image](https://github.com/NicolasBoullon/Boullon.Nicolas.TP2/assets/95184975/c27f98ef-4f47-45b0-afbb-995cc4f9c80c)

Como observamos apenas iniciamos la aplicacion podremos ingresar con el Usuario y Contraseña. Aplicando la conexion a nuestra base de datos de SQL.

![image](https://github.com/NicolasBoullon/Boullon.Nicolas.TP2/assets/95184975/eca360f3-8ac0-498a-bd12-052319c815d7)


En la parte de abajo seguido del Ingresar Usuario, encontraremos el Crear Usuario. Donde podremos crear un nuevo Usuario ingresando los datos correspondientes. Y validando de no crear un Usuario nuevo, con el mismo nombre de Usuario. Creando de forma
automatica nuestro nuevo usuario ya actualizado en nuestra base de datos de SQL.
![image](https://github.com/NicolasBoullon/Boullon.Nicolas.TP2/assets/95184975/c5442336-3f63-47d5-b2cb-77f9389afcc4)


Una vez ingresado a la aplicacion observaremos el menu de Partidas, donde podremos elegir nuestros jugadores para enfrentarse. Una vez elegido los jugadores podremos crear una mesa o varias simultaneamente. Aplicando de esta manera diferentes hilos
en los cuales no se interrumpiran en ningun momento entre ellos.
![image](https://github.com/NicolasBoullon/Boullon.Nicolas.TP2/assets/95184975/3b3478df-1fbb-4c14-996b-cd7da726ea28)

Al tocar el boton Crear Jugador, se abrira el siguiente formualario para poder crear un nuevo jugador.
![Uploading image.png…]()


Una vez empezado el juego, se lanzaran las tiradas de cada jugador, 10 en total, luego de esto se hara la sumatoria de puntos y se abrira un nuevo formulario anunciando el ganador. En caso de que haya sido un empate, no habra ganador ni suma 
de partidas en el ranking de victorias. Tambien tendremos el boton de Cancelar Mesa, el cual frenara la partida y los procesos. De esta manera se informara que la partida se ha cancelado, sin modificar nuestro ranking de victorias ni el historial 
de partidas.
![image](https://github.com/NicolasBoullon/Boullon.Nicolas.TP2/assets/95184975/d9c2a138-923d-45a7-8a16-a1b67746fe2e)

Finalizada la partida se modificaran los numeros con sus respectivos valores.

![image](https://github.com/NicolasBoullon/Boullon.Nicolas.TP2/assets/95184975/3727085d-158a-48c6-a228-89df17e7045d)

Y se abrira un nuevo formulario indicando el ganador y perdedor.
![image](https://github.com/NicolasBoullon/Boullon.Nicolas.TP2/assets/95184975/51c2ac26-7fcb-4034-a72d-9066122f21ef)

En el apartado Historial tendremos el Ranking de Victorias y el Historial de Partidas, con la informacion necesaria.

![image](https://github.com/NicolasBoullon/Boullon.Nicolas.TP2/assets/95184975/616d3cbc-b23b-429f-b73e-6aeb6bd54385)




# Justificacion Tecnica

### SQL - Manejo de excepciones - Generics - Serializacion -  Interfaces - Escritura de archivo.
Esto lo utilizo durante toda la aplicacion, SQL, para poder acceder a mi lista de Usuarios y Jugadores, tambien es usado para poder aumentar el ranking de victorias de cada Jugador. Toda conexion controlada por Manejo de excepciones para que 
se controlen las excepciones. Las serializacion junto con los generics, los aplico mutuamente en la forma de serializar ya que utilizo una clase serializadora de tipo generico. Ademas implemento interfaces ya que las firmas estan declaradas
en mi interfaz serializadora. De esta forma implementada en mi clase SerializadoraJson.

### Delegados - Task - Eventos.
Durante el uso del programa, las Task las utilizo al crear una mesa para poder jugar. De esta forma se pueden jugar en simultaneo sin tener ningun problema entre ellas. Una vez terminada la partida, implemento un Evento para poder anunciar el 
ganador y el perdedor. Tambien durante el programa se encuentran delegrados creados para el aviso de alertas, y que se ingrese los datos necesarios en la aplicacion sin romperse.
