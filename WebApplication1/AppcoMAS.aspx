<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AppcoMAS.aspx.cs" Inherits="WebApplication1.AppcoMAS" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    

    <style type="text/css">

        .style1
        {
            width: 100%;
        }
        .style4
        {
            width: 162px;
        }
        .style3
        {
            width: 627px;
        }
        .style14
        {
            width: 293px;
            height: 23px;
        }
        .style15
        {
            width: 162px;
            height: 23px;
        }
        .style16
        {
            width: 627px;
            height: 23px;
        }
        .style17
        {
            height: 23px;
        }
        .style11
        {
            width: 293px;
        }
        .style18
        {
            width: 162px;
            height: 12px;
        }
        .style19
        {
            width: 627px;
            height: 12px;
        }
        .style20
        {
            height: 12px;
        }
        .style21
        {
            width: 162px;
            height: 9px;
        }
        .style22
        {
            width: 627px;
            height: 9px;
        }
        .style23
        {
            height: 9px;
        }
        .style52
        {
        }
        .style54
        {
            width: 162px;
            height: 26px;
        }
        .style55
        {
            width: 627px;
            height: 26px;
        }
        .style56
        {
            height: 26px;
        }
        .style60
        {
            width: 195px;
        }
        .style63
        {
            width: 194px;
            height: 23px;
        }
        .style64
        {
            height: 23px;
            width: 287px;
        }
        .style65
        {
            width: 98px;
        }
        .style66
        {
            width: 129px;
        }
        .style68
        {
            width: 195px;
            height: 192px;
        }
        .style69
        {
            height: 192px;
        }
        .style70
        {
            width: 197px;
        }
        .style71
        {
            width: 167px;
        }
        .style72
        {
            width: 334px;
        }
        #File1 {
            width: 277px;
        }
        #Text2 {
            width: 579px;
        }
        .auto-style13 {
            width: 1039px;
        }
        .auto-style15 {
            width: 98%;
        }
        .auto-style16 {
            width: 1492px;
        }
        .auto-style18 {
            width: 194px;
        }
       
        .auto-style26 {
            height: 2px;
        }
        .auto-style28 {
            height: 1px;
        }
        .auto-style35 {
            height: 22px;
        }
        .auto-style37 {
            width: 156px;
        }
        .auto-style38 {
            height: 206px;
        }
        .auto-style39 {
            width: 320px;
            height: 26px;
        }
        .auto-style40 {
            width: 320px;
            height: 12px;
        }
        .auto-style41 {
            width: 320px;
        }
        .auto-style42 {
            width: 314px;
        }
        .auto-style47 {
            width: 323px;
        }
        .auto-style49 {
            width: 314px;
            height: 13px;
        }
        .auto-style52 {
            height: 13px;
        }
        .auto-style58 {
            width: 254px;
            height: 13px;
        }
        .auto-style60 {
            width: 254px;
            height: 30px;
        }
        .auto-style61 {
            width: 314px;
            height: 30px;
        }
        .auto-style63 {
            height: 30px;
        }
        .auto-style64 {
            height: 62px;
        }
        .auto-style69 {
            width: 412px;
            height: 30px;
        }
        .auto-style70 {
            width: 412px;
            height: 13px;
        }
        .auto-style71 {
            width: 412px;
        }
        .auto-style75 {
            width: 314px;
            height: 33px;
        }
        .auto-style76 {
            width: 412px;
            height: 33px;
        }
        .auto-style77 {
            height: 33px;
        }
        .auto-style84 {
            width: 144px;
        }
        .auto-style85 {
            width: 283px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" enableviewstate="True"     
    submitdisabledcontrols="False">
     <div style="margin-left:12%">             
         <br />
      <img alt="" src="./Photos/Others/Untitled.png" />
        <br />
        <br />
    </div>
    <div style="background-color: #FF0066;" class="auto-style35">

    </div>
    <div style="color: #333333; font-family: Calibri;" class="auto-style38">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <table class="style1">
                    <tr>
                        <td class="auto-style28" bgcolor="#FF0066" colspan="4">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="ICFirstName4" runat="server" Font-Names="Calibri" ForeColor="White" Text="Search for IC:"></asp:Label>
                            </td>
                    </tr>
                    <tr>
                        <td class="auto-style47">&nbsp;</td>
                        <td class="auto-style37">
                            <asp:Label ID="ICFirstName0" runat="server" Font-Names="Calibri" ForeColor="#333333" Text="IC Number:"></asp:Label>
                        </td>
                        <td class="auto-style85">
                            <asp:TextBox ID="txtSearch" runat="server" BackColor="Control" Height="22px" Width="237px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" Text="Search" Width="145px" Font-Names="Calibri" Font-Size="Medium" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button8" runat="server" Font-Names="Calibri" Font-Size="Medium" OnClick="Button8_Click" Text="Add/Remove MC/Campaign" Width="226px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnReport" runat="server" Text="Unprocessed ICs" Font-Names="Calibri" Font-Size="Medium" OnClick="btnReport_Click" />
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
        
        <div>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <div class="auto-style64" style="font-size:x-large">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Please wait ...
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
        
        <br />
        <br />
    
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>
        <asp:Panel ID="Panel3" runat="server" Visible="False">
            <table class="style1">
                <tr>
                    <td bgcolor="#FF0066" class="auto-style28" colspan="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="ICFirstName3" runat="server" Font-Names="Calibri" ForeColor="White" Text="IC Details:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td class="style54">
                        <asp:Label ID="ICFirstName1" runat="server" Font-Names="Calibri" ForeColor="#333333" Text="Marketing Company:"></asp:Label>
                    </td>
                    <td class="style56" colspan="2">
                        <asp:Label ID="lblMC" runat="server" Font-Names="Calibri" ForeColor="#333333" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td class="style54">
                        <asp:Label ID="Label24" runat="server" Font-Names="Calibri" ForeColor="#333333" Text="Request Status:"></asp:Label>
                    </td>
                    <td class="style56" colspan="2">
                        <asp:Label ID="lblStatus" runat="server" Font-Names="Calibri" ForeColor="#333333" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td class="style54">
                        <asp:Label ID="Label25" runat="server" Font-Names="Calibri" ForeColor="#333333" Text="Request Date:"></asp:Label>
                    </td>
                    <td class="style56" colspan="2">
                        <asp:Label ID="lblDate" runat="server" Font-Names="Calibri" ForeColor="#333333" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style39">
                    </td>
                    <td class="style54">
                        <asp:Label ID="ICFirstName" runat="server" Text="IC First Name:" ForeColor="#333333" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td class="style56" colspan="2">
                        <asp:TextBox ID="txtFirstName" runat="server" Height="22px" Width="240px" BackColor="Control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style39">
                    </td>
                    <td class="style54">
                        <asp:Label ID="ICLastName" runat="server" Text="IC Last Name:" ForeColor="#333333" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td class="style56" colspan="2">
                        <asp:TextBox ID="txtLastName" runat="server" Width="240px" Height="22px" BackColor="Control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style39">
                        </td>
                    <td class="style54">
                        <asp:Label ID="DateOfBirth" runat="server" Text="Date of Birth:" ForeColor="#333333" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td class="style56" colspan="2">
                        <asp:TextBox ID="txtDOB" runat="server" Height="22px" Width="240px" BackColor="Control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style17" colspan="4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td bgcolor="#FF0066" class="auto-style26" colspan="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="ICFirstName5" runat="server" Font-Names="Calibri" ForeColor="White" Text="Country and Visa:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style40">
                    </td>
                    <td class="style18">
                        <asp:Label ID="Country" runat="server" Text="Country:" ForeColor="#333333" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td class="style20" colspan="2">
                        <asp:Label ID="lblCountry" runat="server" Text="Label" ForeColor="#333333" Font-Names="Calibri"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style41">
                    </td>
                    <td class="style4">
                        <asp:Label ID="VisaDetails" runat="server" Text="Visa Details:" ForeColor="#333333" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:Panel ID="Panel1" runat="server">
                            <table class="style1">
                                <tr>
                                    <td>
                                        <asp:GridView ID="GridViewVisa" runat="server" Font-Names="Calibri" ForeColor="#333333" onrowcommand="GridViewVisa_RowCommand" onrowdeleting="GridViewVisa_RowDeleting">
                                            <Columns>
                                                <asp:TemplateField ShowHeader="False">
                                                    <ItemTemplate>
                                                        <asp:Button ID="Button7" runat="server" CausesValidation="False" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CommandName="Delete" Text="Delete" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="style4">
                        <asp:Label ID="Label27" runat="server" Font-Names="Calibri" ForeColor="#333333" Text="Comments:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtCmnt" runat="server" BackColor="Control" Height="22px" Width="240px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4" style="background-color: #FF0066">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="ICFirstName9" runat="server" Font-Names="Calibri" ForeColor="White" Text="IDs:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style41">
                        </td>
                    <td class="style4">
                        <asp:Label ID="AddID" runat="server" Text="List of IDs:" ForeColor="#333333" Font-Names="Calibri"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:GridView ID="GridViewID" runat="server" Font-Names="Calibri" ForeColor="#333333" onrowcommand="GridViewID_RowCommand" onrowdeleting="GridViewID_RowDeleting">
                            <Columns>
                                <asp:TemplateField ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:Button ID="Button6" runat="server" CausesValidation="False" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CommandName="Delete" Text="Delete" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td>
                        </td>
                </tr>
                <tr>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td bgcolor="#FF0066" class="auto-style26" colspan="4">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="ICFirstName7" runat="server" Font-Names="Calibri" ForeColor="White" Text="IC Photo:"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style41">
                        &nbsp;</td>
                    <td class="style4">
                        <asp:Label ID="Label1" runat="server" Font-Names="Calibri" ForeColor="#333333" Text="Photo:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <table class="style1">
                            <tr>
                                <td class="style52" colspan="2">
                                    <asp:Image ID="Image1" runat="server" Height="181px" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style18">
                                    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Rotate Clockwise" />
                                </td>
                                <td>
                                    <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Rotate Counterclockwise" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>&nbsp;</td>
                </tr>

                 <tr>
                    <td colspan="4" bgcolor="#FF0066" class="auto-style26">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="ICFirstName8" runat="server" Font-Names="Calibri" ForeColor="White" Text="Campaign:"></asp:Label>
                     </td>
                </tr>

                  <tr>
                    <td class="auto-style41">
                        &nbsp;</td>
                    <td class="style4">
                        <asp:Label ID="Label23" runat="server" Text="List of Campaigns:" ForeColor="#333333" Font-Names="Calibri"></asp:Label>
                      </td>
                    <td class="auto-style13">
                        <table class="style1">
                            <tr>
                                <td class="style17" colspan="2">
                                    <asp:GridView ID="GridViewCampaign" runat="server" ForeColor="#333333" onrowcommand="GridViewCampaign_RowCommand" onrowdeleting="GridViewCampaign_RowDeleting" Font-Names="Calibri">
                                        <Columns>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CommandName="Delete" Text="Delete" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td class="style52">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                      </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
        <div class="auto-style64">
            <asp:UpdateProgress ID="UpdateProgress2" runat="server">
                <ProgressTemplate>
                    <div class="auto-style64" style="font-size:x-large; font-family: Calibri; color: #333333;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Please wait ...
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
    <br />
    <div class="auto-style16">
      
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
        <ContentTemplate>

              <asp:Panel ID="Panel2" runat="server" Visible="False">

        <table class="auto-style15">
            <tr>
                <td class="auto-style61">
                    </td>
                <td class="auto-style69" colspan="2">
       <asp:Button ID="Import" runat="server"  Text="Import" Width="148px"  onclick="Import_Click" Font-Names="Calibri" Font-Size="Medium" />
                </td>
                <td class="auto-style60">
                    <asp:Label ID="lblSendMessage" runat="server" Text="Label" Font-Names="Calibri"></asp:Label>
                </td>
                <td class="auto-style63">
                    <asp:Label ID="lblPDF" runat="server" Text="Label" Font-Names="Calibri"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style49"></td>
                <td class="auto-style70" colspan="2"></td>
                <td class="auto-style58"></td>
                <td class="auto-style52"></td>
            </tr>
            <tr>
                <td class="auto-style42">&nbsp;</td>
                <td class="auto-style84" style="font-family: Calibri; font-size: medium">
                    <asp:Button ID="btnReject" runat="server" Text="Reject" Width="148px" onclientclick="return meReject()" OnClick="btnReject_Click"  Font-Names="Calibri" Font-Size="Medium" />
                    </td>
                <td class="style71" style="font-family: Calibri; font-size: medium">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reason:</td>
                <td colspan="2">
                    <asp:TextBox ID="txtReason" runat="server" Width="603px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style42">&nbsp;</td>
                <td class="auto-style71" colspan="2" style="font-family: Calibri; font-size: medium">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style75"></td>
                <td class="auto-style76" colspan="2" style="font-family: Calibri; font-size: medium">
                    <asp:Button ID="Button11" runat="server" Font-Names="Calibri" Font-Size="Medium" OnClick="Button11_Click" Text="Import Only" Width="148px" />
                </td>
                <td class="auto-style77" colspan="2">
                    <asp:Label ID="lblSendMsgOnly" runat="server" Font-Names="Calibri" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style42">&nbsp;</td>
                <td class="auto-style71" colspan="2" style="font-family: Calibri; font-size: medium">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style42">&nbsp;</td>
                <td class="auto-style84" style="font-family: Calibri; font-size: medium">
                    <asp:Button ID="btnExportOnly" runat="server" Font-Names="Calibri" Font-Size="Medium" OnClick="btnExportOnly_Click" Text="Export Only" Width="148px" />
                </td>
                <td class="style71" style="font-family: Calibri; font-size: medium">
                    <asp:Label ID="Label26" runat="server" Text="Badge No:"></asp:Label>
                    &nbsp;<asp:TextBox ID="txtBadgeNo" runat="server" Width="81px"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Label ID="lblPDFonly" runat="server" Font-Names="Calibri" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>

                    </asp:Panel>

      </ContentTemplate>
      </asp:UpdatePanel>
          
     </div>
    <br />
    <br />
     &nbsp;<input type="hidden" id="Text1"  name="txtAddress"  /><br />
    
    <br />
    </form>
   <script type="text/javascript" language="javascript">
       
      
       function meReject() {
         
           try {
               if (document.getElementById('txtReason').value == "") {
                   alert('Please specify the Reason!');
                   return false;
               }
              
           }
           catch (err) {
               alert('Operational error during this process. Repeat the process again!');
               return false;
           }
       }
      
   </script>
</body>
</html>
