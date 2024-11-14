using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataLayer
{
    public class Cls_Connection 
    {
        public static SqlConnection baglanti
        {
            get
            {
                SqlConnection sqlConnection = new SqlConnection("Server=LAPTOP-SBG0BRRH\\SQLEXPRESS;Trusted_Connection=True;Database=CarRental");
                return sqlConnection;
            }
        }

    }
}
