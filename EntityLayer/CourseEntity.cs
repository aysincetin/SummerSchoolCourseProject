using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CourseEntity
    {
        private int id;
        private string courseName;
        private int min;
        private int max;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string COURSENAME
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public int MIN
        {
            get { return min; }
            set { min = value; }
        }
        public int MAX
        {
            get { return max; }
            set { max = value; }
        }
    }
}
