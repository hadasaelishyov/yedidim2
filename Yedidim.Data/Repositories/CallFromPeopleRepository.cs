using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Repositories;
using Yedidim.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Yedidim.Data.Repositories
{
    public class CallFromPeopleRepository : ICallFromPeopleRepository
    {
        private readonly DataContext _context;

        public CallFromPeopleRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CallFromPeople>> GetAllAsync()
        {
            return await _context.CallsFromPeople.Where(c => !string.IsNullOrEmpty(c.Name)).Include(c => c.TypesOfCall).Include(c=>c.Volunteer).ToListAsync();

        }
        public async Task<CallFromPeople> GetAsync(int id)
        {
            return await _context.CallsFromPeople.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<CallFromPeople> AddAsync(CallFromPeople callFromPeople)
        {
            _context.CallsFromPeople.Add(callFromPeople);
            await _context.SaveChangesAsync();
            return callFromPeople;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var call = await _context.CallsFromPeople.FindAsync(id);
            if (call == null)
                return false;
            _context.CallsFromPeople.Remove(call);
            await _context.SaveChangesAsync();
            return true;

        }
        public async Task<CallFromPeople> UpdateAsync(int id, CallFromPeople callFromPeople)
        {
            var call = await _context.CallsFromPeople.FindAsync(id);
            if (call == null)
                return null;
            call.Phone = callFromPeople.Phone;
            call.TypesOfCallID = callFromPeople.TypesOfCallID;
            call.VolunteerID = callFromPeople.VolunteerID;
            _context.CallsFromPeople.Update(call);
            await _context.SaveChangesAsync();
            return call;
        }
    }
}
