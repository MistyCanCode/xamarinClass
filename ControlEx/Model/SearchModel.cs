using System;
using System.Collections.Generic;
using System.Text;

namespace ControlEx.Model
{
    public class SearchModel
    {
        public string From_Location { get; set; }
        public string To_Location { get; set; }
        public DateTime From_Date { get; set; }
        public DateTime To_Date { get; set; }

        public string Location
        {
            get
            {
                return From_Location + " - " + To_Location;
            }
        }

        public string Period
        {
            get
            {
                return String.Format("{0} - {1}",
                    From_Date.ToString("MMM d, yyyy"),
                    To_Date.ToString("MMM d, yyyy"));
            }
        }
    }
}
