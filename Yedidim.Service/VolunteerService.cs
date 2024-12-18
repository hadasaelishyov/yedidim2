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

        public async Task<IEnumerable<Volunteer>> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return await _VolunteerRepository.GetAllAsync();

        }


        public async Task<Volunteer> Get(int id)
        {
            return await _VolunteerRepository.GetAsync(id);
        }

        public async Task<Volunteer> Add(Volunteer v)
        {
            return await _VolunteerRepository.AddAsync(v);
        }
        public async Task<Volunteer> Update(int id, Volunteer v)
        {
            return await _VolunteerRepository.UpdateAsync(id, v);
        }
        public async Task<bool> Delete(int id)
        {
            return await _VolunteerRepository.DeleteAsync(id);
        }
    }
}
