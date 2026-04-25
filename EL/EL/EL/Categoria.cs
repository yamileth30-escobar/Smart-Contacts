namespace AgendaContactos.EL
{
    public class Categoria
    {
        public int Id { get; set; }
        public string NombreCategoria { get; set; } = string.Empty;

        public Categoria() { }

        public Categoria(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString() => Nombre ?? string.Empty;
    }
}