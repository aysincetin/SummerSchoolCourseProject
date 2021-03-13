using DataAccessLAyer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentDAL
    {
        public static int AddStudent(StudentEntity std)
        {
            SqlCommand command1 = new SqlCommand("insert into dbo.STUDENT(STDNAME,STDSURNAME,STDNUMBER,STDPHOTO,STDPASSWORD) values (@p1,@p2,@p3,@p4,@p5)", Connection.con);
            if (command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            command1.Parameters.AddWithValue("@p1", std.NAME);
            command1.Parameters.AddWithValue("@p2", std.SURNAME);
            command1.Parameters.AddWithValue("@p3", std.NUMBER);
            command1.Parameters.AddWithValue("@p4", std.PHOTO);
            command1.Parameters.AddWithValue("@p5", std.PASSWORD);

            return command1.ExecuteNonQuery();
        }

        public static List<StudentEntity> StudentList()
        {
            List<StudentEntity> values = new List<StudentEntity>();
            SqlCommand command2 = new SqlCommand("Select * from STUDENT",Connection.con);
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            SqlDataReader dr = command2.ExecuteReader();
            while (dr.Read())
            {
                StudentEntity std = new StudentEntity
                {
                    ID = Convert.ToInt32(dr["STDID"].ToString()),
                    NAME = dr["STDNAME"].ToString(),
                    SURNAME = dr["STDSURNAME"].ToString(),
                    NUMBER = dr["STDNUMBER"].ToString(),
                    PHOTO = dr["STDPHOTO"].ToString(),
                    PASSWORD = dr["STDPASSWORD"].ToString(),
                    MONEY = Convert.ToDouble(dr["STDMONEY"].ToString())
                };
                values.Add(std);
            }
            dr.Close();
            return values;
        }

        public static bool DeleteStudent(int std)
        {
            SqlCommand command3 = new SqlCommand("Delete STUDENT where STDID=@P1", Connection.con);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@P1", std);
            return command3.ExecuteNonQuery() > 0;
        }

        public static List<StudentEntity> StudentDetail(int id)
        {
            List<StudentEntity> values = new List<StudentEntity>();
            SqlCommand command4 = new SqlCommand("Select * from STUDENT where STDID=@P1", Connection.con);
            command4.Parameters.AddWithValue("@P1",id);
            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            SqlDataReader dr = command4.ExecuteReader();
            while (dr.Read())
            {
                StudentEntity std = new StudentEntity
                {
                    NAME = dr["STDNAME"].ToString(),
                    SURNAME = dr["STDSURNAME"].ToString(),
                    NUMBER = dr["STDNUMBER"].ToString(),
                    PHOTO = dr["STDPHOTO"].ToString(),
                    PASSWORD = dr["STDPASSWORD"].ToString(),
                    MONEY = Convert.ToDouble(dr["STDMONEY"].ToString())
                };
                values.Add(std);
            }
            dr.Close();
            return values;
        }

        public static bool UpdateStudent(StudentEntity value)
        {
            SqlCommand command5 = new SqlCommand("Update STUDENT Set STDNAME=@P1, STDSURNAME=@P2, STDNUMBER=@P3, STDPHOTO=@P4, STDPASSWORD=@P5 where STDID=@P6", Connection.con);
            if (command5.Connection.State != ConnectionState.Open)
            {
                command5.Connection.Open();
            }
            command5.Parameters.AddWithValue("@P1", value.NAME);
            command5.Parameters.AddWithValue("@P2", value.SURNAME);
            command5.Parameters.AddWithValue("@P3", value.NUMBER);
            command5.Parameters.AddWithValue("@P4", value.PHOTO);
            command5.Parameters.AddWithValue("@P5", value.PASSWORD);
            command5.Parameters.AddWithValue("@P6", value.ID);
            return command5.ExecuteNonQuery() > 0;
        }

    }
}
