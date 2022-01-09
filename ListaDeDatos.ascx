<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListaDeDatos.ascx.cs" Inherits="ListaDeDatos" %>
&nbsp;<table>
    <tr>
        <td style="height: 50px">
<asp:TextBox ID="txtDato" runat="server"></asp:TextBox></td>
        <td style="height: 50px">
            <asp:Button ID="Button1" runat="server" OnClick="btnQuitar_Click" Text="<-- Quitar   " /><br />
<asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar -->" /></td>
        <td style="height: 50px">
<asp:ListBox ID="lstListaDatos" runat="server"></asp:ListBox></td>
    </tr>
</table>
&nbsp;&nbsp;
