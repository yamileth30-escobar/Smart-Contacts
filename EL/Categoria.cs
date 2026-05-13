// Importación de librerías básicas del sistema
using System;

// Importación de colecciones genéricas
using System.Collections.Generic;

// Permite realizar consultas LINQ
using System.Linq;

// Proporciona clases para manejo de texto y codificación
using System.Text;

// Permite trabajar con tareas asíncronas
using System.Threading.Tasks;

// Espacio de nombres del proyecto AgendaContactos
namespace AgendaContactos.EL
{
    // Clase que representa una categoría de contactos
    public class Categoria
    {
        // Propiedad que almacena el identificador único de la categoría
        // Ejemplo: 1, 2, 3
        public int Id { get; set; }

        // Propiedad que almacena el nombre de la categoría
        // Ejemplo: Familia, Trabajo, Amigos
        public string Nombre { get; set; }
    }
}
