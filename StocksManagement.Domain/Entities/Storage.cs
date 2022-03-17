using StocksManagement.Application.RepositoryInterfaces.Generic;

namespace StocksManagement.Domain.Entities
{
    public class Storage : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
