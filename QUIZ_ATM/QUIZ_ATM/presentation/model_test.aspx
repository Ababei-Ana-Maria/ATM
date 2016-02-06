<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="model_test.aspx.cs" Inherits="QUIZ_ATM.model_test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" 
    runat="server">
    <title>Quiz ATM</title>
    <style type="text/css">
        .auto-style1 {}
    </style>
</head>
<body style="height:auto;background-color:bisque;">
     <form id="form1" 
         runat="server">
    <div style="height: 99px; margin-top: 0px; text-align:center; text-decoration-style:double; text-decoration-color:blueviolet;font-size:large;font-family:'Comic Sans MS';text-emphasis-color:azure;">
            QUIZ ADMITERE ATM

                            </div>

   <div style="height: auto; width: auto"; 
       align="right">
        <asp:Button ID="logoutButton" 
            runat="server" 
            Text="Log Out" 
            BorderStyle="Ridge" 
            Height="25px" 
            OnClick="logoutButton_Click"  
            OnClientClick="SetTarget();" CssClass="auto-style1"  
            />
    </div>
         <script type = "text/javascript">
             function SetTarget() {
                 document.forms[0].target = "_self";
             }
</script>
    <div style="height: 60px; margin-top: 46px">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Punctaj:&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <br />

        <div style="height: 150px; margin-top: 46px">
    
            <asp:Label ID="questionnr" 
                runat="server" 
                Text="Nr intrebare."></asp:Label>
&nbsp;
            <asp:Label ID="question" 
                runat="server" 
                Text="Intrebarea propriu-zisa"
                ></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <asp:CheckBox ID="CheckBox1" 
                runat="server" />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="answer1" 
                runat="server" 
                Text="Raspuns 1"
                ></asp:Label>
            <br />
            <asp:CheckBox ID="CheckBox2" 
                runat="server" />
&nbsp;&nbsp;
            <asp:Label ID="answer2" 
                runat="server" 
                Text="Raspuns 2"></asp:Label>
            <br />
            <asp:CheckBox ID="CheckBox3" 
                runat="server" />
&nbsp;&nbsp;
            <asp:Label ID="answer3" 
                runat="server" 
                Text="Raspuns 3"></asp:Label>
            <br />
            <asp:CheckBox ID="CheckBox4" 
                runat="server" />
&nbsp;&nbsp;
            <asp:Label ID="answer4" 
                runat="server" 
                Text="Raspuns 4"></asp:Label>
            <br />
    
            <br />
    
        </div>    
    <div style="height: 60px; margin-top: 46px">
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Exit" 
            runat="server" 
            Text="Exit" 
            OnClick="Exit_Click"  
            OnClientClick="SetTarget();"  />


    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Next" 
            runat="server" 
            Text="Next" 
            OnClick="Next_Click"  
            OnClientClick="SetTarget();"
              />
        <br />


    
    </div>



    </div>
    </form>
</body>
</html>
