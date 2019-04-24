using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
namespace MVC_Learning_Session_1.Models
{
    public class Dummy_Test_DBContext
    {
        public int OpenConnection()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Dummy_Test_DBEntities"].ConnectionString;
            cnn.Open();
            
            return 1;
        }

    }
}