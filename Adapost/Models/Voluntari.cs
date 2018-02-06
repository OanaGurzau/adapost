using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Adapost.Models
{
    public class Voluntari
    {
        [Key]
        public int IdVoluntar { get; set; }
        [StringLength(15, ErrorMessage = "Numele nu poate fi mai lung de 15 caractere")]
        public string Nume { get; set; }
        [StringLength(15, ErrorMessage = "Prenumele nu poate fi mai lung de 15 caractere")]
        public string Prenume { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Introdu numarul!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Introdu nr in formatul normal")]
        public string NrTel { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public string Ocupatie { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        public virtual ICollection<Animal> Animal { get; set; }
    }
}