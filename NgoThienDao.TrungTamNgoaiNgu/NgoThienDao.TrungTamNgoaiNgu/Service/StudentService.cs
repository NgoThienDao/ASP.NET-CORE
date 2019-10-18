using Dapper;
using NgoThienDao.TrungTamNgoaiNgu.Models.Reponse.Student;
using NgoThienDao.TrungTamNgoaiNgu.Models.Request.Student;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NgoThienDao.TrungTamNgoaiNgu.Service
{
    public class StudentService : BaseService
    {
        public StudentService() : base() { }

        public IEnumerable<StudentView> SearchAndViewStudent(string keyword)
        {
            try
            {
                List<StudentView> students = new List<StudentView>();
                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@keyword", keyword);
                    students = con.Query<StudentView>("GetAndSearchStudentDetails", parameters, commandType: CommandType.StoredProcedure).ToList();
                }
                return students;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int InsertStudent(StudentCreate model)
        {
            try
            {
                int rowAffected = 0;
                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@StudentName", model.StudentName);
                    parameters.Add("@DOB", model.DOB);
                    parameters.Add("@Email", model.Email);
                    parameters.Add("@IDLanguage", model.IDLanguage);
                    parameters.Add("@IDLevel", model.IDLevel);
                    parameters.Add("@IDMale", model.IDMale);

                    rowAffected = con.Execute("InsertStudent", parameters, commandType: CommandType.StoredProcedure);
                }

                return rowAffected;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public StudentDetail GetStudentByID(int? id)
        {
            try
            {
                StudentDetail student = new StudentDetail();
                if (id == null)
                    return student;

                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    DynamicParameters parameter = new DynamicParameters();
                    parameter.Add("@ID", id);
                    student = con.Query<StudentDetail>("GetStudentByID", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }

                return student;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateStudent(StudentEdit model)
        {
            try
            {
                int rowAffected = 0;

                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@ID", model.ID);
                    parameters.Add("@StudentName", model.StudentName);
                    parameters.Add("@DOB", model.DOB);
                    parameters.Add("@Email", model.Email);
                    parameters.Add("@IDLanguage", model.IDLanguage);
                    parameters.Add("@IDLevel", model.IDLevel);
                    parameters.Add("@IDMale", model.IDMale);
                    rowAffected = con.Execute("UpdateStudent", parameters, commandType: CommandType.StoredProcedure);
                }

                return rowAffected;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteStudent(int id)
        {
            try
            {
                int rowAffected = 0;
                using (IDbConnection con = new SqlConnection(strConnectionString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@ID", id);
                    rowAffected = con.Execute("DeleteStudent", parameters, commandType: CommandType.StoredProcedure);

                }

                return rowAffected;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
