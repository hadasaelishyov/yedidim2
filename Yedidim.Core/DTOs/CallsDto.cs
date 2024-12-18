using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedidim.Core.DTOs
{
    public class CallsDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public int TypesOfCallID { get; set; }

        public int VolunteerID { get; set; }
    }
}
