using ToDo.Application.Dtos.Item;
using ToDo.Application.Interfaces;
using ToDo.Domain.Entities;
using ToDo.Domain.Interface;

namespace ToDo.Application.AppServices
{
    public class ItemAppService : IItemAppService
    {
        private IItemRepository repository;
        public ItemAppService(IItemRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateItemAsync(CreateItemRequestDto dto)
        {
            try
            {
                var item = new Item(dto.Description);
                await repository.AddAsync(item);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ItemResponse>> GetItemsAsync()
        {
            try
            {
                return await repository.GetAllAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
