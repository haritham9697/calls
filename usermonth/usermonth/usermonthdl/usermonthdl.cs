using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using usermonth.Models;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;



namespace usermonth.usermonthdl
{
    public class usrmonthdl
    {
        SqlConnection connection = new SqlConnection();

        public List<usermonthlly> Getcallsbyusermonth(int i, int idd)
        {


            SqlDataReader reader = null;

            connection.ConnectionString = (System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            SqlCommand sqlCmd = new SqlCommand();
            List<usermonthlly> lstusr = new List<Models.usermonthlly>();


            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select a.userid,a.username,b.callid,d.monthid,b.month,b.duration,c.calltype,c.category,c.specialist from [project].[dbo].[user] a join [project].[dbo].[category] c on a.userid=c.userid join [project].[dbo].[duration] b on b.callid=c.callid join [project].[dbo].[month] d on d.month =b.month where a.userid =" + i + " AND d.monthid = " + idd +  "";

            connection.Open();

            reader = sqlCmd.ExecuteReader();
            usermonthlly c = null;

            while (reader.Read())
            {
                c = new usermonthlly();
                c.userid = Convert.ToInt32(reader.GetValue(0));
                c.username = reader.GetValue(1).ToString();
                c.callid = Convert.ToInt32(reader.GetValue(2));
                c.monthid = Convert.ToInt32(reader.GetValue(3));
                c.month = reader.GetValue(4).ToString();
                c.duration = reader.GetValue(5).ToString();
                c.calltype = reader.GetValue(6).ToString();
                c.category = reader.GetValue(7).ToString();
                c.specialist = reader.GetValue(8).ToString();

                lstusr.Add(c);
            }

            connection.Close();
            return lstusr;


        }
    }
}