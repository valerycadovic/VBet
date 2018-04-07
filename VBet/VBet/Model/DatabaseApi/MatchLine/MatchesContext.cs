namespace VBet.Model.DatabaseApi.MatchLine
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using VBet.Model.DatabaseApi.MatchLine.Tables;

    public class MatchesContext : DbContext
    {
        public MatchesContext()
            : base("name=MatchesContext")
        {
        }
        
     
        // tables
        public virtual DbSet<MatchEntity> Matches { get; set; }
        public virtual DbSet<CoeffEntity> Coeffs { get; set; }
    }
    
}