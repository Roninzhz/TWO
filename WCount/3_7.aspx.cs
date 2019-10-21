using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCount
{
    public partial class _3_7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("test.txt");
            //if (File.Exists(Server.MapPath("test.txt")))
            //{
            //    File.OpenText(Server.MapPath("test.txt"));
            //}else
            //{
            //    File.CreateText(Server.MapPath("test.txt"));
            //}
            if (File.Exists(Server.MapPath("test.txt")))
            {
                StreamReader sr = File.OpenText(filepath);
                while (sr.Peek() != -1)
                {
                    lblInfo.Text += (sr.ReadLine() + "<br/>");
                }
                sr.Close();
            }
        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("test.txt");
            if (File.Exists(filepath))
            {
                StreamWriter sw = new StreamWriter(filepath, true);
                string str = "河北师范大学大学附属民族学院";
                sw.WriteLine(str);
                sw.Close();
                lblInfo.Text = "成功写入文件";
            }
        }
    }
}