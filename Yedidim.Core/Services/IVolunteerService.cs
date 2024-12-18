using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedidim.Core.Services
{
    public interface IVolunteerService
    {
        public Task<IEnumerable<Volunteer>> GetList();

        public Task<Volunteer> Get(int id);

        public Task<Volunteer> Add(Volunteer volunteer);

        public Task<Volunteer> Update(int id, Volunteer volunteer);

        public Task<bool> Delete(int id);
    }
}
