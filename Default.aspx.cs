using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        List<string> oNombres = cntLstCiudades.Lista;
        //LogicaCiudades.Agregar(oNombres);
        int i=0;
        foreach (string oAux in oNombres)
        {
            i++;
            ListBox1.Items.Add( i+")"+oAux);
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Text = "Esta buscando vivendas del tipo" + BuscadorPorTipo1.Tipo + " con el datos:" + BuscadorPorTipo1.DatoBuscado;
    }
}
