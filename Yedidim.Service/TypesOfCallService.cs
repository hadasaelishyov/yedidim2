using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Entities;
using Yedidim.Core.Repositories;
using Yedidim.Core.Services;

namespace Yedidim.Service
{
    public class TypesOfCallService: ITypesOfCallService
    {
        private readonly ITypesOfCalltRepository _TypesOfCallRepository;
        public TypesOfCallService(ITypesOfCalltRepository typesOfCalltRepository)
        {
            _TypesOfCallRepository = typesOfCalltRepository;
        }

        public IEnumerable<TypesOfCall> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _TypesOfCallRepository.GetAll();

        }


        public TypesOfCall Get(int id)
        {
            return _TypesOfCallRepository.Get(id);
        }

        public TypesOfCall Add(TypesOfCall t)
        {
            return _TypesOfCallRepository.Add(t);
        }
        public TypesOfCall Update(TypesOfCall t)
        {
            return _TypesOfCallRepository.Update(t);
        }
        public void Delete(TypesOfCall t)
        {
            _TypesOfCallRepository.Delete(t);
        }
    }
}
