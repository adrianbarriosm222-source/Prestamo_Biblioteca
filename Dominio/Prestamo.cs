namespace PrestamosBiblioteca.Dominio;

internal sealed class Prestamo
{
    public int Id { get; set; }
    public int LectorId { get; set; }
    public int LibroId { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaLimite { get; set; }
    public DateTime? FechaDevolucion { get; set; }

    public bool EstaActivo => !FechaDevolucion.HasValue;

    public Prestamo() { }

    public Prestamo(int lectorId, int libroId, DateTime fechaPrestamo, DateTime fechaLimite)
    {
        LectorId = lectorId;
        LibroId = libroId;
        FechaPrestamo = fechaPrestamo;
        FechaLimite = fechaLimite;
    }
}