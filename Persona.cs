public class Persona
{
    protected string Nombre { get; set; }
    protected string Apellido { get; set; }
    protected int Edad { get; set; }
    protected string Identificacion { get; set; }

    public Persona(string nombre, string apellido, int edad, string identificacion)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Identificacion = identificacion;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Persona: {Nombre} {Apellido}, {Edad} años, Identificación: {Identificacion}");
    }
}
