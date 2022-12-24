using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class BaseDeDatos
    { 
        public static void Agregar()
        {
            String cnnStr = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            
        }
    }
}