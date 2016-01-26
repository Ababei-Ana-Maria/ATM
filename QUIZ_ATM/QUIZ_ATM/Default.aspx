<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QUIZ_ATM._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Quiz ATM</title>
</head>
<body style="height:auto;background-color:bisque;">
    <div style="height: 99px; margin-top: 0px; text-align:center; text-decoration-style:double; text-decoration-color:blueviolet;font-size:large;font-family:'Comic Sans MS';text-emphasis-color:azure;">
            QUIZZ ADMITERE ATM

                            </div>
    <form id="form1" runat="server">
        <div style="height: 33px; margin-top: 46px">
            
            Utilizator
            <asp:TextBox ID="TextBox2" 
                runat="server" 
                style="margin-left: 204px"
                ></asp:TextBox>
        </div>
        <div style="height: 35px">
            Nume_Guest
            <asp:TextBox ID="TextBox3" 
                runat="server" 
                style="margin-left: 180px"
                ></asp:TextBox>
        </div>
        <div style="height: 31px">
<<<<<<< HEAD
            Parola<asp:TextBox ID="TextBox4" runat="server" style="margin-left: 221px" TextMode="Password"></asp:TextBox>
=======
            Parola
            <asp:TextBox ID="TextBox4" 
                runat="server" 
                style="margin-left: 221px"
                ></asp:TextBox>
>>>>>>> origin/master
        </div>
        <div style="height: 121px">
            <%-- Definirea functiei de redirectare --%>
            <script type = "text/javascript">
                function SetTarget() {
                    document.forms[0].target = "_self";
                }
</script>
            <%-- de verificat daca cel care intra este admin si il vom trimite in pagina 6(my_Admin) iar daca nu este admin il vom trimite in pagina 3(my_Profile)--%>
            <asp:Button ID="login" runat="server" style="margin-left: 211px" Text="Log in" Width="94px" OnClick="login_Click" OnClientClick="SetTarget()"/>
            <asp:Button ID="guestmode" runat="server" style="margin-left: 0px" Text="Guest Mode" OnClick="guestmode_Click" OnClientClick="SetTarget()"/>
            <asp:Button ID="crearecont" runat="server" Text="Creeaza Cont !" OnClick="crearecont_Click" OnClientClick="SetTarget()" />
        </div>
    </form>
</body>
</html>
