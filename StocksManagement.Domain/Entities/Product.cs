using StocksManagement.Application.RepositoryInterfaces.Generic;

namespace StocksManagement.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ActualStock { get; set; }
        public Storage Storage { get; set; }
    }
}
