using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLAyer
{
    public class Connection
    {
       public static SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=SummerSchool; Integrated Security=True");
    }
}
