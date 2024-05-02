namespace Library;

using System;
using System.Threading;

public class Corredor // clase corredor
{
    private string nombre;
    private int distanciaRecorrida;
    private Random random;

    public Corredor(string nombre) // constructor de la clase corredor
    {
        this.nombre = nombre; // se asigna el nombre
        this.distanciaRecorrida = 0; // se asigna la distancia recorrida
        this.random = new Random(); // se crea un objeto random
    }

    public void Correr()// metodo correr
    {
        while (this.distanciaRecorrida < 100) // distancia recorrida sea menor a 100
        {
            this.distanciaRecorrida += random.Next(1, 10); // se suma un valor aleatorio entre 1 y 10 a la distancia recorrida
            Console.WriteLine($"{this.nombre} ha recorrido {this.distanciaRecorrida} metros");// se muestra la distancia recorrida
            Thread.Sleep(1000); // se detiene el hilo por 1 segundo
        }
        Console.WriteLine($"{this.nombre} ha llegado a la meta");
    }
}