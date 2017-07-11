using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace WebApplication1
{
    public class ICdata
    {
        public DataTable SelectIC(int RecID)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpSelectIC", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RecID", RecID);
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }

        public DataTable SelectVisa(int ICRecID)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpSelectVisa", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ICRecID", ICRecID);
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }

        public DataTable SelectID(int ICRecID)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpSelectID", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ICRecID", ICRecID);
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }

        public DataTable SelectCampaign(int ICRecID)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpSelectCampaign", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ICRecID", ICRecID);
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }


        public DataTable CmbSelectAllCountry()
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpCmbSelectAllCountry", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }


        public DataTable CmbSelectAllMcs()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();

            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpCmbSelectAllMcs", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;


        }

        public DataTable CmbSelectAllVisaClasses()
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpCmbSelectAllVisaClasses", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }

        public DataTable CmbSelectAllVisaSubclasses()
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpCmbSelectAllVisaSubclasses", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }

        public DataTable CmbSelectAllIDTypes()
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpCmbSelectAllIDTypes", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }

        public DataTable CmbSelectAllOtherDocs()
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpCmbSelectAllOtherDoc", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }
        public DataTable Authen(string UserName, string KeyNo)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpAuthen", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@KeyNo", KeyNo);
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }

        public DataTable AppcoEmail(int MCID)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpAppcoEmail", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MCID", MCID);
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }

        public DataTable CmbSelectSomeCampaign(string UserName, string KeyNo)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpCmbSelectSomeCampaign", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@KeyNo", KeyNo);
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }

       

        public void InsertICVisa(int ICRecID, int VisaClassID, int VisaID, DateTime VisaIssueDate, DateTime VisaExpiryDate, DateTime? VisaFlagDate)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpInsertICVisa", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ICRecID", ICRecID);
            cmd.Parameters.AddWithValue("@VisaClassID", VisaClassID);
            cmd.Parameters.AddWithValue("@VisaID", VisaID);
            cmd.Parameters.AddWithValue("@VisaIssueDate", VisaIssueDate);
            cmd.Parameters.AddWithValue("@VisaExpiryDate", VisaExpiryDate);
            cmd.Parameters.AddWithValue("@VisaFlagDate", VisaFlagDate);
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public void InsertICID(int ICRecID, int IDRecID, string IdDetails)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpInsertICID", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ICRecID", ICRecID);
            cmd.Parameters.AddWithValue("@IDRecID", IDRecID);
            cmd.Parameters.AddWithValue("@IdDetails", IdDetails);
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public void InsertICCampaign(int ICRecID, int CampaignRecID)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpInsertICCampaign", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ICRecID", ICRecID);
            cmd.Parameters.AddWithValue("@CampaignRecID", CampaignRecID);
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public void UpdateIc(int RecID, int StatusRecId, string RejectReason)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpUpdateIc", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RecID", RecID);
            cmd.Parameters.AddWithValue("@StatusRecId", StatusRecId);
            cmd.Parameters.AddWithValue("@RejectReason", RejectReason);
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public DataTable RejectEmail(int RecID)
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SPRejectEmail", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RecID", RecID);
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }

        public DataTable NonProcessed()
        {
            SqlConnection sqlConnection1 = new SqlConnection("data source=sql2014a.studiocoast.com.au,32989;initial catalog=masterdbweb;User ID=masterdbweb;Password=tonightmuseumstation4");
            SqlCommand cmd = new SqlCommand("SpNonProcessed", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConnection1.Close();
            return dt;
        }
    }
}