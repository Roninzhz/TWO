using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCount
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = "";
            string pwd = "";
            if (Request.Cookies["userinfo"] != null && Request.Cookies["userinfo"]["uName"] != null)
            {
                name = Request.Cookies["userinfo"]["uName"];
                name = Request.Cookies["userinfo"]["uPwd"];
                if (name == "admin" && pwd == "admin")
                    Response.Redirect("index.aspx");
            }
        }

        protected void Unnamed1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            HttpCookie aCookie = new HttpCookie("userinfo");
            aCookie.Values["uName"] = "admin";
            aCookie.Values["pwd"] = "admin";
            aCookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(aCookie);
            string name = txtUName.Text;
            string pwd = txtUPwd.Text;
            if(name=="admin"&&pwd=="admin")
            {
                if(chkState.Checked)
                {
                    Response.Cookies["userInfo"]["nName"]= name;
                    Response.Cookies["userInfo"]["nPwd"] = pwd;
                    Response.Cookies["userInfo"].Expires = DateTime.Now.AddDays(14);
                }
                Response.Redirect("index.aspx");
            }
        }
    }
}