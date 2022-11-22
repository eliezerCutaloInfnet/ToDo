namespace ToDo.Application.Dtos.Item
{
    public class ItemResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string CreatedAt { get; set; }
        public bool Done { get; set; }

    }
}
