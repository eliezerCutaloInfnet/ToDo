using Microsoft.EntityFrameworkCore;
using ToDo.Domain.Entities;
using ToDo.Domain.Interface;
using ToDo.Infra.Data.Context;

namespace ToDo.Infra.Data.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;
        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task AddAsync(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            
        }

        public async Task EditAsync(Item item)
        {
           
            _context.Items.Update(item);
            await _context.SaveChangesAsync();

        }
    }
}
