/*
Ejercicio Carrera 
Cree un programa que simule una carrera entre hilos. 
Cada corredor tendrá un nombre, un atributo que diga qué distancia lleva recorrida y correrá a una 
velocidad randómicamente definida. 
Para que se aprecie cómo se desarrolla la carrera cada hilo mostrará su posición actual 
periódicamente. 
Una vez que el primer corredor atraviesa la meta todos los corredores deberán dejar de correr y el 
programa deberá declara el ganador. 
*/

using System;
using System.Threading;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Corredor corredor1 = new Corredor("Corredor 1"); // se crea un objeto corredor
            Corredor corredor2 = new Corredor("Corredor 2");
            Corredor corredor3 = new Corredor("Corredor 3");
            Corredor corredor4 = new Corredor("Corredor 4");
            Corredor corredor5 = new Corredor("Corredor 5");

            Thread hilo1 = new Thread(corredor1.Correr); // se crea un hilo
            Thread hilo2 = new Thread(corredor2.Correr);
            Thread hilo3 = new Thread(corredor3.Correr);
            Thread hilo4 = new Thread(corredor4.Correr);
            Thread hilo5 = new Thread(corredor5.Correr);

            hilo1.Start(); // se inicia el hilo
            hilo2.Start();
            hilo3.Start();
            hilo4.Start();
            hilo5.Start();

            hilo1.Join();
            hilo2.Join();
            hilo3.Join();
            hilo4.Join();
            hilo5.Join();

            Console.WriteLine("Carrera finalizada"); // se muestra mensaje de finalización
        }
    }


}

/*
Se obtiene el mismo resultado si se vuelve a correr el programa? 
Jus fique.

No se obtiene el mismo resultado, ya que la velocidad de los corredores es aleatoria,
por lo tanto, el resultado de la carrera siempre sera diferente
*/