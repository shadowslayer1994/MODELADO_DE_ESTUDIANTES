public class Administrativo : Persona
{
    public string Departamento { get; set; }
    public string Puesto { get; set; }

    public Administrativo(string nombre, string apellido, int edad, string identificacion, string departamento, string puesto)
        : base(nombre, apellido, edad, identificacion)
    {
        Departamento = departamento;
        Puesto = puesto;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Administrativo: {Nombre} {Apellido}, {Edad} años, Departamento: {Departamento}, Puesto: {Puesto}");
    }
}
