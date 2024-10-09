public class Estudiante : Persona
{
    public int Matricula { get; set; }
    public string Carrera { get; set; }

    public Estudiante(string nombre, string apellido, int edad, string identificacion, int matricula, string carrera)
        : base(nombre, apellido, edad, identificacion)
    {
        Matricula = matricula;
        Carrera = carrera;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Estudiante: {Nombre} {Apellido}, {Edad} años, Matrícula: {Matricula}, Carrera: {Carrera}");
    }
}
