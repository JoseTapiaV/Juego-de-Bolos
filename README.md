# Juego-de-Bolos-VR
 
## a.	Una pista de bolos
Para la creación de la pista de bolos se utilizó un objeto plano con una textura de madera brillante para poder dar la sensación de una tabla de bolos.

![1](https://user-images.githubusercontent.com/49033427/152143904-d06fee49-0afe-48b8-ba63-c5014b01cb03.png)
 
## b.	Diez pinos de bolos
Para poder utilizar los objetos de los pinos que son necesarios e indispensables para jugar bolos, me descargué desde internet un objeto de los pinos y los exporté a la carpeta de texturas.


![2](https://user-images.githubusercontent.com/49033427/152144015-f5475cad-ae31-4c2e-96d1-6688bc592330.png)
![3](https://user-images.githubusercontent.com/49033427/152144018-5ff9f4e6-63d6-48d9-8cc2-065f443fa1ff.png)

## c.	Dos bolas
Para poder utilizar dos bolas de boliche en el juego se utilizó realmente una, la cual cada que llegue al final de la tabla de los bolos, reiniciará y regresará a su posición original para realizar el segundo tiro.

![4](https://user-images.githubusercontent.com/49033427/152144001-934b4d63-4176-45bb-9305-9a085d1a2ebc.png)
 
## d.	Tablero de puntajes
El tablero de puntajes se creo con el canvas y con su texto el cual nos mostrará a cada momento.

![5](https://user-images.githubusercontent.com/49033427/152144007-104d900e-e6ae-45ff-ba46-4ab226eec65e.png)
 
## e.	Dos personajes
Los personajes han sido desccargados desde la página mixamo, la cual nos ayuda a tener varios muñecos con varias animaciones ya listas solo para configurarles y usarlas.
 
![6](https://user-images.githubusercontent.com/49033427/152144010-7b5ec77b-59f0-4459-a63c-f1f6df24c45a.png)

## f.	Generar con base a un script el movimiento de la bola para que permita realizar el lanzamiento por la pista hacia los pinos. El script debe ser activado con base a un evento del sistema.
El script utilizado para el movimiento es en el que se usa las teclas W, A, S, D para poder mover a la bola de boliche.

![7](https://user-images.githubusercontent.com/49033427/152144012-42656e9c-eb5f-42b7-9f54-417dc4775f04.png)

## g.	Generar con base a un script el puntaje de cada pino que ha sido tumbado por el movimiento de las bolas. Cada pino derrumbado tiene un puntaje de 10 puntos.
En el script se programó que cada que la bola de boliche sume 10 puntos cada que toque un pino pero también cada que toque el final de la tabla, se reiniciará y regresará todos los objetos a su posición inicial.
 
![8](https://user-images.githubusercontent.com/49033427/152144013-ad7d66e6-ab6c-4c96-a590-6bf920e808cc.png)

## h.	Al finalizar el lanzamiento de las dos bolas se debe presentar el puntaje final y posterior a esto se debe activar las animaciones de los personajes y finalmente se debe reiniciar para un nuevo juego.
Para el movimiento de los muñecos al realizar el segundo y ultimo tiro de la pelota se utilizó un trigger y un script el cual ejecutará el trigger para poder realizar los bailes finales.

![9](https://user-images.githubusercontent.com/49033427/152144014-a9b0597b-0957-4b6d-9da8-c27a891b4e5c.png)
