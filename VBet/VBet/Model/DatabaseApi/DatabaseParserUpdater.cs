using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBet.Model.DatabaseApi.MatchLine;
using VBet.Model.DatabaseApi.MatchLine.Tables;
using VBet.Model.Parser;
using VBet.Model.Parser.MatchParser;

namespace VBet.Model
{
    class DatabaseParserUpdater : IUpdater
    {
        private List<MatchEntity> list;
        private string[] leagues;
        private ParserWorker<Match[]> parser;
        private bool isActive;
        List<CoeffEntity> coeffs;

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        public event Action<object> OnCompleted;

        public DatabaseParserUpdater()
        {
            parser = new ParserWorker<Match[]>(new MatchParser(), new MatchSettings());
            list = new List<MatchEntity>();
            leagues = Available.Leagues.ToArray();
            coeffs = new List<CoeffEntity>();


            parser.OnNewData += (matches, league) =>
            {
                foreach (var match in matches)
                {
              
                    MatchEntity row = new MatchEntity();
                    
                    row.StartTime = match.StartTime;
                    row.Teams = match.Teams;
                    row.League = league;
                    
                    foreach (var coeff in match.Coeffs)
                    {
                        CoeffEntity item = new CoeffEntity();

                        item.Coefficient = coeff.Value;
                        item.Formula = coeff.Formula;
                        item.Holder = row;
                        coeffs.Add(item);
                    }

                    list.Add(row);
                }
            };
        }

        public async Task UpdateStorageAsync()
        {
            isActive = true;

            foreach (var league in leagues)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                await parser.UpdatePartAsync(league);

            }
            isActive = false;

            using (MatchesContext db = new MatchesContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var row in db.Matches)
                        {
                            foreach (var coeff in db.Coeffs)
                            {
                                db.Coeffs.Remove(coeff);
                            }

                            db.Matches.Remove(row);
                        }


                        foreach (var row in list)
                        {
                            db.Matches.Add(row);
                        }

                        foreach (var row in coeffs)
                        {
                            db.Coeffs.Add(row);
                        }

                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }


            OnCompleted?.Invoke(this);

        }

    }
}
