<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewState2.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">    
<div>
   <TABLE>
      <tr>
         <td>Имя:</td>
         <td><asp:TextBox runat="server" Width="200px" ID="Name" /></td>
      </tr>
      <tr>
         <td>ID:</td>
         <td><asp:TextBox runat="server" Width="200px" ID="EmpID" /></td>
      </tr>
      <tr>
         <td>Возраст:</td>
         <td><asp:TextBox runat="server" Width="200px" ID="Age" /></td>
      </tr>
      <tr>
         <td>E-mail:</td>
         <td><asp:TextBox runat="server" Width="200px" ID="Email" /></td>
      </tr>
      <tr>
         <td>Пароль:</td>
         <td><asp:TextBox TextMode="Password" runat="server" Width="200px" ID="Password" /></td>
      </tr>
   </TABLE>
   <br />
    <asp:Button runat="server" Text="Save" ID="cmdSave" OnClick="cmdSave_Click" />
    <asp:Button ID="cmdRestore" runat="server" Text="Restore" OnClick="cmdRestore_Click"></asp:Button><br />
    <asp:Label ID="lblResults" runat="server" Text="Label"></asp:Label>
</div></form>
</body>
</html>
