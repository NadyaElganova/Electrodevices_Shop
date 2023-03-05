using Electrodevices.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodevices.Model
{
    public class Date
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public ICollection<Electrodevice> Electrodevices { get; set; } = new List<Electrodevice>();
        public override string ToString()
        {
            return Year.ToString();
        }
    }
}
