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

        public async Task<IEnumerable<TypesOfCall>> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return await _TypesOfCallRepository.GetAllAsync();

        }


        public async Task<TypesOfCall> Get(int id)
        {
            return await _TypesOfCallRepository.GetAsync(id);
        }

        public async Task<TypesOfCall> Add(TypesOfCall t)
        {
            return await _TypesOfCallRepository.AddAsync(t);
        }
        public async Task<TypesOfCall> Update(int id, TypesOfCall t)
        {
            return await _TypesOfCallRepository.UpdateAsync(id, t);
        }
        public async Task<bool> Delete(int id)
        {
             return await _TypesOfCallRepository.DeleteAsync(id);
        }
    }
}
