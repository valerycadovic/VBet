using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBet.Model.DatabaseApi.MatchLine.Tables;

namespace VBet.Model.DatabaseApi.MatchLine
{

    [Table("Matches")]
    public class MatchEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Teams { get; set; }
        
        [Required]
        public DateTime StartTime { get; set; }

        [MaxLength(50)]
        public string League { get; set; }
        
        public virtual ICollection<CoeffEntity> CoeffsAvailable { get; set; }

        public MatchEntity()
        {
            CoeffsAvailable = new List<CoeffEntity>();
        }
    }
}
