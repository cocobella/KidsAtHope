using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTraveler.Models
{
    public class SelectionWithOther
    {
        public string Selection { get; set; }
        public string OtherText { get; set; }

        public SelectionWithOther()
        {
            this.Selection = string.Empty;
            this.OtherText = string.Empty;
        }
    }
}