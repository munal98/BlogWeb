﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class SertifikalarListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLSERTIFIKALARTableAdapter dt = new DataSetTableAdapters.TBLSERTIFIKALARTableAdapter();
            Repeater1.DataSource = dt.SertifikalarListesi();
            Repeater1.DataBind();
        }
    }
}