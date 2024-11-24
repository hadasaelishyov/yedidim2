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
        public List<CallFromPeople> GetAll();

    }
}
