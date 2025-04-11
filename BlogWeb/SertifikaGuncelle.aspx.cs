using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class SertifikaGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(Request.QueryString["ID"]);
            Txtid.Text=a.ToString();
            Txtid.Enabled = false;

            if(Page.IsPostBack == false)
            {
                DataSetTableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSetTableAdapters.TBLSERTIFIKALARTableAdapter();
                TxtSertifika.Text = dt.SertifikaGetir(Convert.ToInt16(a))[0].SERTIFIKALAR;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSetTableAdapters.TBLSERTIFIKALARTableAdapter();
            dt.SertifikaGuncelle(TxtSertifika.Text, Convert.ToInt16(Txtid.Text));
            Response.Redirect("SertifikalarListesi.aspx");
        }
    }
}