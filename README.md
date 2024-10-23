1 Patrón seleccionado:
  Utilizando el Patron Factory Method, el proyecto muestra:


2 Descripción del proyecto (de que se trata o que se espera ver):

  Tocando el botón 1 y 2 le damos instrucciones a la "FactoryManager", que se encarga de comunicarle a cada respectiva factory para crear un circulo o un cuadrado.
  Tocando Q y W podemos interactuar con todos las figuras de cada tipo.

  En el ejemplo vemos como hay 2 fábricas que se encargan de spawnear objetos que comparten una Interfaz, (Herencia enrealidad, a Unity no le gusta Interfaz para este caso por algun motivo extravagante).
  Cada factory mantiene su referencia y linkea el producto a un "cliente", en este caso el accionador, que despues se encarga de interactuar con el objeto.
  Cada objeto hereda de una misma base, por lo que recibe un mismo método, y el cliente es totalmente intercambiable, sin dependecia de cuál es el objeto en sí.


3 Cuál es la problemática con la que nos encontraríamos en el ejercicio si no aplicaramos el patrón? y 4 Porqué el patrón soluciona esa problemática? de que forma lo hace?: 

  Tal vez para este ejemplo en concreto no habría una "problematica" como tal, ya que se podría llegar al mismo resultado de mil maneras diferentes. Este patrón y solucion lo que brindan es una manera organizada de llevar acabo la ejecución.
  Presenta una clara estructura de referencias y funciones que es facil de leer y mantener a futuro a medida que el proyecto crezca.


4 Que ventajas y desventajas tiene el patrón seleccionado?:

  La ventaja que brinda este patrón es que es muy facil leer y mantener código que está tan bien presentado y estructurado, googleando encontré varios tutoriales o ejemplos que adentraban en este patrón y la verdad era bastante fácil seguirles el ritmo y entender todo.
  También da una clara diferenciación entre clases con responsabilidades únicas, y también recae en el principio de abierto/cerrado.
  La desventaja es que tal vez no sea lo mas eficiente en cuanto a tiempo para tareas chicas;
  Plantear la estructura representa una carga extra por adelantado que despues hay que adaptar a cada uso interno, y si se quiere utilizar para tareas simples o con pocas dependencias o "chance" de romper otras cosas, me parecería un desperdicio de tiempo/recursos.
  Tal vez no sea algo que busque plantear de entrada en mis proyectos, pero si sería una forma de refactorizar algo existente llegado el momento de cierta complejidad.

