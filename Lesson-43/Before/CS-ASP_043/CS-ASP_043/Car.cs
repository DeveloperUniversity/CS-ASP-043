using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_043
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
 

        public string FormatDetailsForDisplay()
        {
            return String.Format("Make: {0} - Model: {1} - Year: {2} - Color: {3}", this.Make, this.Model, this.Year.ToString(), this.Color);
        }


    }
}