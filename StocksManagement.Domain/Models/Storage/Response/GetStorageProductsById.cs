
using StocksManagement.Domain.Models.Product.Response;

namespace StocksManagement.Domain.Models.Storage.Response
{
    public class GetStorageProductsById
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<GetProductResponse> getProductResponses { get; set; } = new List<GetProductResponse>();
    }
}
