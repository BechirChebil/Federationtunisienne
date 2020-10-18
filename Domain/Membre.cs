using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Membre
    {
        [Key]
        public int Identifiant { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }

        [Required(ErrorMessage ="nom obligatoire")]
        public String Nom { get; set; }

        [Required(ErrorMessage = "prenom obligatoire")]
        public String Prenom { get; set; }

        public ICollection<Contrat> Contrats { get; set; }


    }
}
