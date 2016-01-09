# investigacion

Introducción 

Este documento forma parte de una serie de artículos que tienen como objetivo registrar los progresos técnicos y metodológicos en la concepción de un dispositivo video-lúdico. El desarrollo de este dispositivo se inscribe en el marco de una investigación teórico-práctica, tomando como eje la implicancia de los conceptos « puesta en escena » , « cuerpo » y « territorio » en los video juegos. 
El objetivo de este documento es establecer instancias de desarrollo, con el fin de dejar constancia escrita de las problemáticas que puedan surgir, así como de la formulación de hipótesis que serán sujetas a prueba en una posterior instancia de experimentación. Una problemática, técnica o conceptual, puede ser suficiente para abrir una nueva instancia de desarrollo, la cual será registrada en su versión inicial como « prototipo 0.1 » 0. (referencia del número de publicaciones, 0: beta), 1 (número de instancia de desarrollo). 

Prototipo

El prototipo 0.1, es la primer instancia de esta iniciativa experimental. El dispositivo toma como base la película « La Passion de Jeanne d’arc » (1928), dirigida por Carl Theodor Dreyer. La imagen de la actriz Maria (ó Renée) Falconetti, Jeanne en el film, es apropiada y sometida a un proceso de montaje. El sistema se configura como un motor de navegación entre una serie de secuencias extraídas del film, correspondientes a la escena del juicio donde la actriz es filmada, durante todo el episodio, mediante un primer plano. A través de nuestro « joystick » podremos navegar estás secuencias, debido a que cada botón, así como sus consecuentes combinaciones, significarán una acción determinada. 

En cuanto al sistema: 

Cada una de estas secuencias, anteriormente mencionadas, consta de un número de 48  cuadros(Frames)en sincronía con una pista de audio. Estas secuencias estarán configuradas en la forma de un bucle. Solo podremos descubrir la forma de este bucle si mantenemos apretado uno de los botones, es decir, al dejar presionada la ejecución de una variable. El bucle se efectúa como un ida y vuelta sobre la línea de tiempo que representa en sí esta secuencia, es decir que del cuadro 0 la secuencia se reproduce hasta su otro extremo, cuadro 47, para luego volver a su posición inicial (cuadro 0 de la secuencia). En caso de soltar el botón, sin importar la posición de la secuencia, por ej. cuadro 12, esta volverá a su posición 0 ( cuadro 0 a 12, 12 a cuadro 0 ) para luego saltar a la posición 0 del estado de reposo. Este estado de reposo es aquel que se ejecuta cuando no presionamos ningún botón. En caso de que apretemos otro botón la secuencia saltará, sin importar el cuadro en el que esté posicionado la reproducción, al cuadro 0 de la secuencia correspondiente a dicho botón presionado.
Las secuencias se ejecutarán a través de los botones direccionales (arriba, abajo, derecha e izquierda), los botones A y B (originales a la configuración del Joystick NES).

Los botones A o B y la combinación de ambos, no representaran la ejecución de una secuencia si no apretamos en conjunto un botón direccional. 
En este orden el número de variables de este prototipo 0.1 se limitará a 16, es decir 16 secuencias en bucle de audio y video, sumada una posición pasiva anteriormente llamada « estado de reposo » . 
 
