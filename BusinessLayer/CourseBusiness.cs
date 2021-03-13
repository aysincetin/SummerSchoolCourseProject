using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CourseBusiness
    {
        public static List<CourseEntity> ListBusiness() //
        {
            return CourseDAL.CourseList();
        }
        public static int AddRequestBusiness(ApplicationFormEntity entity)
        {
            if (entity.APPTEACHERID != null && entity.APPCOURSEID != null)
            {
                return CourseDAL.AddRequest(entity);
            }
            return -1;
        }
    }
}
