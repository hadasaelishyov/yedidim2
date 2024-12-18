using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Entities;

namespace Yedidim.Core.Repositories
{
    public interface ITypesOfCalltRepository
    {
        public  Task<IEnumerable<TypesOfCall>> GetAllAsync();

        public  Task<TypesOfCall> GetAsync(int id);

        public Task<TypesOfCall> AddAsync(TypesOfCall typesOfCall);

        public Task<TypesOfCall> UpdateAsync(int id, TypesOfCall typesOfCall);

        public Task<bool> DeleteAsync(int id);
    }
}
