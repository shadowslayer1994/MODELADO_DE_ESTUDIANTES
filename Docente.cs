public class Docente : Persona
{
    public string Materia { get; set; }
    public int AñosExperiencia { get; set; }

    public Docente(string nombre, string apellido, int edad, string identificacion, string materia, int añosExperiencia)
        : base(nombre, apellido, edad, identificacion)
    {
        Materia = materia;
        AñosExperiencia = añosExperiencia;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Docente: {Nombre} {Apellido}, {Edad} años, Materia: {Materia}, Años de Experiencia: {AñosExperiencia}");
    }
}
