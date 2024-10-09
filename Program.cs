using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Persona> personas = new List<Persona>();

        // Añadir estudiantes
        personas.Add(new Estudiante("Ana", "Gómez", 21, "2020345", 2020345, "Ingeniería"));
        personas.Add(new Estudiante("Luis", "Ramos", 23, "2020346", 2020346, "Derecho"));

        // Añadir docentes
        personas.Add(new Docente("Pedro", "Fernández", 40, "123456", "Programación", 10));
        personas.Add(new Docente("María", "López", 35, "654321", "Matemáticas", 8));

        // Añadir administrativos
        personas.Add(new Administrativo("Laura", "Morales", 35, "789012", "Recursos Humanos", "Jefa de Personal"));
        personas.Add(new Administrativo("Carlos", "Pérez", 30, "789013", "Finanzas", "Contador"));

        // Mostrar información de todas las personas
        Console.WriteLine("Información de todas las personas:");
        foreach (var persona in personas)
        {
            persona.MostrarInformacion();
        }

        // Mostrar solo estudiantes
        Console.WriteLine("\nSolo Estudiantes:");
        foreach (var persona in personas)
        {
            if (persona is Estudiante)
            {
                persona.MostrarInformacion();
            }
        }

        // Mostrar solo docentes
        Console.WriteLine("\nSolo Docentes:");
        foreach (var persona in personas)
        {
            if (persona is Docente)
            {
                persona.MostrarInformacion();
            }
        }

        // Mostrar solo administrativos
        Console.WriteLine("\nSolo Administrativos:");
        foreach (var persona in personas)
        {
            if (persona is Administrativo)
            {
                persona.MostrarInformacion();
            }
        }
    }
}
