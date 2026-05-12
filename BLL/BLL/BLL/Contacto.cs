﻿namespace BLL
{
    // Clase pública llamada Contacto
    // Se utiliza para almacenar la información de un contacto
    public class Contacto
    {
        // Propiedad para guardar el nombre del contacto
        public object Nombre { get; set; }

        // Propiedad para guardar el número de teléfono
        public object Telefono { get; set; }

        // Propiedad para guardar el correo electrónico
        public object Correo { get; set; }

        // Propiedad para guardar la dirección del contacto
        public object Direccion { get; set; }

        // Propiedad para guardar el identificador único del contacto
        public int Id { get; set; }
    }
  }
