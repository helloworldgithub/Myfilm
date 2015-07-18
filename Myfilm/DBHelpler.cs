using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Myfilm
{
    public static class dbHelper
    {
        public static SqlConnection conn;
        public static SqlConnection Conn
        {
            get
            {
                try
                {
                    string strConn = "Server=.;Database=moviemanage;Integrated security=true"；

                    //configurationManager不存在上下文终极解决方案：引用中添加system.configuratioin
                    if (conn == null)
                    {
                        conn = new SqlConnection(strConn);
                        conn.Open();
                    }
                    else if (conn.State == ConnectionState.Broken)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    else if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    return conn;
                }
                catch (SqlException)
                {
                    Console.WriteLine("Open Database failed!");
                    Environment.Exit(1);
                    return conn;
                }
            }
        }

        public static int ExecuteCommand(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Conn);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (SqlException)
            {
                Console.WriteLine("Failed to excecute command!");
                throw;
            }
        }

        public static object GetScalar(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Conn);
                object o = cmd.ExecuteScalar();
                return o;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to excecute command!");
                throw;
            }
        }
        public static SqlDataReader GetDataReader(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Conn);
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (SqlException)
            {
                Console.WriteLine("Failed to get data reader!");
                throw;
            }
        }
        public static DataSet GetDataSet(string sql)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(sql, Conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                return ds;
            }
            catch (SqlException)
            {
                Console.WriteLine("Failed to get data adapter!");
                throw;
            }
        }
    }
}