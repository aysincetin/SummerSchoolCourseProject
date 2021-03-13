using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ApplicationFormEntity
    {
        private int appId;
        private int appCourseId;
        private int appTeacherId;

        public int APPID
        {
            get { return appId; }
            set { appId = value; }
        }
        public int APPCOURSEID
        {
            get { return appCourseId; }
            set { appCourseId = value; }
        }
        public int APPTEACHERID
        {
            get { return appTeacherId; }
            set { appTeacherId = value; }
        }
    }
}
