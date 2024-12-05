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
        public IEnumerable<TypesOfCall> GetList();

        public TypesOfCall Get(int id);

        public TypesOfCall Add(TypesOfCall typesOfCall);

        public TypesOfCall Update(TypesOfCall typesOfCall);

        public void Delete(TypesOfCall typesOfCall);
    }
}
