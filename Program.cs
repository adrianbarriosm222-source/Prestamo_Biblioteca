using Microsoft.Data.Sqlite;
using PrestamosBiblioteca.Aplicacion;
using PrestamosBiblioteca.Persistencia;

var cadenaConexion = "Data Source=biblioteca.db";

using (var conexion = new SqliteConnection(cadenaConexion))
{
    conexion.Open();
    using var comando = conexion.CreateCommand();
    comando.CommandText = @"
        CREATE TABLE IF NOT EXISTS Lectores (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Codigo TEXT NOT NULL,
            Nombre TEXT NOT NULL,
            Correo TEXT NOT NULL,
            Telefono TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS Libros (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Codigo TEXT NOT NULL,
            Titulo TEXT NOT NULL,
            Autor TEXT NOT NULL,
            Ejemplares INTEGER NOT NULL
        );

        CREATE TABLE IF NOT EXISTS Prestamos (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            LectorId INTEGER NOT NULL,
            LibroId INTEGER NOT NULL,
            FechaPrestamo TEXT NOT NULL,
            FechaLimite TEXT NOT NULL,
            FechaDevolucion TEXT,
            FOREIGN KEY(LectorId) REFERENCES Lectores(Id) ON DELETE CASCADE,
            FOREIGN KEY(LibroId) REFERENCES Libros(Id) ON DELETE CASCADE
        );
    ";
    comando.ExecuteNonQuery();
}

var repositorio = new RepositorioBiblioteca(cadenaConexion);
var menu = new MenuBiblioteca(repositorio);
menu.Ejecutar();