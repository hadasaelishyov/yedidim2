using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Repositories;

namespace Yedidim.Data.Repositories
{
    public class VolunteerRepository: IVolunteerRepository
    {
        private readonly DataContext _context;

        public VolunteerRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Volunteer> GetAll()
        {
            return _context.Volunteers;

        }
        public Volunteer Get(int id)
        {
            return _context.Volunteers.FirstOrDefault(v => v.Id == id);
        }

        public Volunteer Add(Volunteer volunteer)
        {
            _context.Volunteers.Add(volunteer);
            _context.SaveChanges();
            return volunteer;
        }
        public void Delete(Volunteer volunteer)
        {
            int index = _context.Volunteers.ToList().FindIndex(e => e.Id == volunteer.Id);
            _context.Volunteers.Remove(_context.Volunteers.ToList()[index]);
        }
        public Volunteer Update(Volunteer volunteer)
        {
            int index = _context.Volunteers.ToList().FindIndex(e => e.Id == volunteer.Id);
            _context.Volunteers.ToList()[index].Name = volunteer.Name;
            _context.Volunteers.ToList()[index].Id = volunteer.Id;
            _context.Volunteers.ToList()[index].Pwd = volunteer.Pwd;
            _context.Volunteers.ToList()[index].Phone = volunteer.Phone;

            return _context.Volunteers.ToList()[index];
        }
    }
}
