﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class HobiListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLHOBILERTableAdapter dt= new DataSetTableAdapters.TBLHOBILERTableAdapter();  
            Repeater1.DataSource = dt.HobiListesi();
            Repeater1.DataBind();
        }
    }
}