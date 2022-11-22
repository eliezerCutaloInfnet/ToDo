using ToDo.Application.Dtos.Item;

namespace ToDo.Application.Interfaces
{
    public interface IItemAppService
    {
        Task<IEnumerable<ItemResponse>> GetItemsAsync();

        Task CreateItemAsync(CreateItemRequestDto dto);
    }
}
