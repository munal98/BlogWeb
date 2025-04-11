using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			DataSetTableAdapters.TBLHAKKIMDATableAdapter dt = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
			Repeater1.DataSource = dt.HakkımdaListele();
			Repeater1.DataBind();


			DataSetTableAdapters.TBLDENEYIMTableAdapter dt2 = new DataSetTableAdapters.TBLDENEYIMTableAdapter();
			Repeater2.DataSource = dt2.DeneyimListesi();
			Repeater2.DataBind();

			DataSetTableAdapters.TBLEGITIMTableAdapter dt3 = new DataSetTableAdapters.TBLEGITIMTableAdapter();
			Repeater3.DataSource = dt3.EgitimListesi();
			Repeater3.DataBind();

			DataSetTableAdapters.TBLYETENEKLERTableAdapter dt4 = new DataSetTableAdapters.TBLYETENEKLERTableAdapter();
			Repeater4.DataSource = dt4.YetenekListesi();
			Repeater4.DataBind();

			DataSetTableAdapters.TBLHOBILERTableAdapter dt5 = new DataSetTableAdapters.TBLHOBILERTableAdapter();
			Repeater5.DataSource = dt5.HobiListesi();
			Repeater5.DataBind();

			DataSetTableAdapters.TBLSERTIFIKALARTableAdapter dt6 = new DataSetTableAdapters.TBLSERTIFIKALARTableAdapter();
			Repeater6.DataSource = dt6.SertifikalarListesi();
			Repeater6.DataBind();

			DataSetTableAdapters.TBLHAKKIMDATableAdapter dt7=new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
			Repeater7.DataSource = dt7.HakkımdaListele();
			Repeater7 .DataBind();
		}
	}
}