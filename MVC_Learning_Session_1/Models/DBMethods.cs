using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MVC_Learning_Session_1.Models
{
    public class DBMethods
    {
        static string cnnString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        /*To get List of Items*/
        public static IEnumerable<Item> GetItemList()
        {
            using (IDbConnection db = new SqlConnection(cnnString))
            {
                if(db.State== ConnectionState.Closed)
                {
                    db.Open();
                }
                var result = db.Query<Item>("Select * From Item");
                return result;
            }
        }
        public static Item GetItem(int Id)
        {
            Item obj=null;
            using (IDbConnection db = new SqlConnection(cnnString))
            {
                if(db.State==ConnectionState.Closed)
                {
                    db.Open();
                    obj = db.Query<Item>("Select * From Item Where Id=@Id", new Item { ID = Id }).FirstOrDefault();
                }
            }
            return obj;
        }
        /*To add new Item*/
        public static int InsertItem(Item obj)
        {
            int affected = 0;
            string sqlQuery = "Insert Into Item Values(@Id,@Name,@Category,@Rate);";
            using (IDbConnection db = new SqlConnection(cnnString))
            {
                if(db.State ==ConnectionState.Closed)
                {
                    db.Open();
                    affected =db.Execute(sqlQuery, obj);
                }
            }
            return affected;
        }
        /*To edit existing Item*/
        public static int EditItem(Item obj)
        {
            int affected = 0;
            string sqlQuery = "Update Item set Name=@Name, Category=@Category,Rate=@Rate Where Id=@Id ";
            using (IDbConnection db = new SqlConnection(cnnString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    affected = db.Execute(sqlQuery, obj);
                }
            }
            return affected;
        }
        /*To delete Item*/
        public static int DeleteItem(int Id)
        {
            int affected = 0;
            string sqlQuery = "Delete from Item Where Id=@Id";
            using (IDbConnection db = new SqlConnection(cnnString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    affected = db.Execute(sqlQuery, new Item { ID=Id});
                }
            }
            return affected;
        }
    }
}