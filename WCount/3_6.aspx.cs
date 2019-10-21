using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCount
{
    public partial class _3_6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str="<h3>河北师范大学附属民族学院</h3>";
            lblEnCode.Text=Server.HtmlEncode(str);
            lblDeCode.Text=Server.HtmlDecode(lblEnCode.Text);
        }
    }
}