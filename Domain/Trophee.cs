using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Trophee
    {
        public int TropheeId { get; set; }

        [DataType(DataType.Currency)]
        public double Recompense { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datetrophee { get; set; }

        public String TypeTrophee { get; set; }

        public Equipe Equipe { get; set; }

        public int EquipeId { get; set; }
    }
}
