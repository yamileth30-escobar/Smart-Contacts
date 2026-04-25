using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos.EL
{
    // Solo debe decir "public class" una vez
    public class Categoria
    {
        // Identificador único de la categoría (Ej: 1, 2, 3)
        public int Id { get; set; }

        // Nombre de la categoría (Ej: Familia, Trabajo, Amigos)
        public string Nombre { get; set; }
    }
}