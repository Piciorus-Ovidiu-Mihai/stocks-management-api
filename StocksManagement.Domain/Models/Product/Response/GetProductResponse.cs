namespace StocksManagement.Domain.Models.Storage.Response
{
    public class GetProductResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ActualStock { get; set; }
    }
}
