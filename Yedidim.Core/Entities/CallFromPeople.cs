using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedidim.Core.Entities
{
    public class CallFromPeople
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int IdTypesOfCall { get; set; }
        public int IdVolunteer { get; set; }
    }
}
