using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedidim.Core.Repositories
{
    public interface IVolunteerRepository
    {
        public Task<IEnumerable<Volunteer>> GetAllAsync();

        public Task<Volunteer> GetAsync(int id);

        public Task<Volunteer> AddAsync(Volunteer volunteer);

        public Task<Volunteer> UpdateAsync(int id, Volunteer volunteer);

        public Task<bool> DeleteAsync(int id);
    }
}
