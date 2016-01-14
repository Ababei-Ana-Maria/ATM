<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QUIZ_ATM._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body style="height:auto;background-color:bisque;">
    <div style="height: 99px; margin-top: 0px; text-align:center; text-decoration-style:double; text-decoration-color:blueviolet;font-size:large;font-family:'Comic Sans MS';text-emphasis-color:azure;">
            QUIZZ ADMITERE ATM

                            </div>
    <form id="form1" runat="server">
        <div style="height: 33px; margin-top: 46px">
            
            Utilizator<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 204px"></asp:TextBox>
        </div>
        <div style="height: 35px">
            Nume_Guest<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 180px"></asp:TextBox>
        </div>
        <div style="height: 31px">
            Parola<asp:TextBox ID="TextBox4" runat="server" style="margin-left: 221px"></asp:TextBox>
        </div>
        <div style="height: 121px">
            <asp:Button ID="Button1" runat="server" style="margin-left: 211px" Text="Log in" Width="94px" OnClick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 0px" Text="Guest Mode" />
            <asp:Button ID="Button2" runat="server" Text="Creeaza Cont !"  OnClientClick="open('WebForm2.aspx','otherpage');" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
