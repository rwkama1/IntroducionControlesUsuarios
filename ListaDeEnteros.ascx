<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListaDeEnteros.ascx.cs" Inherits="ListaDeEnteros" %>
<table>
    <tr>
        <td style="height: 50px">
            <asp:TextBox ID="txtDato" runat="server"></asp:TextBox></td>
        <td style="height: 50px">
            <asp:Button ID="Button1" runat="server" OnClick="btnQuitar_Click" Text="<-- Quitar   " /><br />
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar -->" /></td>
        <td style="height: 50px">
            <asp:ListBox ID="lstListaDatos" runat="server" OnSelectedIndexChanged="lstListaDatos_SelectedIndexChanged"></asp:ListBox></td>
    </tr>
</table>
