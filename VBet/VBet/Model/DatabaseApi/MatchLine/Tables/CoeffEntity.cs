using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.DatabaseApi.MatchLine.Tables
{
    [Table("Coeffs")]
    public class CoeffEntity
    {
        public int Id { get; set; }
        
        [Required]
        public string Formula { get; set; }

        [Required]
        public double Coefficient { get; set; }


        public virtual MatchEntity Holder { get; set; }

        public int HolderId { get; set; }
    }
}
