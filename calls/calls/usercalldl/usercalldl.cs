using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using calls.Models;
using System.Data.SqlClient;
using System.Data;



namespace calls.usercalldl
{
    public class usercalldl
    {
        public List<usercalls> Getcalls()
        {


            SqlDataReader reader = null;
            SqlConnection myconnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString);
            SqlCommand sqlCmd = new SqlCommand();
            List<usercalls> lstcall = new List<Models.usercalls>();


            sqlCmd.Connection = myconnection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select ";

            myconnection.Open();

            reader = sqlCmd.ExecuteReader();
            usercalls c = null;

            while (reader.Read())
            {
                c = new usercalls();
                c.userid = Convert.ToInt32(reader.GetValue(0));
                c.username = reader.GetValue(1).ToString();
                c.callid = Convert.ToInt32(reader.GetValue(2));
                c.month = reader.GetValue(3).ToString();
                c.duration = reader.GetValue(4).ToString();
                c.calltype= reader.GetValue(5).ToString();
                c.category= reader.GetValue(6).ToString();
                c.specialist= reader.GetValue(7).ToString();

                lstcall.Add(c);
            }

            myconnection.Close();
            return lstcall;


        }
    }
}