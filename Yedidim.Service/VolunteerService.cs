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
    public class VolunteerService: IVolunteerService
    {
        private readonly IVolunteerRepository _VolunteerRepository;
        public VolunteerService(IVolunteerRepository volunteerRepository)
        {
            _VolunteerRepository = volunteerRepository;
        }

        public List<Volunteer> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _VolunteerRepository.GetAll();

        }
    }
}
