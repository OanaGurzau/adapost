using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Adapost.Models
{
    public enum SterilizatCastrat
    {
        sterilizat, castrat
    }


    public class Animal
    {
        [Key]
        public int IdAnimal { get; set; }
        [StringLength(1, ErrorMessage = "Tipul de animal trebuie sa fie P pentru pisica sau C pentru caine")]
        public string TipAnimal { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        
        public DateTime DataNastere { get; set; }
        
        public string Rasa { get; set; }
        public SterilizatCastrat? SterilizatCastrat{ get; set; }

        public virtual Angajati Angajati { get; set; }
        public virtual Veterinari Veterinari { get; set; }
        public virtual Voluntari Voluntari { get; set; }
        



    }
}