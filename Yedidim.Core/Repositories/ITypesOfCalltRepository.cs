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
        public IEnumerable<TypesOfCall> GetAll();

        public TypesOfCall Get(int id);

        public TypesOfCall Add(TypesOfCall typesOfCall);

        public TypesOfCall Update(TypesOfCall typesOfCall);

        public void Delete(TypesOfCall typesOfCall);
    }
}
