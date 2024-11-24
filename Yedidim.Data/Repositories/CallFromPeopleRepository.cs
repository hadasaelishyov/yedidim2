using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Repositories;
using Yedidim.Core.Entities;


namespace Yedidim.Data.Repositories
{
    public class CallFromPeopleRepository: ICallFromPeopleRepository
    {
        private readonly DataContext _context;

        public CallFromPeopleRepository(DataContext context)
        {
            _context = context;
        }
        public List<CallFromPeople> GetAll()
        {
            return _context.CallsFromPeople.ToList();
        }
    }
}
