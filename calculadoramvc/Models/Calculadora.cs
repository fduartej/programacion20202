using System;
using System.ComponentModel.DataAnnotations;


namespace calculadoramvc.Models
{
    public class Calculadora
    {
        public int Operador1 { get; set; }
        public int Operador2 { get; set; }

        public String Acccion { get; set; }

        [Display(Name="Output")]
        public int Respuesta { get; set; }

    }
}
