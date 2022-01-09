using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Collections.Generic;

public partial class ListaDeEnteros : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public List<int> Lista
    {
        get
        {
            List<int> oLista = new List<int>();
            int oNumero;
            foreach (object oAux in lstListaDatos.Items)
            {
                oLista.Add(Convert.ToInt32( oAux.ToString()));
            }
            return oLista;
        }
    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        int oNumero=0;

        try
        {
            oNumero = Convert.ToInt32(txtDato.Text);
            lstListaDatos.Items.Add(txtDato.Text);
            txtDato.Text = "";
        }
        catch (Exception)
        {
            txtDato.Text = "No es un numero: " + txtDato.Text;
        }
    }
    protected void btnQuitar_Click(object sender, EventArgs e)
    {
        if (lstListaDatos.SelectedIndex >= 0)
        {
            lstListaDatos.Items.RemoveAt(lstListaDatos.SelectedIndex);
        }
    }
}
