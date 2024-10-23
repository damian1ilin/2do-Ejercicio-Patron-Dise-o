Utilizando el Patron Factory Method, el proyecto muestra:
Tocando el botón 1 y 2 le damos instrucciones a la "FactoryManager", que se encarga de comunicarle a cada respectiva factory para crear un circulo o un cuadrado.
Tocando Q y W podemos interactuar con todos las figuras de cada tipo.

En el ejemplo vemos como hay 2 fábricas que se encargan de spawnear objetos que comparten una Interfaz, (Herencia enrealidad, a Unity no le gusta Interfaz para este caso por algun motivo extravagante).
Cada factory mantiene su referencia y linkea el producto a un "cliente", en este caso el accionador, que despues se encarga de interactuar con el objeto.
Cada objeto recibe un mismo método, por lo que el cliente es intercambiable totalmente, sin dependecia de cuál es el objeto en sí.
