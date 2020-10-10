using System;
using System.ComponentModel.DataAnnotations;

namespace calculadoramvc.Models
{
    public class Contacto
    {
        [Display(Name="Nombre")]
        public String Name { get; set; }

        [Display(Name="Apellido")]
        public String LastName { get; set; }

        [Display(Name="Email")]
        public String Email { get; set; }

        [Display(Name="Telefono")]
        public int Phone { get; set; }

        [Display(Name="Titulo")]
        public String Subject { get; set; }

        [Display(Name="Mensaje")]
        public String Message { get; set; }

        public String Response { get; set; }

    }
}