using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Entities;
using Yedidim.Core.Repositories;


namespace Yedidim.Data.Repositories
{
    public class TypesOfCallRepository: ITypesOfCalltRepository
    {
        private readonly DataContext _context;

        public TypesOfCallRepository(DataContext context)
        {
            _context = context;
        }
        public List<TypesOfCall> GetAll()
        {
            return _context.TypesOfCall.ToList();
        }
    }
}
