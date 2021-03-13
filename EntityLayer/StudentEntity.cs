using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class StudentEntity
    {
        private int id;
        private string name;
        private string surName;
        private string number;
        private string photo;
        private string password;
        private double money;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public string SURNAME
        {
            get { return surName; }
            set { surName = value; }
        }
        public string NUMBER
        {
            get { return number; }
            set { number = value; }
        }
        public string PHOTO
        {
            get { return photo; }
            set { photo = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
        public double MONEY
        {
            get { return money; }
            set { money = value; }
        }
    }
}

