using System;

// Definición de la clase base
public class Animal
{
    public string nombre;
    public int edad;

    public Animal(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public void hacerSonido()
    {
        Console.WriteLine("El animal está haciendo un sonido.");
    }
}

// Definición de la clase derivada
public class Perro : Animal
{
    public string raza;

    public Perro(string nombre, int edad, string raza) : base(nombre, edad)
    {
        this.raza = raza;
    }

    public void ladrar()
    {
        Console.WriteLine("El perro está ladrando.");
    }
}

// Uso de la clase derivada
public class Program
{
    public static void Main()
    {
        Perro miPerro = new Perro("Fido", 5, "Labrador");
        Console.WriteLine("Nombre: " + miPerro.nombre);
        Console.WriteLine("Edad: " + miPerro.edad);
        Console.WriteLine("Raza: " + miPerro.raza);
        miPerro.hacerSonido();
        miPerro.ladrar();
    }
}
