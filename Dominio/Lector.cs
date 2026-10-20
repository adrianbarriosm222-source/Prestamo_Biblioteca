namespace PrestamosBiblioteca.Dominio;

internal sealed class Lector : Persona
{
    public Lector() { }

    public Lector(string codigo, string nombre, string correo, string telefono)
    {
        Codigo = codigo;
        Nombre = nombre;
        Correo = correo;
        Telefono = telefono;
    }

    public override string ObtenerInformacion() => 
        $"Lector: {Nombre} (Código: {Codigo}) - Correo: {Correo}";
}