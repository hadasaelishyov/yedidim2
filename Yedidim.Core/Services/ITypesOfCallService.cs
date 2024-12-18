using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Entities;

namespace Yedidim.Core.Services
{
    public interface ITypesOfCallService
    {
        public Task<IEnumerable<TypesOfCall>> GetList();

        public Task<TypesOfCall> Get(int id);

        public Task<TypesOfCall> Add(TypesOfCall typesOfCall);

        public Task<TypesOfCall> Update(int id, TypesOfCall typesOfCall);

        public Task<bool> Delete(int id);
    }
}
