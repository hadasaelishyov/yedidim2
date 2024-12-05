using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedidim.Core.Services
{
    public interface IVolunteerService
    {
        public IEnumerable<Volunteer> GetList();

        public Volunteer Get(int id);

        public Volunteer Add(Volunteer volunteer);

        public Volunteer Update(Volunteer volunteer);

        public void Delete(Volunteer volunteer);
    }
}
