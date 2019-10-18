using Dapper;
using NgoThienDao.TrungTamNgoaiNgu.Models.Request.Level;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NgoThienDao.TrungTamNgoaiNgu.Service
{
    public class LevelService : BaseService
    {
        public LevelService() : base() { }

        public IEnumerable<Level> GetLevelDetails()
        {
            try
            {
                List<Level> levels = new List<Level>();

                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    levels = con.Query<Level>("GetLevelDetails").ToList();
                }

                return levels;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
