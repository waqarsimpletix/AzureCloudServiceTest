﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRole1
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var all = string.Format("test{0}", 123);
            //Some Test
        }
    }
}