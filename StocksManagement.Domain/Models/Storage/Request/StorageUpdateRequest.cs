namespace StocksManagement.Domain.Models.Storage.Request
{
    public class StorageUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<int> ProductsIds { get; set; }
    }
}
