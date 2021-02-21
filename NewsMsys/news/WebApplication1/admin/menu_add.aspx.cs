using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lexi;

namespace WebApplication1.admin
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lexi.Model.Menu menu = new lexi.Model.Menu();
            menu.Title = this.title.Text;
            menu.State = int.Parse(this.state.Text);

            if (Lexi.BLL.Menu.add(menu))
            {
                Response.Redirect("menu_add.aspx");
            }
        }
    }
}