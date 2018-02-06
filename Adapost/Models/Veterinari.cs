using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Adapost.Models
{
    public class Veterinari
    {
        [Key]
        public int IdVeterinar { get; set; }
        [StringLength(15, ErrorMessage = "Numele nu poate fi mai lung de 15 caractere")]
        public string Nume { get; set; }
        [StringLength(15, ErrorMessage = "Prenumele nu poate fi mai lung de 15 caractere")]
        public string Prenume { get; set; }
        public int idAnimal_fk { get; set; }
        public virtual ICollection<Animal> Animal { get; set; }

    }
}