using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLAyer;

namespace DataAccessLayer
{
    public class CourseDAL
    {
        public static List<CourseEntity> CourseList()
        {
            List<CourseEntity> values = new List<CourseEntity>();
            SqlCommand command2 = new SqlCommand("Select * from COURSE", Connection.con);
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            SqlDataReader dr = command2.ExecuteReader();
            while (dr.Read())
            {
                CourseEntity std = new CourseEntity
                {
                    ID = Convert.ToInt32(dr["COURSEID"].ToString()),
                    COURSENAME = dr["COURSENAME"].ToString(),
                    MIN = int.Parse(dr["COURSEMINCAPACITY"].ToString()),
                    MAX = int.Parse(dr["COURSEMAXCAPACITY"].ToString())
                };
                values.Add(std);
            }
            dr.Close();
            return values;
        }

        public static int AddRequest(ApplicationFormEntity entity)
        {
            SqlCommand command = new SqlCommand("insert into APPLICATIONFORM(STDID,COURSEID) values (@P1,@P2)",Connection.con);
            command.Parameters.AddWithValue("@P1", entity.APPTEACHERID);
            command.Parameters.AddWithValue("@P2", entity.APPCOURSEID);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            return command.ExecuteNonQuery();

        }
    }
}
