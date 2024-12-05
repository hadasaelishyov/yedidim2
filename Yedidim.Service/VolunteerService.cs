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

        public IEnumerable<Volunteer> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _VolunteerRepository.GetAll();

        }


        public Volunteer Get(int id)
        {
            return _VolunteerRepository.Get(id);
        }

        public Volunteer Add(Volunteer v)
        {
            return _VolunteerRepository.Add(v);
        }
        public Volunteer Update(Volunteer v)
        {
            return _VolunteerRepository.Update(v);
        }
        public void Delete(Volunteer v)
        {
            _VolunteerRepository.Delete(v);
        }
    }
}
