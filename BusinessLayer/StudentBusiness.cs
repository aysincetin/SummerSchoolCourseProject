using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBusiness
    {
        public static int AddStdBusiness(StudentEntity entity)
        {
            if (entity.NAME != null &&
               entity.SURNAME != null &&
               entity.NUMBER != null &&
               entity.PASSWORD != null &&
               entity.PHOTO != null)
            {
                return StudentDAL.AddStudent(entity);
            }
            return -1;
        }

        public static List<StudentEntity> ListStdBusiness()
        {
            return StudentDAL.StudentList();
        }

        public static bool DeleteStdBusiness(int entity)
        {
            if (entity >= 0)
            {
                return StudentDAL.DeleteStudent(entity);
            }
            return false;
        }
        public static List<StudentEntity> DetailStdBusiness(int entity)
        {
            return StudentDAL.StudentDetail(entity);
        }

        public static bool UpdateStdBusiness(StudentEntity entity)
        {
            if (entity.NAME != null && entity.NAME != " " &&
               entity.SURNAME != null && entity.SURNAME != " " &&
               entity.NUMBER != null && entity.NUMBER != " " &&
               entity.PASSWORD != null && entity.PASSWORD != " " &&
               entity.PHOTO != null && entity.PHOTO != " " &&
               entity.ID > 0)
            {
                return StudentDAL.UpdateStudent(entity);
            }
            return false;
        }
    }
}
