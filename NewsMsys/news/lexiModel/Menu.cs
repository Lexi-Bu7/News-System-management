using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lexi.Model
{   /// <summary>
    /// News types
    /// </summary>
    public class Menu
    {   
        private int id;

        public int Id { 
            get => id; 
            set => id = value; 
        }
        private string title;
        public string Title { get => title; set => title = value; }


        private int state;
        public int State { get => state; set => state = value; }
      
       
    }

}
