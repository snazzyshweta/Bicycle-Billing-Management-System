<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            font-size: medium;
        }
        .style1
    {
        text-align: center;
        background-color: #C0C0C0;
    }
    .style2
    {
        font-size: xx-large;
        color: #000000;
        text-decoration: underline;
    }
    .style3
    {
        color: #FF0000;
    }
    .style7
    {
        text-decoration: underline;
    }
    .style6
    {
        color: #333333;
    }
        .style8
        {
            text-align: center;
            background-color: #CCCCCC;
        }
    </style>
</head>
<body style="font-family: 'Segoe UI'; background-color: #999999;">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <h1 style="text-align: center">
        Know about your Zodiac Sign </h1>
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <div class="style8">
                Enter your Name:<br />
                <asp:TextBox ID="TextBox1" runat="server" BackColor="Orange"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" BackColor="Blue" CommandName="NextView" 
                    ForeColor="White" Text="Next" />
            </div>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <div class="style8">
                Enter your Birthday Day:<br />
                <asp:TextBox ID="TextBox2" runat="server" BackColor="Orange" 
                    style="margin-left: 15px" Width="183px"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter your Month in Number:<br />
                <asp:TextBox ID="TextBox3" runat="server" BackColor="Orange" 
                    style="margin-left: 7px" Width="178px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" BackColor="Green" 
                    CommandName="NextView" ForeColor="White" onclick="Unnamed1_Click" 
                    Text="FInd  your Zodiac" />
                <br />
            </div>
        </asp:View>
        <asp:View ID="View3" runat="server" onactivate="View4_Activate">
            <div class="style1">
                <strong><span><span class="style2">***Welcome to Zodiac Finder***<br /> </span>
                </span><span class="style3">
                <br class="style7" />
                </span></strong>
                <br />
                <span class="style6">Hello
                <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
                &nbsp;!!<br /> </span>
                <br class="style6" style="background-color: #000000" />
                <span class="style6">Your Zodiac Sign is
                <asp:Label ID="Label2" runat="server" Text="Label" style="font-weight: 700"></asp:Label>
                </span>.<span class="style6"><br />
                <br />
                <asp:Image ID="Image1" runat="server" Height="266px" Width="362px" />
                <br />
                <br />
                <strong>Some details about your personality based on your Zodaic Sign:<br />
                </strong> </span>
                <br class="style6" />
                Birth Day<strong>:
                <asp:Label ID="Label3" runat="server" CssClass="style6" Text="Label"></asp:Label>
                <br />
                </strong>Birth Month<strong>:
                <asp:Label ID="Label4" runat="server" CssClass="style6" Text="Label"></asp:Label>
                <br />
                </strong>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Label" style="font-weight: 700"></asp:Label>
                <br />
                <br />
            </div>
        </asp:View>

        


       
    </asp:MultiView>
    </form>
</body>
</html>
