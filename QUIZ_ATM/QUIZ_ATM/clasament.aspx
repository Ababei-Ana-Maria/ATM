<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clasament.aspx.cs" Inherits="QUIZ_ATM.clasament" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"
    runat="server">
    <title>Quiz ATM</title>
</head>

   <body style="height:auto;background-color:bisque;">
     <form id="form1" 
         runat="server">
    <div style="height: 99px; margin-top: 0px; text-align:center; text-decoration-style:double; text-decoration-color:blueviolet;font-size:large;font-family:'Comic Sans MS';text-emphasis-color:azure;">
            QUIZ ADMITERE ATM

                            </div>

  <div style="height: 50px; width: auto"; 
       align="right">
    
      <asp:Button ID="LogOut" 
          runat="server" 
          OnClick="LogOut_Click" 
          Text="Log Out" 
          OnClientClick="SetTarget();"/>
        </div>
      <script type = "text/javascript">
          function SetTarget() {
              document.forms[0].target = "_self";
          }

</script>
        <div style="height: 151px; margin-top: 46px; width: 339px;">

            <asp:GridView ID="GridView1" 
                runat="server">
            </asp:GridView>


    <div style="height: 50px; margin-top: 46px">

        <asp:Button ID="home" 
            runat="server" 
            OnClick="home_Click" 
            Text="Home" 
            OnClientClick="SetTargets();" />


    </div>
    </form>
</body>
</html>
