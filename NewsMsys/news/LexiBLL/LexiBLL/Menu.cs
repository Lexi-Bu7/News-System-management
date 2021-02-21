using System;
using System.Collections.Generic;
using System.Text;

namespace Lexi.BLL
{
    public class Menu
    {
        public static bool add(lexi.Model.Menu menu)
        {
            return lexi.DAL.Menu.add(menu);
        }
    }
}
