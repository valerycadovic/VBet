using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBet.Model.DatabaseApi.UserData.Tables
{
    [Table("Users")]
    public class UserEntity
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string SecondName { get; set; }
        
        public int Id { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string UserStatus { get; set; }
        
        [Required]
        public double Cash { get; set; }


        public ICollection<BetEntity> BetList { get; set; }

        public ICollection<HistoryEntity> History { get; set; }

        public UserEntity()
        {
            BetList = new List<BetEntity>();
            History = new List<HistoryEntity>();
        }

    }
}
