using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapperDevExpress.Models
{
    class StudentRepository : IGenericRepository<Student>
    {
        readonly IDbConnection _connection;
        public StudentRepository()
        {
            _connection = AppConnection.GetConnection();
        }

        public bool Add(Student student)
        {
            int rowsEffected = 0;
            try
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.AddDynamicParams(new { student.FullName, student.Gender, student.Age, student.Email, student.Address });

                rowsEffected = _connection.Execute(@"insert into Students (FullName, Gender, Age, Email, Address) values (@FullName, @Gender, @Age, @Email, @Address)", p);
            }
            catch (Exception) { }
            return rowsEffected > 0;
        }

        public bool Delete(int studentID)
        {
            int rowsEffected = 0;
            try
            {
                rowsEffected = _connection.Execute(@"delete from Students where StudentID = @StudentID", new { StudentID = studentID });
            }
            catch (Exception)
            {
            }
            return rowsEffected > 0;
        }

        public IEnumerable<Student> GetAll()
        {
            IEnumerable<Student> result = null;
            try
            {
                result = _connection.Query<Student>(@"select * from Students");
            }
            catch (Exception)
            {
            }
            return result;
        }

        public Student GetById(int studentID)
        {
            Student result = null;
            try
            {
                result = _connection.QueryFirstOrDefault<Student>(@"select * from Students where StudentID = @StudentID", new { StudentId = studentID });
            }
            catch (Exception)
            {
            }
            return result;
        }

        public bool Update(Student student)
        {
            int rowsEffected = 0;
            try
            {
                rowsEffected = _connection.Execute(@"update Students set FullName = @FullName, Gender = @Gender, Age = @Age, Email = @Email, Address = @Address where StudentId = @StudentID",
                    new { student.FullName, student.Gender, student.Age, student.Email, student.Address, student.StudentID });
            }
            catch (Exception)
            {
            }
            return rowsEffected > 0;
        }

        public bool IsExists(int studentID)
        {
            var result = 0;
            try
            {
                result = _connection.QueryFirstOrDefault(@"select count(studentID) from Students where StudentID = @StudentID", new { StudentID = studentID });
            }
            catch (Exception)
            { }
            return result > 0;
        }
    }
}
