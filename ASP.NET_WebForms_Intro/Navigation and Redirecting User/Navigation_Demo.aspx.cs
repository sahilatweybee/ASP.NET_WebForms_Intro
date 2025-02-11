﻿using System;
using System.Web.UI.WebControls;

namespace ASP.NET_WebForms_Intro
{
    public partial class Navigation_Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public String TextData
        {
            get
            {
                return TextBox.Text;
            }
        }

        protected void Redirect_Click(object sender, EventArgs e)
        {
            String Data = TextBox.Text;
            Response.Redirect("Target.aspx?Data=" + Data);
        }

        protected void Transfer_Click(object sender, EventArgs e)
        {
            String Data = TextBox.Text;
            Context.Items["Data"] = Data;
            Server.Transfer("Target.aspx");
        }
    }
}