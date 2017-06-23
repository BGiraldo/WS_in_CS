<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumoWS.aspx.cs" Inherits="ws2.ConsumoWS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/Jquery.js"></script>
    <script src="Scripts/WebService.js"></script>
    <style type="text/css">
        #form1 {
            height: 291px;
        }
    </style>
</head>
<body style="height: 254px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Hello World" OnClick="helloWord" Width="92px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lb1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Fecha" OnClick="obtenerFecha" Width="96px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lb2" runat="server"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Saludo" OnClick="saludar" Width="105px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lb3" runat="server"></asp:Label>
        <br />
        <br />
        <input type ="text" value="Bijju" id="txtNombre" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input type ="button" value="llamar" onClick="callService();" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblRespuesta" runat="server"></asp:Label>

    </form>
</body>
</html>
