using Electrodevices.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodevices.Model
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Electrodevice> Electrodevices { get; set; } = new List<Electrodevice>();

        public override string ToString()
        {
            return Name;
        }
    }
}
