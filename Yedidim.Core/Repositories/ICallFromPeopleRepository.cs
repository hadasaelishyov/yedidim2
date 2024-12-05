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
        public IEnumerable<CallFromPeople> GetAll();

        public CallFromPeople Get(int id);

        public CallFromPeople Add(CallFromPeople callFromPeople);

        public CallFromPeople Update(CallFromPeople callFromPeople);

        public void Delete(CallFromPeople callFromPeople);

    }
}
