using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Repositories;

namespace Yedidim.Data.Repositories
{
    public class VolunteerRepository: IVolunteerRepository
    {
        private readonly DataContext _context;

        public VolunteerRepository(DataContext context)
        {
            _context = context;
        }
        public List<Volunteer> GetAll()
        {
            return _context.Volunteers.ToList();
        }
    }
}
