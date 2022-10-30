# Patrones De Diseño

## Patrones Creacionales

Son patrones de diseño relacionados con la creación o construcción de objetos. Estos patrones intentan controlar la forma en que los objetos son creados implementando mecanismos que eviten la creación directa de objetos.

### Patrón Factory Method

Patrón que se centra en la creación de una clase fábrica la cual tiene métodos que nos permitan crear objetos de un subtipo determinado.

#### Cuando utilizarlo

* Cuando la creación directa de un objeto por medio del operador new pueda ser perjudicial.
* Cuando no se conoce en tiempo de diseño la subclase que se utilizará.
* Cuando construimos un objeto basado en una serie de condiciones else if o switch.

### Patrón Abstract Factory

Patrón muy similar al Factory Method, sin embargo, este patrón nos permite crear objetos de una determinada familia de clases.

### Patrón Singelton

Patrón utilizado para controlar la creación de una clase determinada, de esta forma sólo se puede crear una única instancia en toda la aplicación.

### Patrón Builder

Patrón que permite la creación de objetos complejos desde un objeto Builder. El objeto Builder se compone de una variedad de partes que contribuyen individualmente a la creación del objeto.

### Patrón Prototype

Este patrón se centra en la creación de objetos a partir de la clonación de otros objetos existentes. Es mucho más rápido clonar un objeto que crear uno nuevo.

### Patrón Object Pool

Patrón que se utiliza para mantener un conjunto de objetos creados listos para ser utilizados, evitando crearlos bajo demanda cada vez que se requieran. Los objetos desocupados son devueltos al pool en vez de destruirse (muy utilizado para Pool de Conexiones).

## Patrones Estructurales

Son patrones de diseño que tienen que ver con la forma en que las clases se relacionan con otras clases. Estos patrones ayudan a dar un mayor orden a nuestras clases ayudando a crear componentes más flexibles y extensibles.

### Patrón Adapter

Resuelve escenarios donde existen interfaces incompatibles creando adaptadores que nos ayuden a comunicarnos con las interfaces de una forma genérica

### Patrón Bridge

Patrón utilizado para desacoplar una abstracción de su implementación permitiendo la variación entre ellas.

### Patrón Composite

Patrón de diseño que nos permite la creación de estructuras de objetos complejas mediante la agregación.

### Patrón Decorator

Patrón de diseño utilizado para agregar funcionalidad a un objeto mediante la asociación de otros objetos. Este patrón nos evita la creación de clases que hereden de la primera incorporando la nueva funcionalidad, sino otras que la implementan y se asocian a la primera.

### Patrón Facade

Mediante la implementación de este patrón, se pueden crear fachadas que permitan ocultar la complejidad de interactuar con un conjunto de subsistemas, mediante la implementación de interfaces de alto nivel las cuales se encarguen de realizar la comunicación con todos los subsistemas. 

### Patrón Flyweight

Patrón enfocado a la creación de objetos ligeros. Los objetos ligeros se logran mediante la abstracción de partes reutilizables que son compartidos por otros objetos en vez de crear nuevos cada vez que son requeridos.

### Patrón Proxy

Patrón de diseño utilizado para la mediación entre un objeto y otro. Se conoce como mediación a las acciones que se pueden hacer antes y después de realizar la acción solicitada.

## Patrones de Comportamiento

Son patrones que están relacionados con procedimientos y con la asignación de responsabilidad a los objetos. Los patrones de comportamiento engloban también patrones de comunicación entre ellos.

### Patrón Iterator

Nos permite recorrer estructuras de datos ya sean simples o complejas sin conocer la estructura interna de la misma, mediante la creación de una interface que nos permite obtener el siguiente elemento de la estructura.

### Patrón Command

Patrón que nos permite ejecutar operaciones sin saber exactamente que clase atenderá nuestra petición. Mediante los comandos podemos encapsular la lógica de ejecución, de tal manera que el cliente sólo sepa de la existencia del comando y los parámetros necesarios para su ejecución.

### Patrón Observer

Patrón de diseño utilizado para observar los cambios o eventos generados por otros objetos con la finalidad de realizar acciones en consecuencia de algún cambio sobre nuestro objeto observado.

### Patrón Templete Method

Patrón de diseño enfocado en la reutilización de código, mediante la creación de templetes, los cuales son clases con funcionalidad y pasos predefinidos para que las subclases sobrescriban o personalicen algunos de los pasos predefinidos por el templete.

### Patrón Strategy

Permite mediante la implementación de estrategias el intercambio de responsabilidad. Las estrategias son clases que definen un comportamiento a la clase que las contienen y mediante este intercambio de estrategias es como se logra alterar el comportamiento de las clases en tiempo de ejecución.

### Patrón Chain of Responsability

Permite resolver problemas mediante el encadenamiento de objetos. Cada objeto que es encadenado va resolviendo parte del problema. Este patrón es utilizado cuando la resolución por medio de la herencia no es posible.

### Patrón Interpreter

Patrón diseñado para la interpretación de lenguajes que, mediante un conjunto de expresiones que representan dicho lenguaje, es capaz de interpretarlo y arrojar un resultado como parte de esta interpretación.

### Patrón Mediator

Patrón de diseño para gestionar la forma en que un conjunto de clases se comunican entre sí, sobre todo cuando las clases tienen una comunicación directa y el número de clases es grande. Mediator crea una capa de mediación que permite intervenir entre la comunicación de estas clases.

### Patrón Memento

Permite capturar el estado de un objeto en un tiempo determinado, con la finalidad de poder regresar a este estado en cualquier momento.

### Patrón Null Object

Patrón que nace de la necesidad de evitar regresar valores nulos, los cuales pudieran ocasionar problemas en tiempo de ejecución, en su lugar el patrón propone la creación de implementaciones básicas, las cuales implementen las operaciones sin cuerpo.

### Patrón State

Permite la implementación de aplicaciones que basan su comportamiento dependiendo del estado en el que se encuentre la aplicación. Una aplicación puede pasar por varios estados y cada estado podrá ir cambiando a medida que se interactúa con la aplicación.

### Patrón Visitor

Patrón que permite separar las operaciones de la estructura de datos en cuestión. El visitante permite recorrer una estructura de datos completa mediante un método especial, el cual permite que el visitante vaya a cada nodo de la estructura obteniendo con esto un resultado. Visitante se implementa por lo general en estructuras en forma de árbol.