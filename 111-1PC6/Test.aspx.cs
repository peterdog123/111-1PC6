using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC6
{
    public partial class Test : System.Web.UI.Page
    {
        string[] s_school = new string[3] { "台科", "北大", "亞東" };
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < s_school.Length; i++)
            {
                ListItem s_item = new ListItem();
                s_item.Text = s_item.Value = s_school[i];
                ddl_Test.Items.Add(s_item);
            }
        }
    }
}