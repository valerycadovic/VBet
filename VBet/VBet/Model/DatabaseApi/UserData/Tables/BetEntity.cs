using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.DatabaseApi.UserData.Tables
{
    [Table("Bets")]
    public class BetEntity
    {
        public int Id { get; set; }

        [Required]
        public string Formula { get; set; }

        [Required]
        public string Teams { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public double Coeff { get; set; }

        [Required]
        public double BetPrice { get; set; }


        public UserEntity Holder { get; set; }

        public int HolderId { get; set; }
    }
}
