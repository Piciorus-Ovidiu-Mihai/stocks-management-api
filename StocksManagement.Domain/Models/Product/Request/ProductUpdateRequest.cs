namespace StocksManagement.Domain.Models.Product.Request
{
    public class ProductUpdateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ActualStock { get; set; }
    }
}
