using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Volunteer>> GetAllAsync()
        {
            return await _context.Volunteers.Where(c => !string.IsNullOrEmpty(c.Name)).ToListAsync();

        }
        public async Task<Volunteer> GetAsync(int id)
        {
            return await _context.Volunteers.FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<Volunteer> AddAsync(Volunteer volunteer)
        {
            _context.Volunteers.Add(volunteer);
            await _context.SaveChangesAsync();
            return volunteer;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var v = await _context.Volunteers.FindAsync(id);
            if (v == null)
                return false;
            _context.Volunteers.Remove(v);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Volunteer> UpdateAsync(int id, Volunteer volunteer)
        {
            var v = await _context.Volunteers.FindAsync(id);
            if (v == null)
                return null;
            v.Name = volunteer.Name;
            v.Pwd=volunteer.Pwd;
            v.Phone = volunteer.Phone;
            _context.Volunteers.Update(v);
            await _context.SaveChangesAsync();
            return v;
        }
    }
}
