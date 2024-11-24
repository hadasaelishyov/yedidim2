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
        public List<CallFromPeople> GetList();

    }
}
