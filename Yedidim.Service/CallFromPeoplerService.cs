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
    public class CallFromPeoplerService : ICallFromPeopleService
    {
        private readonly ICallFromPeopleRepository _CallFromPeopleRepository;
        public CallFromPeoplerService(ICallFromPeopleRepository studentRepository)
        {
            _CallFromPeopleRepository = studentRepository;
        }

        public async Task<IEnumerable<CallFromPeople>> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return await _CallFromPeopleRepository.GetAllAsync();

        }


        public async Task<CallFromPeople> Get(int id)
        {
            return await _CallFromPeopleRepository.GetAsync(id);
        }

        public async Task<CallFromPeople> Add(CallFromPeople c)
        {
            return await _CallFromPeopleRepository.AddAsync(c);
        }
        public async  Task<CallFromPeople> Update(int id, CallFromPeople c)
        {
            return await _CallFromPeopleRepository.UpdateAsync(id, c);
        }
        public async Task<bool> Delete(int id)
        {
            return await _CallFromPeopleRepository.DeleteAsync(id);
        }
    }
}
