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

public partial class BuscadorPorTipo : System.Web.UI.UserControl
{
    
    public string Tipo
    {
        get { return drpTipo.SelectedValue; }
    }

    

    public string DatoBuscado
    {
        get { return txtDatoBuscado.Text; }
    
    }
	
	
    protected void Page_Load(object sender, EventArgs e)
    {
        if (drpTipo.Items.Count==0)
        {
            drpTipo.Items.Add("Casa");
            drpTipo.Items.Add("Apartamento");
            drpTipo.Items.Add("Hotel");
            drpTipo.Items.Add("Campin");
            drpTipo.SelectedIndex = 0;
        }
    }
}
