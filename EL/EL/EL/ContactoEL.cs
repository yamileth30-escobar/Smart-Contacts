using System;

namespace AgendaContactos.EL
{
    public class ContactoEL
    {
        public int ContactoId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int? CategoriaId { get; set; }
    }
}
