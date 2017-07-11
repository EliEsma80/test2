using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using WebApplication1.Classes;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetAllMCs()
        {
            string conn = "data source = sql2014a.studiocoast.com.au,32989; initial catalog = masterdbweb; User ID = masterdbweb; Password=tonightmuseumstation4";

            List<MC> ListMCs = new List<MC>();
            SqlConnection sqlConnection1 = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("SpCmbSelectAllMcs", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                MC mc = new MC();
                mc.RecID = Convert.ToInt32(rdr["RecID"]);
                mc.MC1 = rdr["MC"].ToString();
                ListMCs.Add(mc);
            }
            sqlConnection1.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(ListMCs));
        }

        [WebMethod]
        public void GetAllCampaigns()
        {
            string conn = "data source = sql2014a.studiocoast.com.au,32989; initial catalog = masterdbweb; User ID = masterdbweb; Password=tonightmuseumstation4";

            List<Campaign> ListCampaigns = new List<Campaign>();
            SqlConnection sqlConnection1 = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("SpCmbSelectAllCampaigns", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Campaign campaign = new Campaign();
                campaign.RecID = Convert.ToInt32(rdr["RecID"]);
                campaign.CampaignName = rdr["CampaignName"].ToString();
                ListCampaigns.Add(campaign);
            }
            sqlConnection1.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(ListCampaigns));
        }

        [WebMethod]
        public void InsertMcCampaign(int MCID, string CampaignID)
        {
            string conn = "data source = sql2014a.studiocoast.com.au,32989; initial catalog = masterdbweb; User ID = masterdbweb; Password=tonightmuseumstation4";

            SqlConnection sqlConnection1 = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("SpInsertMcCampaign", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MCID", MCID);
            cmd.Parameters.AddWithValue("@CampaignID", CampaignID);

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        [WebMethod]
        public void SelectSomeCampaign(int MCID)
        {
            string conn = "data source = sql2014a.studiocoast.com.au,32989; initial catalog = masterdbweb; User ID = masterdbweb; Password=tonightmuseumstation4";

            List<Campaign> ListCampaigns = new List<Campaign>();
            SqlConnection sqlConnection1 = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("SpCmbSelectSomeCampaign", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MCID", MCID);
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Campaign campaign = new Campaign();
                campaign.RecID = Convert.ToInt32(rdr["RecID"]);
                campaign.CampaignName = rdr["CampaignName"].ToString();
                ListCampaigns.Add(campaign);
            }
            sqlConnection1.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(ListCampaigns));
        }

        [WebMethod]
        public void DeleteMCCampaign(int MCID, int CampaignID)
        {
            string conn = "data source = sql2014a.studiocoast.com.au,32989; initial catalog = masterdbweb; User ID = masterdbweb; Password=tonightmuseumstation4";

            SqlConnection sqlConnection1 = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("SpDeleteMCCampaign", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MCID", MCID);
            cmd.Parameters.AddWithValue("@CampaignID", CampaignID);
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        [WebMethod]
        public void SelectNonProcessed()
        {
            string conn = "data source = sql2014a.studiocoast.com.au,32989; initial catalog = masterdbweb; User ID = masterdbweb; Password=tonightmuseumstation4";

            List<NonProcessed> ListNonProcesseds = new List<NonProcessed>();
            SqlConnection sqlConnection1 = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("SpNonProcessed", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                NonProcessed nonProcessed = new NonProcessed();
                nonProcessed.RecID = Convert.ToInt32(rdr["RecID"]);
                nonProcessed.FirstName = rdr["FirstName"].ToString();
                nonProcessed.LastName = rdr["LastName"].ToString();
                nonProcessed.MC = rdr["MC"].ToString();
                nonProcessed.Status = rdr["Status"].ToString();
                nonProcessed.RequestDate = rdr["RequestDate"].ToString();
                nonProcessed.RejectReason = rdr["RejectReason"].ToString();
                ListNonProcesseds.Add(nonProcessed);
            }
            sqlConnection1.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(ListNonProcesseds));
        }
    }
    }
