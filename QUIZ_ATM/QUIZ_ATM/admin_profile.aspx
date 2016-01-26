<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_profile.aspx.cs" Inherits="QUIZ_ATM.admin_profile" %>

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

  <div style="height: 50px; width: auto"; 
       align="right">
 
      <asp:Button ID="LogOut" 
          runat="server" 
          Text="Log Out"
           OnClick="LogOut_Click"  
          OnClientClick="SetTarget();"/>
    </div>
      <script type = "text/javascript">
          function SetTarget() {
              document.forms[0].target = "_self";
          }

</script>
         </div>
         <asp:Label ID="label_nume" 
             runat="server" 
             Text="Nume si Prenume"></asp:Label>


   <div style="height: 50px; margin-top: 46px">


       <asp:Button ID="adminadd" 
           runat="server" 
           OnClick="adminadd_Click" 
           Text="Adaugare Admin" />

   <div style="height: 50px; margin-top: 46px">


       <asp:Button ID="questionadd" 
           runat="server" 
           OnClick="questionadd_Click" 
           Text="Adaugare Intrebare"
            OnClientClick="SetTarget()"/>
  
       
    <div style="height: 50px; margin-top: 46px">


        <asp:Button ID="modifyquestion" 
            runat="server" 
            OnClick="modifyquestion_Click" 
            Text="Modificare/Stergere Intrebare" />



    </form>
</body>
</html>
