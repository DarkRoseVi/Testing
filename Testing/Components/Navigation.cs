using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Testing.Components
{
    internal class Navigation
    {
        public static List<Nav> navs = new List<Nav>();
        public static User AutoUser;
        public static MainWindow main;
        public static void Update(Nav nav) 
        {
            main.Myframe.Navigate(nav.Page);
           
        }
        public static void Nextpage(Nav nav) 
        {
            navs.Add(nav);
            Update(nav);
        }
    }
    class  Nav
    {
     //public string Title { get; set;}
        public Page Page { get; set; }
        public Nav( Page Page) 
        {
          /*  this.Title = Title*/
            this.Page = Page;   
        }
    }
}

