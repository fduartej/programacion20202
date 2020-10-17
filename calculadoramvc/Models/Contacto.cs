using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace calculadoramvc.Models
{
    [Table("t_contacto")]
    public class Contacto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor ingrese Nombre")]
        [Display(Name="Nombre")]
         [Column("name")]
        public String Name { get; set; }


        [Required(ErrorMessage = "Por favor ingrese Apellido")]
        [Display(Name="Apellido")]
        [Column("lastname")]
        public String LastName { get; set; }

        [Display(Name="Email")]
        [Column("email")]
        public String Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name="Telefono")]
        [Column("phone")]
        public int Phone { get; set; }

        [Display(Name="Titulo")]
        [Column("subject")]
        public String Subject { get; set; }

        [Display(Name="Mensaje")]
        [Column("message")]
        public String Message { get; set; }

        public String Response { get; set; }

    }
}