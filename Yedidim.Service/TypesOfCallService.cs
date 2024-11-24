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

        public List<TypesOfCall> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _TypesOfCallRepository.GetAll();
        }
    }
}
