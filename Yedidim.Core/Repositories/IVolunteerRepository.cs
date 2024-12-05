using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedidim.Core.Repositories
{
    public interface IVolunteerRepository
    {
        public IEnumerable<Volunteer> GetAll();

        public Volunteer Get(int id);

        public Volunteer Add(Volunteer volunteer);

        public Volunteer Update(Volunteer volunteer);

        public void Delete(Volunteer volunteer);
    }
}
