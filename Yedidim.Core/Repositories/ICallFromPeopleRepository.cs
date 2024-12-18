using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Entities;

namespace Yedidim.Core.Repositories
{
    public interface ICallFromPeopleRepository
    {
        public Task<IEnumerable<CallFromPeople>> GetAllAsync();

        public Task<CallFromPeople> GetAsync(int id);

        public Task<CallFromPeople> AddAsync(CallFromPeople callFromPeople);

        public Task<CallFromPeople> UpdateAsync(int id, CallFromPeople callFromPeople);

        public Task<bool> DeleteAsync(int id);

    }
}
