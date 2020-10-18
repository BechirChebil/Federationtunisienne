using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Contrat
    {
        [Key]
        [Column(Order =0)]
        public DateTime DateContrat { get; set; }

        [Range(0,24)]
        public int DureeMois { get; set; }

        public double Salaire { get; set; }

        public Equipe Equipe { get; set; }

        [Key]
        [Column(Order = 1)]
        public int EquipeId { get; set; }

        public Membre Membre { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Identifiant { get; set; }


    }
}
