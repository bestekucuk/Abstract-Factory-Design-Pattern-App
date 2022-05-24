using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Abstract_Factory_Design_Pattern_App
{
    class SqlBaglantisi
    {
        
        public SqlConnection baglan()
        {
            SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Seyahat;Integrated Security=True");
            connection.Open();
            return connection;
        }
        
    }
}
