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

public partial class ListaDeDatos : System.Web.UI.UserControl
{
    public List<string> Lista
    {
        get {
            List<String>  oLista =new List<string>();
            int oNumero;
            foreach(object oAux in lstListaDatos.Items)
            {
                oLista.Add(oAux.ToString());
            }
            return oLista; 
        }
    }
	
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
            lstListaDatos.Items.Add(txtDato.Text);
            txtDato.Text = "";
    }

    protected void btnQuitar_Click(object sender, EventArgs e)
    {
        if (lstListaDatos.SelectedIndex >= 0)
        {
            lstListaDatos.Items.RemoveAt(lstListaDatos.SelectedIndex);
        }
    }

   
}
