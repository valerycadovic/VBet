namespace VBet.Model.DatabaseApi.UserData
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using VBet.Model.DatabaseApi.UserData.Tables;

    public class UserDataContext : DbContext
    {
        public UserDataContext()
            : base("name=UserDataContext")
        {
        }
        
        public virtual DbSet<BetEntity> Bets { get; set; }
        public virtual DbSet<UserEntity> Users { get; set; }
    }
 }