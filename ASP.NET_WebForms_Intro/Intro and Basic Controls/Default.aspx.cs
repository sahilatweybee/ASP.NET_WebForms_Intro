﻿using System;

namespace ASP.NET_WebForms_Intro
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSayHello_Click(object sender, EventArgs e)
        {
            LblMsg.Text = "Hello " + txtBox.Text;
        }
    }
}