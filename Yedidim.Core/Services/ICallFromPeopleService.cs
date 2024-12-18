using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Entities;

namespace Yedidim.Core.Services
{
    public interface ICallFromPeopleService
    {
        public Task<IEnumerable<CallFromPeople>> GetList();

        public Task<CallFromPeople> Get(int id);

        public Task<CallFromPeople> Add(CallFromPeople callFromPeople);

        public Task<CallFromPeople> Update(int id, CallFromPeople callFromPeople);

        public Task<bool> Delete(int id);
    }
}
