using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using calls.Models;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace calls.usermonthdl
{
    public class usrmonthdl
    {
        SqlConnection connection = new SqlConnection();

        public List<usermonth> Getcallsbyusermonth(int id,int month)
        {


            SqlDataReader reader = null;

            connection.ConnectionString = (System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            SqlCommand sqlCmd = new SqlCommand();
            List<usermonth> lstcal = new List<Models.usermonth>();


            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select a.userid,a.username,b.callid,b.month,b.duration,c.calltype,c.category,c.specialist from [project].[dbo].[user] a join [project].[dbo].[category] c on a.userid=c.userid join [project].[dbo].[duration] b on b.callid=c.callid  join [project].[dbo].[month] d on d.month =b.month where a.userid =" + id + " AND d.monthid = "+ month + " ";

            connection.Open();

            reader = sqlCmd.ExecuteReader();
            usermonth c = null;

            while (reader.Read())
            {
                c = new usermonth();
                c.userid = Convert.ToInt32(reader.GetValue(0));
                c.username = reader.GetValue(1).ToString();
                c.callid = Convert.ToInt32(reader.GetValue(2));
                c.month = reader.GetValue(3).ToString();
                c.duration = reader.GetValue(4).ToString();
                c.calltype = reader.GetValue(5).ToString();
                c.category = reader.GetValue(6).ToString();
                c.specialist = reader.GetValue(7).ToString();

                lstcal.Add(c);
            }

            connection.Close();
            return lstcal;


        }
    }
}