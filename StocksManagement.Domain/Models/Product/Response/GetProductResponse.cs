namespace StocksManagement.Domain.Models.Product.Response
{
    public class GetProductResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ActualStock { get; set; }
    }
}
