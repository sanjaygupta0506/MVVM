using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptApp.Main_Concept
{
    class Using_Statement
    {
        //static void Main(string[] args)
        //{
        //    // - ***************** Example -1 -  Without using statement *************//
        //    SqlHelper sqlHelper = new SqlHelper();
        //    //use sqlHelper
        //    //after use call Dispose() method to release resources
        //    sqlHelper.Dispose();

        //    // - ***************** Example -2 -  Syntax using statement *************//
        //    using (SqlHelper sqlHelper1 = new SqlHelper())
        //    {
        //        // use sqlHelper object

        //    } //automatically calls Dispose method

        //    // - ***************** Example -3 -  How using internal work *************//
        //    // 
        //    SqlHelper sqlHelper2 = new SqlHelper();
        //    try
        //    {
        //        // use sqlHelper object
        //    }
        //    finally
        //    {
        //        if (sqlHelper2 != null)
        //        {
        //            ((IDisposable)sqlHelper2).Dispose();
        //        }
        //    }

        //    // - ***************** Example -4 -  Implement using statement *************//
        //    string connString = "Data Source=SANJAY;Initial Catalog=Test;User ID=sa;Password=sanjay@1";

        //    using (SqlConnection sqlConnection = new SqlConnection(connString))
        //    {
        //        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
        //        {
        //            sqlCommand.CommandText = "SELECT * FROM Customers";
        //            sqlConnection.Open();

        //            using (SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
        //            {
        //                while (dataReader.Read())
        //                {
        //                    Console.WriteLine("CustomerId | Name | Country \n {0}  |   {1}  |   {2}", dataReader.GetInt32(0),

        //                dataReader.GetString(1), dataReader.GetString(2));
        //                    Console.ReadLine();
        //                }
        //            }
        //        }
        //    }
        //}
    }
    public class SqlHelper : IDisposable
    {
        public void Dispose()
        {
            //release sql resources
        }
    }
}
