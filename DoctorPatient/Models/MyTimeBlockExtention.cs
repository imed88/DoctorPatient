using Itenso.TimePeriod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DoctorPatient.Models
{
    public class MyTimeBlockExtention:TimeBlock
    {
        public MyTimeBlockExtention(DateTime x, TimeSpan y)
          : base(x, y)
        {
            // Calling base constructor  
        }

        //Overriding toString Method
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Start.ToShortTimeString());
            sb.Append(" to ");
            sb.Append(this.End.ToShortTimeString());
            return sb.ToString();
        }
    }
}