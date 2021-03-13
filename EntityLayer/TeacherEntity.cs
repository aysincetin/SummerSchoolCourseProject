using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class TeacherEntity
    {
        private int tchid;
        private string tchName;
        private int tchDepartment;

        public int TCHID
        {
            get { return tchid; }
            set { tchid = value; }
        }
        public string TCHNAME
        {
            get { return tchName; }
            set { tchName = value; }
        }
        public int TCHDEPARTMENT
        {
            get { return tchDepartment; }
            set { tchDepartment = value; }
        }
    }
}
