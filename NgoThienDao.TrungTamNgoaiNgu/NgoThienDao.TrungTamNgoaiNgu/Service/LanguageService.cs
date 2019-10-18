using Dapper;
using NgoThienDao.TrungTamNgoaiNgu.Models.Request.Language;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NgoThienDao.TrungTamNgoaiNgu.Service
{
    public class LanguageService : BaseService
    {
        public LanguageService() : base() { }

        public IEnumerable<LanguageRequest> GetLanguageDetails()
        {
            try
            {
                List<LanguageRequest> levels = new List<LanguageRequest>();

                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    levels = con.Query<LanguageRequest>("GetLanguageDetails").ToList();
                }

                return levels;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
