using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Entities
{
    internal class Profile
    {
        public int Id { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
    }
}
