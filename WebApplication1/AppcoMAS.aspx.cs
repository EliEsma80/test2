using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Data.OleDb;
using BadgeNumber;
using Pdfmaker;
using System.Drawing;

namespace WebApplication1
{
    public partial class AppcoMAS : System.Web.UI.Page
    {
       
        ICdata IC = new ICdata();
        private DataTable ICDt = new DataTable();
        private DataTable VisaDt = new DataTable();
        private DataTable IdDt = new DataTable();
        private DataTable CampaignDt = new DataTable();
        private DataTable RejectDt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (ViewState["IcDt"] != null)
            {
                ICDt = (DataTable)ViewState["IcDt"];
            }

            if (ViewState["VisaDt"] != null)
            {
                VisaDt = (DataTable)ViewState["VisaDt"];
            }
                       
            if (ViewState["IdDt"] != null)
            {
                IdDt = (DataTable)ViewState["IdDt"];
            }
                                               
            if (ViewState["CampaignDt"] != null)
            {
                CampaignDt = (DataTable)ViewState["CampaignDt"];
            }
         
            if (!this.IsPostBack)
            {
                Panel3.Visible = false;
                Panel2.Visible = false;
              
            }
                        

        }
       
               
        protected void GridViewVisa_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //delete the record
            VisaDt.Rows.RemoveAt((int)ViewState["index1"]);
            ViewState["VisaDt1"] = VisaDt;

            GridViewVisa.DataSource = (DataTable)ViewState["VisaDt1"];
            GridViewVisa.DataBind();
        }

        protected void GridViewVisa_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                ViewState["index1"] = Convert.ToInt32(e.CommandArgument);
            }
        }

        protected void GridViewID_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //delete the record
            IdDt.Rows.RemoveAt((int)ViewState["index2"]);
            ViewState["IdDt1"] = IdDt;

            GridViewID.DataSource = (DataTable)ViewState["IdDt1"];
            GridViewID.DataBind();
        }

        protected void GridViewID_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                ViewState["index2"] = Convert.ToInt32(e.CommandArgument);
                              
            }
        }
                     
        protected void GridViewCampaign_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                ViewState["index5"] = Convert.ToInt32(e.CommandArgument);
            }
        }

        protected void GridViewCampaign_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            CampaignDt.Rows.RemoveAt((int)ViewState["index5"]);
            ViewState["CampaignDt1"] = CampaignDt;

            GridViewCampaign.DataSource = (DataTable)ViewState["CampaignDt1"];
            GridViewCampaign.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            Panel3.Visible = true;
            Panel2.Visible = true;

            ICDt = IC.SelectIC(int.Parse(txtSearch.Text));
            ViewState["IcDt"] = ICDt;


            System.Net.WebClient webClient = new System.Net.WebClient();
            webClient.Credentials = new System.Net.NetworkCredential("sujit", "A$$c0Websites");
            webClient.DownloadFile(new Uri("ftp://ocean.studiocoast.com.au//sujit/appcoonline.com/home/badge/generalinformation/generalinfo2/" + txtSearch.Text + ".JPG"), Server.MapPath(".") + "\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG");



            lblMC.Text = ICDt.Rows[0]["MC"].ToString();
            lblStatus.Text = ICDt.Rows[0]["Status"].ToString();
            lblDate.Text = ICDt.Rows[0]["UpdateDate"].ToString();
            txtFirstName.Text = ICDt.Rows[0]["FirstName"].ToString();
            txtLastName.Text = ICDt.Rows[0]["LastName"].ToString();
            txtDOB.Text = ICDt.Rows[0]["DOB"].ToString().Substring(0, 10);
            lblCountry.Text = ICDt.Rows[0]["Country"].ToString();
            txtReason.Text = ICDt.Rows[0]["RejectReason"].ToString();

            VisaDt = IC.SelectVisa(int.Parse(txtSearch.Text));
            ViewState["VisaDt"] = VisaDt;
            GridViewVisa.DataSource = VisaDt;
            GridViewVisa.DataBind();
          
            IdDt = IC.SelectID(int.Parse(txtSearch.Text));
            ViewState["IdDt"] = IdDt;
            GridViewID.DataSource = IdDt;
            GridViewID.DataBind();
                    
            CampaignDt = IC.SelectCampaign(int.Parse(txtSearch.Text));
            ViewState["CampaignDt"] = CampaignDt;
            GridViewCampaign.DataSource = CampaignDt;
            GridViewCampaign.DataBind();

            lblSendMessage.Text = "Ready for import";
            lblPDF.Text = "";
                                  
            lblSendMsgOnly.Text = "Ready for import only";
            lblPDFonly.Text = "";

            Image1.ImageUrl = "~\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG";
        }

        protected void Import_Click(object sender, EventArgs e)
        {

            try
            {
                string BadgeNo = "";
                string pdfMakerResult = "";

               
                File.Copy(Server.MapPath(".") + "\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG", @"\\cobradata01\common\General\ICphotos\" + txtFirstName.Text + txtLastName.Text + txtSearch.Text + ".JPG", true);


                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data source=\\cobradata01\Appco_dbases\MarketingOfficeDatabase\CobraMasterDatabase\data.mdb";
                conn.Open();


                string FirstName = txtFirstName.Text.Replace("'", "''");
                string LastName = txtLastName.Text.Replace("'", "''");

            
                string DOB = txtDOB.Text.Substring(3, 2) + "/" + txtDOB.Text.Substring(0, 2) + "/" + txtDOB.Text.Substring(6, 4);
                BadgeNo BadgeNum = new BadgeNo();


                if (ViewState["duplicate"] == null)
                {

                    OleDbCommand ExistIcCmd = new OleDbCommand("select count(RecID) from IC_Details where FirstName = '" + FirstName + "' and LastName = '" + LastName + "' and DOB =#" + DOB + "#", conn);

                    int ExistIc = (int)ExistIcCmd.ExecuteScalar();

                    if (ExistIc > 0)
                    {
                        ViewState["duplicate"] = 1;
                        lblSendMessage.Text = "There is an IC with the same details in our database! Do you want to import anyway?";            
                        conn.Close();
                    }
                    else
                    {
                        OleDbCommand IcRecIdCmd = new OleDbCommand("select max(RecID) from IC_Details", conn);
                        int MaxIcRecId = (int)IcRecIdCmd.ExecuteScalar() + 1;

                        if (BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString().Substring(0, 3) == "err")
                        {
                            conn.Close();
                            lblSendMessage.Text = BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString();
                            return;
                        }
                        else
                        { BadgeNo = BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString(); }

                                               
                        OleDbCommand InsertIcCmd = new OleDbCommand("INSERT INTO IC_Details (RecID,FirstName,LastName,DOB,Photo,CountryID,PassIDReq) VALUES(" + MaxIcRecId + ",'" + FirstName + "','" + LastName + "',#" + Convert.ToDateTime(txtDOB.Text).ToString("MM/dd/yyyy") + "#,'" + "F:\\General\\ICphotos\\" + FirstName + LastName + txtSearch.Text + ".JPG" + "'," + ICDt.Rows[0]["CountryID"] + ", true)", conn);
                        InsertIcCmd.ExecuteNonQuery();
                        OleDbCommand VisaCmd = null;
                        string txtExpiryDate = null;
                        for (int i = 0; i < VisaDt.Rows.Count; i++)
                        {

                            try
                            {
                                txtExpiryDate = "#" + Convert.ToDateTime(VisaDt.Rows[i][6]).ToString("MM/dd/yyyy") + "#";
                                VisaCmd = new OleDbCommand("INSERT INTO IC_Visas (IC_RecID,NameOnVisa,VisaClassID, VisaID,IssuedDate,ExpiryDate,FlagDate,ActiveVisa) VALUES(" + MaxIcRecId + ",'" + FirstName + " " + LastName + "'," + VisaDt.Rows[i][0].ToString() + "," + VisaDt.Rows[i][2].ToString() + ",#" + Convert.ToDateTime(VisaDt.Rows[i][4]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][5]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][6]).ToString("MM/dd/yyyy") + "# , true)", conn);
                            }
                            catch
                            {
                                VisaCmd = new OleDbCommand("INSERT INTO IC_Visas (IC_RecID,NameOnVisa,VisaClassID, VisaID,IssuedDate,ExpiryDate,FlagDate,ActiveVisa) VALUES(" + MaxIcRecId + ",'" + FirstName + " " + LastName + "'," + VisaDt.Rows[i][0].ToString() + "," + VisaDt.Rows[i][2].ToString() + ",#" + Convert.ToDateTime(VisaDt.Rows[i][4]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][5]).ToString("MM/dd/yyyy") + "#, null , true)", conn);
                            }

                            VisaCmd.ExecuteNonQuery();
                        }

                        for (int i = 0; i < IdDt.Rows.Count; i++)
                        {
                            OleDbCommand IDCmd = new OleDbCommand("INSERT INTO IC_IDs (IC_ID,IDType_ID,IDDetails) VALUES(" + MaxIcRecId + "," + IdDt.Rows[i][0].ToString() + ",'" + IdDt.Rows[i][2].ToString().Replace("'", "''") + "')", conn);
                            IDCmd.ExecuteNonQuery();
                        }

                        for (int i = 0; i < CampaignDt.Rows.Count; i++)
                        {

                            OleDbCommand BadgeRecIdCmd = new OleDbCommand("select max(RecID) from IC_Badges", conn);
                            int MaxBadgeRecId = (int)BadgeRecIdCmd.ExecuteScalar() + 1;
                            OleDbCommand BadgeCmd = new OleDbCommand("INSERT INTO IC_Badges (RecID, BadgeNumber, IC_Details_Recid, MCID, CobraCampaigns_RecID, BadgeActive, TempDate, TempExpiryDate, ICTest_Score, ICTest_TrainersName) VALUES(" + MaxBadgeRecId + ",'" + BadgeNo + "'," + MaxIcRecId + "," + ICDt.Rows[0]["MCID"] + "," + CampaignDt.Rows[i]["CampaignRecID"] + ", true ,#" + DateTime.Now.ToString("M/d/yyyy") + "#, #" + DateTime.Now.AddMonths(1).ToString("M/d/yyyy") + "#, 0, '')", conn);
                            BadgeCmd.ExecuteNonQuery();
                            OleDbCommand SpanCmd = new OleDbCommand("INSERT INTO IC_BadgeActiveTimeSpan (IC_Badges_RecID, ActiveStartDate) VALUES(" + MaxBadgeRecId + ",#" + DateTime.Now.ToString("M/d/yyyy") + "#)", conn);
                            SpanCmd.ExecuteNonQuery();
                        }
                        conn.Close();
                        lblSendMessage.Text = "Imported Successfully!";


                        for (int i = 0; i < CampaignDt.Rows.Count; i++)
                        {
                            DateTime today = DateTime.Today;
                            PdfMaker pdfer = new PdfMaker();

                            pdfMakerResult = pdfer.PdfMaker(txtSearch.Text, BadgeNo, txtFirstName.Text, txtLastName.Text, lblMC.Text, CampaignDt.Rows[i][1].ToString(), ICDt.Rows[0]["ABN"].ToString(), ICDt.Rows[0]["Address"].ToString(), today, today.AddMonths(1), Server.MapPath(".") + "\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG", @"C:\WordFiles\" + CampaignDt.Rows[i][1].ToString());
                            if (pdfMakerResult != "True")
                            {
                                lblPDF.Text = pdfMakerResult;
                                return;
                            }
                            else
                            {
                                WebClient webClient = new WebClient();
                                webClient.Credentials = new System.Net.NetworkCredential("sujit", "A$$c0Websites");
                                webClient.UploadFile(new Uri("ftp://ocean.studiocoast.com.au//sujit/appcoonline.com/home/badge/generalinformation/generalinfo1/" + txtSearch.Text + " " + CampaignDt.Rows[i][1].ToString() + ".pdf"), @"C:\PDFFiles\" + txtSearch.Text + " " + CampaignDt.Rows[i][1].ToString() + ".pdf");
                            }

                        }
                        lblPDF.Text = "Exported Successfully!";


                        IC.UpdateIc(int.Parse(txtSearch.Text), 2, null);


                        ViewState["duplicate"] = null;
                        
                    }
                }
               
                else 
                {
                    OleDbCommand IcRecIdCmd = new OleDbCommand("select max(RecID) from IC_Details", conn);
                    int MaxIcRecId = (int)IcRecIdCmd.ExecuteScalar() + 1;

                    if (BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString().Substring(0, 3) == "err")
                    {
                        conn.Close();
                        lblSendMessage.Text = BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString();
                        return;
                    }
                    else
                    { BadgeNo = BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString(); }

                    
                    OleDbCommand InsertIcCmd = new OleDbCommand("INSERT INTO IC_Details (RecID,FirstName,LastName,DOB,Photo,CountryID,PassIDReq) VALUES(" + MaxIcRecId + ",'" + FirstName + "','" + LastName + "',#" + Convert.ToDateTime(txtDOB.Text).ToString("MM/dd/yyyy") + "#,'" + "F:\\General\\ICphotos\\" + FirstName + LastName + txtSearch.Text + ".JPG" + "'," + ICDt.Rows[0]["CountryID"] + ", true)", conn);
                    InsertIcCmd.ExecuteNonQuery();
                    OleDbCommand VisaCmd = null;
                    string txtExpiryDate = null;
                    for (int i = 0; i < VisaDt.Rows.Count; i++)
                    {

                        try
                        {
                            txtExpiryDate = "#" + Convert.ToDateTime(VisaDt.Rows[i][6]).ToString("MM/dd/yyyy") + "#";
                            VisaCmd = new OleDbCommand("INSERT INTO IC_Visas (IC_RecID,NameOnVisa,VisaClassID, VisaID,IssuedDate,ExpiryDate,FlagDate,ActiveVisa) VALUES(" + MaxIcRecId + ",'" + FirstName + " " + LastName + "'," + VisaDt.Rows[i][0].ToString() + "," + VisaDt.Rows[i][2].ToString() + ",#" + Convert.ToDateTime(VisaDt.Rows[i][4]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][5]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][6]).ToString("MM/dd/yyyy") + "# , true)", conn);
                        }
                        catch
                        {
                            VisaCmd = new OleDbCommand("INSERT INTO IC_Visas (IC_RecID,NameOnVisa,VisaClassID, VisaID,IssuedDate,ExpiryDate,FlagDate,ActiveVisa) VALUES(" + MaxIcRecId + ",'" + FirstName + " " + LastName + "'," + VisaDt.Rows[i][0].ToString() + "," + VisaDt.Rows[i][2].ToString() + ",#" + Convert.ToDateTime(VisaDt.Rows[i][4]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][5]).ToString("MM/dd/yyyy") + "#, null , true)", conn);
                        }

                        VisaCmd.ExecuteNonQuery();
                    }

                    for (int i = 0; i < IdDt.Rows.Count; i++)
                    {
                        OleDbCommand IDCmd = new OleDbCommand("INSERT INTO IC_IDs (IC_ID,IDType_ID,IDDetails) VALUES(" + MaxIcRecId + "," + IdDt.Rows[i][0].ToString() + ",'" + IdDt.Rows[i][2].ToString().Replace("'", "''") + "')", conn);
                        IDCmd.ExecuteNonQuery();
                    }

                    for (int i = 0; i < CampaignDt.Rows.Count; i++)
                    {

                        OleDbCommand BadgeRecIdCmd = new OleDbCommand("select max(RecID) from IC_Badges", conn);
                        int MaxBadgeRecId = (int)BadgeRecIdCmd.ExecuteScalar() + 1;
                        OleDbCommand BadgeCmd = new OleDbCommand("INSERT INTO IC_Badges (RecID, BadgeNumber, IC_Details_Recid, MCID, CobraCampaigns_RecID, BadgeActive, TempDate, TempExpiryDate, ICTest_Score, ICTest_TrainersName) VALUES(" + MaxBadgeRecId + ",'" + BadgeNo + "'," + MaxIcRecId + "," + ICDt.Rows[0]["MCID"] + "," + CampaignDt.Rows[i]["CampaignRecID"] + ", true ,#" + DateTime.Now.ToString("M/d/yyyy") + "#, #" + DateTime.Now.AddMonths(1).ToString("M/d/yyyy") + "#, 0, '')", conn);
                        BadgeCmd.ExecuteNonQuery();
                        OleDbCommand SpanCmd = new OleDbCommand("INSERT INTO IC_BadgeActiveTimeSpan (IC_Badges_RecID, ActiveStartDate) VALUES(" + MaxBadgeRecId + ",#" + DateTime.Now.ToString("M/d/yyyy") + "#)", conn);
                        SpanCmd.ExecuteNonQuery();
                    }
                   
                    conn.Close();
                    lblSendMessage.Text = "Imported Successfully!";



                    for (int i = 0; i < CampaignDt.Rows.Count; i++)
                    {
                        DateTime today = DateTime.Today;
                        PdfMaker pdfer = new PdfMaker();

                        pdfMakerResult = pdfer.PdfMaker(txtSearch.Text, BadgeNo, txtFirstName.Text, txtLastName.Text, lblMC.Text, CampaignDt.Rows[i][1].ToString(), ICDt.Rows[0]["ABN"].ToString(), ICDt.Rows[0]["Address"].ToString(), today, today.AddMonths(1), Server.MapPath(".") + "\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG", @"C:\WordFiles\" + CampaignDt.Rows[i][1].ToString());
                        if (pdfMakerResult != "True")
                        {
                            lblPDF.Text = pdfMakerResult;
                            return;
                        }
                        else
                        {
                            WebClient webClient = new WebClient();
                            webClient.Credentials = new System.Net.NetworkCredential("sujit", "A$$c0Websites");
                            webClient.UploadFile(new Uri("ftp://ocean.studiocoast.com.au//sujit/appcoonline.com/home/badge/generalinformation/generalinfo1/" + txtSearch.Text + " " + CampaignDt.Rows[i][1].ToString() + ".pdf"), @"C:\PDFFiles\" + txtSearch.Text + " " + CampaignDt.Rows[i][1].ToString() + ".pdf");
                        }

                    }
                    lblPDF.Text = "Exported Successfully!";

                    IC.UpdateIc(int.Parse(txtSearch.Text), 2, null);

                    ViewState["duplicate"] = null;
                 
                }


        }
            catch (Exception E)
            {
                Session["ErrorMsg"] = E.Message.ToString();
                Response.Redirect("ErrorPage.aspx");
            }

}

        protected void btnReject_Click(object sender, EventArgs e)
        {
            try {

                if (txtReason.Text.Length <= 3)
                {
                    lblSendMessage.Text = "The Reason is not right!";
                }
                else
                {

                    IC.UpdateIc(int.Parse(txtSearch.Text), 1, txtReason.Text);


                    RejectDt = IC.RejectEmail(int.Parse(txtSearch.Text));
                    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                    mail.To.Add(RejectDt.Rows[0]["email"].ToString());
                   // mail.Bcc.Add("aesmailzadeh@appcogroup.com.au");
                    mail.From = new MailAddress("rejectedbadges@appcogroup.com.au");
                    mail.Subject = "The badge no " + txtSearch.Text + " is rejected";
                    mail.Body = "The reason is: " + txtReason.Text;
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new System.Net.NetworkCredential("rejectedbadges@appcogroup.com.au", "1");
                    client.Port = 25;
                    client.Host = "appcogroup-com-au.mail.protection.outlook.com";
                    client.Send(mail);


                    lblSendMessage.Text = "IC rejected";
                    lblPDF.Text = "";
                    lblSendMsgOnly.Text = "";
                    lblPDFonly.Text = "";
                }
            }
            catch (Exception E)
            {
                Session["ErrorMsg"] = E.Message.ToString();
                Response.Redirect("ErrorPage.aspx");
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page1.html");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int card = rnd.Next(1,999);
            Image1.ImageUrl = "~\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG";
            string path = Server.MapPath(Image1.ImageUrl);

            System.Drawing.Image i = System.Drawing.Image.FromFile(path);
            
            i.RotateFlip(RotateFlipType.Rotate90FlipNone);

            i.Save(path);

            i.Dispose();

            Image1.Attributes.Add("ImageUrl", path);
            Image1.ImageUrl = "~\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG?" + card;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int card = rnd.Next(1, 999);
            Image1.ImageUrl = "~\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG";
            string path = Server.MapPath(Image1.ImageUrl);
                       
            System.Drawing.Image i = System.Drawing.Image.FromFile(path);
                       
            i.RotateFlip(RotateFlipType.Rotate270FlipNone);

            i.Save(path);

            i.Dispose();

            Image1.Attributes.Add("ImageUrl", path);
            Image1.ImageUrl = "~\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG?" + card;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {

            try
            {
                string BadgeNo = "";
               
                            
                File.Copy(Server.MapPath(".") + "\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG", @"\\cobradata01\common\General\ICphotos\" + txtFirstName.Text + txtLastName.Text + txtSearch.Text + ".JPG", true);


                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data source=\\cobradata01\Appco_dbases\MarketingOfficeDatabase\CobraMasterDatabase\data.mdb";
                conn.Open();


                string FirstName = txtFirstName.Text.Replace("'", "''");
                string LastName = txtLastName.Text.Replace("'", "''");


                string DOB = txtDOB.Text.Substring(3, 2) + "/" + txtDOB.Text.Substring(0, 2) + "/" + txtDOB.Text.Substring(6, 4);
                BadgeNo BadgeNum = new BadgeNo();


                if (ViewState["duplicate"] == null)
                {

                    OleDbCommand ExistIcCmd = new OleDbCommand("select count(RecID) from IC_Details where FirstName = '" + FirstName + "' and LastName = '" + LastName + "' and DOB =#" + DOB + "#", conn);

                    int ExistIc = (int)ExistIcCmd.ExecuteScalar();

                    if (ExistIc > 0)
                    {
                        ViewState["duplicate"] = 1;
                        lblSendMsgOnly.Text = "There is an IC with the same details in our database! Do you want to import anyway?";
                        conn.Close();
                    }
                    else
                    {
                        OleDbCommand IcRecIdCmd = new OleDbCommand("select max(RecID) from IC_Details", conn);
                        int MaxIcRecId = (int)IcRecIdCmd.ExecuteScalar() + 1;

                        if (BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString().Substring(0, 3) == "err")
                        {
                            conn.Close();
                            lblSendMsgOnly.Text = BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString();
                            return;
                        }
                        else
                        { BadgeNo = BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString(); }

                                               
                        OleDbCommand InsertIcCmd = new OleDbCommand("INSERT INTO IC_Details (RecID,FirstName,LastName,DOB,Photo,CountryID,PassIDReq) VALUES(" + MaxIcRecId + ",'" + FirstName + "','" + LastName + "',#" + Convert.ToDateTime(txtDOB.Text).ToString("MM/dd/yyyy") + "#,'" + "F:\\General\\ICphotos\\" + FirstName + LastName + txtSearch.Text + ".JPG" + "'," + ICDt.Rows[0]["CountryID"] + ", true)", conn);
                        InsertIcCmd.ExecuteNonQuery();
                        OleDbCommand VisaCmd = null;
                        string txtExpiryDate = null;
                        for (int i = 0; i < VisaDt.Rows.Count; i++)
                        {

                            try
                            {
                                txtExpiryDate = "#" + Convert.ToDateTime(VisaDt.Rows[i][6]).ToString("MM/dd/yyyy") + "#";
                                VisaCmd = new OleDbCommand("INSERT INTO IC_Visas (IC_RecID,NameOnVisa,VisaClassID, VisaID,IssuedDate,ExpiryDate,FlagDate,ActiveVisa) VALUES(" + MaxIcRecId + ",'" + FirstName + " " + LastName + "'," + VisaDt.Rows[i][0].ToString() + "," + VisaDt.Rows[i][2].ToString() + ",#" + Convert.ToDateTime(VisaDt.Rows[i][4]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][5]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][6]).ToString("MM/dd/yyyy") + "# , true)", conn);
                            }
                            catch
                            {
                                VisaCmd = new OleDbCommand("INSERT INTO IC_Visas (IC_RecID,NameOnVisa,VisaClassID, VisaID,IssuedDate,ExpiryDate,FlagDate,ActiveVisa) VALUES(" + MaxIcRecId + ",'" + FirstName + " " + LastName + "'," + VisaDt.Rows[i][0].ToString() + "," + VisaDt.Rows[i][2].ToString() + ",#" + Convert.ToDateTime(VisaDt.Rows[i][4]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][5]).ToString("MM/dd/yyyy") + "#, null , true)", conn);
                            }

                            VisaCmd.ExecuteNonQuery();
                        }

                        for (int i = 0; i < IdDt.Rows.Count; i++)
                        {
                            OleDbCommand IDCmd = new OleDbCommand("INSERT INTO IC_IDs (IC_ID,IDType_ID,IDDetails) VALUES(" + MaxIcRecId + "," + IdDt.Rows[i][0].ToString() + ",'" + IdDt.Rows[i][2].ToString().Replace("'", "''") + "')", conn);
                            IDCmd.ExecuteNonQuery();
                        }

                        for (int i = 0; i < CampaignDt.Rows.Count; i++)
                        {

                            OleDbCommand BadgeRecIdCmd = new OleDbCommand("select max(RecID) from IC_Badges", conn);
                            int MaxBadgeRecId = (int)BadgeRecIdCmd.ExecuteScalar() + 1;
                            OleDbCommand BadgeCmd = new OleDbCommand("INSERT INTO IC_Badges (RecID, BadgeNumber, IC_Details_Recid, MCID, CobraCampaigns_RecID, BadgeActive, TempDate, TempExpiryDate, ICTest_Score, ICTest_TrainersName) VALUES(" + MaxBadgeRecId + ",'" + BadgeNo + "'," + MaxIcRecId + "," + ICDt.Rows[0]["MCID"] + "," + CampaignDt.Rows[i]["CampaignRecID"] + ", true ,#" + DateTime.Now.ToString("M/d/yyyy") + "#, #" + DateTime.Now.AddMonths(1).ToString("M/d/yyyy") + "#, 0, '')", conn);
                            BadgeCmd.ExecuteNonQuery();
                            OleDbCommand SpanCmd = new OleDbCommand("INSERT INTO IC_BadgeActiveTimeSpan (IC_Badges_RecID, ActiveStartDate) VALUES(" + MaxBadgeRecId + ",#" + DateTime.Now.ToString("M/d/yyyy") + "#)", conn);
                            SpanCmd.ExecuteNonQuery();
                        }
                        conn.Close();
                        lblSendMsgOnly.Text = "Imported Successfully!";

                        

                        ViewState["duplicate"] = null;

                    }
                }

                else
                {
                    OleDbCommand IcRecIdCmd = new OleDbCommand("select max(RecID) from IC_Details", conn);
                    int MaxIcRecId = (int)IcRecIdCmd.ExecuteScalar() + 1;

                    if (BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString().Substring(0, 3) == "err")
                    {
                        conn.Close();
                        lblSendMsgOnly.Text = BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString();
                        return;
                    }
                    else
                    { BadgeNo = BadgeNum.Number(MaxIcRecId, (int)CampaignDt.Rows[0][0], (int)ICDt.Rows[0]["MCID"]).ToString(); }

                    
                    OleDbCommand InsertIcCmd = new OleDbCommand("INSERT INTO IC_Details (RecID,FirstName,LastName,DOB,Photo,CountryID,PassIDReq) VALUES(" + MaxIcRecId + ",'" + FirstName + "','" + LastName + "',#" + Convert.ToDateTime(txtDOB.Text).ToString("MM/dd/yyyy") + "#,'" + "F:\\General\\ICphotos\\" + FirstName + LastName + txtSearch.Text + ".JPG" + "'," + ICDt.Rows[0]["CountryID"] + ", true)", conn);
                    InsertIcCmd.ExecuteNonQuery();
                    OleDbCommand VisaCmd = null;
                    string txtExpiryDate = null;
                    for (int i = 0; i < VisaDt.Rows.Count; i++)
                    {

                        try
                        {
                            txtExpiryDate = "#" + Convert.ToDateTime(VisaDt.Rows[i][6]).ToString("MM/dd/yyyy") + "#";
                            VisaCmd = new OleDbCommand("INSERT INTO IC_Visas (IC_RecID,NameOnVisa,VisaClassID, VisaID,IssuedDate,ExpiryDate,FlagDate,ActiveVisa) VALUES(" + MaxIcRecId + ",'" + FirstName + " " + LastName + "'," + VisaDt.Rows[i][0].ToString() + "," + VisaDt.Rows[i][2].ToString() + ",#" + Convert.ToDateTime(VisaDt.Rows[i][4]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][5]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][6]).ToString("MM/dd/yyyy") + "# , true)", conn);
                        }
                        catch
                        {
                            VisaCmd = new OleDbCommand("INSERT INTO IC_Visas (IC_RecID,NameOnVisa,VisaClassID, VisaID,IssuedDate,ExpiryDate,FlagDate,ActiveVisa) VALUES(" + MaxIcRecId + ",'" + FirstName + " " + LastName + "'," + VisaDt.Rows[i][0].ToString() + "," + VisaDt.Rows[i][2].ToString() + ",#" + Convert.ToDateTime(VisaDt.Rows[i][4]).ToString("MM/dd/yyyy") + "#,#" + Convert.ToDateTime(VisaDt.Rows[i][5]).ToString("MM/dd/yyyy") + "#, null , true)", conn);
                        }

                        VisaCmd.ExecuteNonQuery();
                    }

                    for (int i = 0; i < IdDt.Rows.Count; i++)
                    {
                        OleDbCommand IDCmd = new OleDbCommand("INSERT INTO IC_IDs (IC_ID,IDType_ID,IDDetails) VALUES(" + MaxIcRecId + "," + IdDt.Rows[i][0].ToString() + ",'" + IdDt.Rows[i][2].ToString().Replace("'", "''") + "')", conn);
                        IDCmd.ExecuteNonQuery();
                    }

                    for (int i = 0; i < CampaignDt.Rows.Count; i++)
                    {

                        OleDbCommand BadgeRecIdCmd = new OleDbCommand("select max(RecID) from IC_Badges", conn);
                        int MaxBadgeRecId = (int)BadgeRecIdCmd.ExecuteScalar() + 1;
                        OleDbCommand BadgeCmd = new OleDbCommand("INSERT INTO IC_Badges (RecID, BadgeNumber, IC_Details_Recid, MCID, CobraCampaigns_RecID, BadgeActive, TempDate, TempExpiryDate, ICTest_Score, ICTest_TrainersName) VALUES(" + MaxBadgeRecId + ",'" + BadgeNo + "'," + MaxIcRecId + "," + ICDt.Rows[0]["MCID"] + "," + CampaignDt.Rows[i]["CampaignRecID"] + ", true ,#" + DateTime.Now.ToString("M/d/yyyy") + "#, #" + DateTime.Now.AddMonths(1).ToString("M/d/yyyy") + "#, 0, '')", conn);
                        BadgeCmd.ExecuteNonQuery();
                        OleDbCommand SpanCmd = new OleDbCommand("INSERT INTO IC_BadgeActiveTimeSpan (IC_Badges_RecID, ActiveStartDate) VALUES(" + MaxBadgeRecId + ",#" + DateTime.Now.ToString("M/d/yyyy") + "#)", conn);
                        SpanCmd.ExecuteNonQuery();
                    }

                    conn.Close();
                    lblSendMsgOnly.Text = "Imported Successfully!";

                                      

                    ViewState["duplicate"] = null;

                }
                
            }
            catch (Exception E)
            {
                Session["ErrorMsg"] = E.Message.ToString();
                Response.Redirect("ErrorPage.aspx");
            }
        }

        protected void btnExportOnly_Click(object sender, EventArgs e)
        {
            try { 
            string pdfMakerResult = "";

                if (txtBadgeNo.Text.Length <= 5)
                { lblPDFonly.Text = "The Badge No is not right!"; }
                else
                {
                    for (int i = 0; i < CampaignDt.Rows.Count; i++)
                    {
                        DateTime today = DateTime.Today;
                        PdfMaker pdfer = new PdfMaker();

                        pdfMakerResult = pdfer.PdfMaker(txtSearch.Text, txtBadgeNo.Text, txtFirstName.Text, txtLastName.Text, lblMC.Text, CampaignDt.Rows[i][1].ToString(), ICDt.Rows[0]["ABN"].ToString(), ICDt.Rows[0]["Address"].ToString(), today, today.AddMonths(1), Server.MapPath(".") + "\\Images\\" + ICDt.Rows[0]["FirstName"].ToString() + ICDt.Rows[0]["LastName"].ToString() + txtSearch.Text + ".JPG", @"C:\WordFiles\" + CampaignDt.Rows[i][1].ToString());
                        if (pdfMakerResult != "True")
                        {
                            lblPDFonly.Text = pdfMakerResult;
                            return;
                        }
                        else
                        {
                            WebClient webClient = new WebClient();
                            webClient.Credentials = new System.Net.NetworkCredential("sujit", "A$$c0Websites");
                            webClient.UploadFile(new Uri("ftp://ocean.studiocoast.com.au//sujit/appcoonline.com/home/badge/generalinformation/generalinfo1/" + txtSearch.Text + " " + CampaignDt.Rows[i][1].ToString() + ".pdf"), @"C:\PDFFiles\" + txtSearch.Text + " " + CampaignDt.Rows[i][1].ToString() + ".pdf");
                        }
                    }
                    lblPDFonly.Text = "Exported Successfully!";

                    IC.UpdateIc(int.Parse(txtSearch.Text), 2, null);
                }
            }
            catch (Exception E)
            {
                Session["ErrorMsg"] = E.Message.ToString();
                Response.Redirect("ErrorPage.aspx");
            }
       }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Comments.html");
        }

       
     }
}