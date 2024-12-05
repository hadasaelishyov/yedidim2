using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Repositories;
using Yedidim.Core.Entities;


namespace Yedidim.Data.Repositories
{
    public class CallFromPeopleRepository: ICallFromPeopleRepository
    {
        private readonly DataContext _context;

        public CallFromPeopleRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<CallFromPeople> GetAll()
        {
            return _context.CallsFromPeople.Where(c => !string.IsNullOrEmpty(c.Name));

        }
        public CallFromPeople Get(int id)
        {
            return _context.CallsFromPeople.FirstOrDefault(c => c.Id == id);
        }

        public CallFromPeople Add(CallFromPeople callFromPeople)
        {
            _context.CallsFromPeople.Add(callFromPeople);
            _context.SaveChanges();
            return callFromPeople;
        }
        public void Delete(CallFromPeople callFromPeople)
        {
            int index = _context.CallsFromPeople.ToList().FindIndex(e => e.Id == callFromPeople.Id);
            _context.CallsFromPeople.Remove(_context.CallsFromPeople.ToList()[index]);
        }
        public CallFromPeople Update(CallFromPeople callFromPeople)
        {
            int index = _context.CallsFromPeople.ToList().FindIndex(e => e.Id == callFromPeople.Id);
            _context.CallsFromPeople.ToList()[index].Phone = callFromPeople.Phone;
            _context.CallsFromPeople.ToList()[index].IdTypesOfCall = callFromPeople.IdTypesOfCall;
            _context.CallsFromPeople.ToList()[index].IdVolunteer = callFromPeople.IdVolunteer;

            return _context.CallsFromPeople.ToList()[index];
        }
    }
}
