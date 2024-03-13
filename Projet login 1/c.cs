using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projet_login_1
{
    class c
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=commercia;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader dr;
        
        public static SqlDataAdapter ad_cl = new SqlDataAdapter("select * from client", con);
        public static DataSet ds = new DataSet("commercia");
        public static DataTable dt = new DataTable();
        public static SqlCommandBuilder db = new SqlCommandBuilder(ad_cl);
    }
}
