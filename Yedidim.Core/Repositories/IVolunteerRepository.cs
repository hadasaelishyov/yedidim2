using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yedidim.Core.Repositories
{
    public interface IVolunteerRepository
    {
        public List<Volunteer> GetAll();

    }
}
