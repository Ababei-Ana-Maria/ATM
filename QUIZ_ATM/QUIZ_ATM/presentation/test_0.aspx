<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test_0.aspx.cs" Inherits="QUIZ_ATM.test_0" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quiz ATM</title>
</head>
<body style="height:auto;background-color:bisque;">
    <form id="form1" 
        runat="server">
    <div style="height: 99px; margin-top: 0px; text-align:center; text-decoration-style:double; text-decoration-color:blueviolet;font-size:large;font-family:'Comic Sans MS';text-emphasis-color:azure;">
            QUIZZ ADMITERE ATM

    </div>
 <%-- Definirea functiei de redirectare --%>
            <script type = "text/javascript">
                function SetTarget() {
                    document.forms[0].target = "_self";
                }
</script>
    <div style="height: auto; width: auto"; 
        align="right">
        <asp:Button ID="logoutButton" 
            runat="server" 
            BorderStyle="Ridge" 
            Height="25px" 
            OnClick="logoutButton_Click"  
            OnClientClick="SetTarget()" 
            Text="Log Out"/>
    </div>

        <div style="height: 391px">
&nbsp;<br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="start_test" 
                runat="server" 
                style="margin-left: 29px" 
                Text="Start test!" 
                OnClick="start_test_Click"  
                OnClientClick="SetTarget()"/>
        </div>

    </form>
</body>
</html>
