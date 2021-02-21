using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lexi;

namespace lexi.DAL
{
    public class Menu
    {
        public static bool add(lexi.Model.Menu menu)
        {
            bool result = false;

            string strsql = "insert into t_menu(title,state) values('"+menu.Title+"' , "+menu.State+") ";
            int i = lexiUtiliy.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0)
            {
                result = true;
            }

            return result;
        }

    }
}
