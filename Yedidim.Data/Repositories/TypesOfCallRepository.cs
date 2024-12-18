using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yedidim.Core.Entities;
using Yedidim.Core.Repositories;


namespace Yedidim.Data.Repositories
{
    public class TypesOfCallRepository : ITypesOfCalltRepository
    {
        private readonly DataContext _context;

        public TypesOfCallRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TypesOfCall>> GetAllAsync()
        {
            return await _context.TypesOfCall.Where(c => !string.IsNullOrEmpty(c.Discribition)).ToListAsync();
        }
        public async Task<TypesOfCall> GetAsync(int id)
        {
            return await _context.TypesOfCall.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<TypesOfCall> AddAsync(TypesOfCall typesOfCall)
        {
            _context.TypesOfCall.Add(typesOfCall);
            await _context.SaveChangesAsync();
            return typesOfCall;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var type = await _context.TypesOfCall.FindAsync(id);
            if (type == null)
                return false;
            _context.TypesOfCall.Remove(type);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<TypesOfCall> UpdateAsync(int id, TypesOfCall typesOfCall)
        {
            var type = await _context.TypesOfCall.FindAsync(id);
            if (type == null)
                return null;
            type.Discribition = typesOfCall.Discribition;
            _context.TypesOfCall.Update(type);
            await _context.SaveChangesAsync();
            return type;
        }
    }
}
