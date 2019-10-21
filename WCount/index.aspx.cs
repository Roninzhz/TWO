using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCount
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         //cookie
            //if (Request.Cookies["userinfo"] != null && Request.Cookies["userinfo"]["uName"] != null)
            //{
            //    string name = Request.Cookies["userinfo"]["uName"];
            //    Response.Write("你好" + name);
            //    int count = 0;
            //    if (Request.Cookies["count"] != null)
            //        count = int.Parse(Request.Cookies["count"].Value);
            //    count++;
            //    Response.Cookies["count"].Value = count.ToString();
            //    Response.Cookies["count"].Expires = DateTime.Now.AddDays(1);
            //    lblCount.Text = "当前访问次数" + count.ToString() + "次";
            //}
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //cookie
            //HttpCookie aCookie;
            //string cookieName;
            //for (int i = 0; i < Request.Cookies.Count; i++)
            //{
            //    cookieName = Request.Cookies[i].Name;
            //    aCookie = new HttpCookie(cookieName);
            //    aCookie.Expires = DateTime.Now.AddDays(-1);
            //    //Response.Cookies.Add(aCookie);
            //}
            //Response.Write("清理成功");

            //Session
            if (Session["uName"] != null)
            {
                string name = Session["uName"].ToString();
                Response.Write("当前用户" + name);
                //Session.Timeout = 1;
            }
        }
    }
}