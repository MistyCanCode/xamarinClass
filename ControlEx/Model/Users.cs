using System;
using System.Collections.Generic;
using System.Text;

namespace ControlEx.Model
{
    class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
       // public string ImageUrl { get; set; }

        public string Image
        {
            get
            {
                return $"https://loremflicker.com/320/240/{UserID}";
            }
        }

    }
}
