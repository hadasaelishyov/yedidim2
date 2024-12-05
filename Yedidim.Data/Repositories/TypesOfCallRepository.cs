using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Entities;
using Yedidim.Core.Repositories;


namespace Yedidim.Data.Repositories
{
    public class TypesOfCallRepository: ITypesOfCalltRepository
    {
        private readonly DataContext _context;

        public TypesOfCallRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<TypesOfCall> GetAll()
        {
            return _context.TypesOfCall;

        }
        public TypesOfCall Get(int id)
        {
            return _context.TypesOfCall.FirstOrDefault(t => t.Id == id);
        }

        public TypesOfCall Add(TypesOfCall typesOfCall)
        {
            _context.TypesOfCall.Add(typesOfCall);
            _context.SaveChanges();
            return typesOfCall;
        }
        public void Delete(TypesOfCall typesOfCall)
        {
            int index = _context.TypesOfCall.ToList().FindIndex(e => e.Id == typesOfCall.Id);
            _context.TypesOfCall.Remove(_context.TypesOfCall.ToList()[index]);
        }
        public TypesOfCall Update(TypesOfCall typesOfCall)
        {
            int index = _context.CallsFromPeople.ToList().FindIndex(e => e.Id == typesOfCall.Id);
            _context.TypesOfCall.ToList()[index].Discribition = typesOfCall.Discribition;
            _context.TypesOfCall.ToList()[index].Id = typesOfCall.Id;
            return _context.TypesOfCall.ToList()[index];
        }
    }
}
