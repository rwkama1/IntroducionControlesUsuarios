<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="ListaDeEnteros.ascx" TagName="ListaDeEnteros" TagPrefix="uc3" %>

<%@ Register Src="BuscadorPorTipo.ascx" TagName="BuscadorPorTipo" TagPrefix="uc2" %>

<%@ Register Src="ListaDeDatos.ascx" TagName="ListaDeDatos" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Lista de Ciudades<br />
        &nbsp;<uc1:ListaDeDatos ID="cntLstCiudades" runat="server" />
        <br />
        <br />
        Listado de Idiomas
        <br />
        <uc1:ListaDeDatos ID="cntLstIdiomas" runat="server" />
        <br />
        <br />
        Lista de Telefonos<br />
        <uc3:ListaDeEnteros ID="ListaDeEnteros1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Lista de ciudades escritas &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:ListBox ID="ListBox1" runat="server"></asp:ListBox><br />
        <br />
        _______________________________________________________________________<br />
        <br />
        <br />
        <uc2:BuscadorPorTipo ID="BuscadorPorTipo1" runat="server" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Buscar" />
        <asp:Label ID="Label1" runat="server"></asp:Label><br />
        <br />
    </div>
    </form>
</body>
</html>
