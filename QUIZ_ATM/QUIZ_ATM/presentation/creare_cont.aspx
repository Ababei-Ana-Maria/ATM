<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="creare_cont.aspx.cs" Inherits="QUIZ_ATM.creare_cont" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Quiz ATM</title>
</head>
<body style="height:auto;background-color:bisque;">
    <form id="form1" runat="server">
    <div style="height: 99px;text-align:center; text-decoration-style:double; text-decoration-color:blueviolet;font-size:large;font-family:'Comic Sans MS';text-emphasis-color:azure;">
    
            QUIZZ ADMITERE ATM
                            </div>
    <div style="height: 40px">
        Nume&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" 
            runat="server" 
            Height="22px" 
            style="margin-left: 335px; margin-top: 4px;" 
            Width="200px">
            </asp:TextBox>
    </div>
    <div style="height: 40px">
        Prenume&nbsp;&nbsp; <asp:TextBox ID="TextBox2" 
            runat="server" 
            Height="22px" 
            style="margin-left: 317px; margin-top: 4px;" 
            Width="200px">
               </asp:TextBox>
    </div>
    <div style="height: 40px">
        Email&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" 
            runat="server" 
            Height="22px" 
            style="margin-left: 335px; margin-top: 4px;" 
            Width="200px">
             </asp:TextBox>
    </div>
    <div style="height: 40px">
        Parola&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" 
            runat="server" 
            Height="22px" 
            style="margin-left: 331px; margin-top: 4px" 
            Width="200px"
            TextMode="Password">
              </asp:TextBox>
        </div>
    <div style="height: 40px">
        Confirma parola
        <asp:TextBox ID="TextBox5" 
            runat="server" 
            Height="22px" 
            style="margin-left: 269px; margin-top: 4px;" 
            Width="200px"
            TextMode="Password">
        </asp:TextBox>
    &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text=" - "></asp:Label>
    </div>
        <div style="height: 39px">
            <asp:Button ID="creare" 
                runat="server" 
                OnClick="creare_Click" 
                style="margin-left: 434px;margin-top: 4px" 
                Text="Creare" 
                OnClientClick="SetTarget()" />
            <script type = "text/javascript">
                function SetTarget() {
                    document.forms[0].target = "_self";
                }
</script>
        </div>
    </form>
    </body>
</html>