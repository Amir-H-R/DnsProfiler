using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Persistance.Entities
{
    internal class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Feild { get; set; }
        public string Value { get; set; }
    }
}
