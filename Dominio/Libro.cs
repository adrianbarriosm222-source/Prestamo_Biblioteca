namespace PrestamosBiblioteca.Dominio;

internal sealed class Libro
{
    public int Id { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public int Ejemplares { get; set; }

    public Libro() { }

    public Libro(string codigo, string titulo, string autor, int ejemplares)
    {
        Codigo = codigo;
        Titulo = titulo;
        Autor = autor;
        Ejemplares = ejemplares;
    }
}