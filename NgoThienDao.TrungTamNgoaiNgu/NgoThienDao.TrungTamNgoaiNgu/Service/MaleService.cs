using Dapper;
using NgoThienDao.TrungTamNgoaiNgu.Models.Request.Male;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NgoThienDao.TrungTamNgoaiNgu.Service
{
    public class MaleService : BaseService
    {
        public MaleService() : base() { }

        public IEnumerable<MaleRequest> GetMaleDetails()
        {
            try
            {
                List<MaleRequest> males = new List<MaleRequest>();

                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    males = con.Query<MaleRequest>("GetMaleDetails").ToList();
                }

                return males;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
