public class Album
{
    public List<Canciones> ListaDeCanciones;
    public string Nombre { get; private set; }
    public string Cantante { get; private set; }
    public string Genero { get; private set; }
    public string Productor { get; private set; }
    public string Foto{ get; private set; }
    public Album(string nombre, string cantante, string genero, string productor, List<Canciones> listaDeCanciones, string foto)
    {
        Nombre = nombre;
        Cantante = cantante;
        Genero = genero;
        Productor = productor;
        ListaDeCanciones = listaDeCanciones;
        Foto = foto;
    }
}