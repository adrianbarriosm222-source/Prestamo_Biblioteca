using PrestamosBiblioteca.Aplicacion;
using PrestamosBiblioteca.Persistencia;

// Inicializar la base de datos profesionalmente usando la clase y el script externo
var inicializador = new InicializadorBaseDatos();
inicializador.Inicializar();

// Arrancar el menú principal pasándole la cadena de conexión configurada
var repositorio = new RepositorioBiblioteca(inicializador.CadenaConexion);
var menu = new MenuBiblioteca(repositorio);
menu.Ejecutar();