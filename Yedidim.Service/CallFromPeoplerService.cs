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

        public List<CallFromPeople> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _CallFromPeopleRepository.GetAll();

        }
    }
}
