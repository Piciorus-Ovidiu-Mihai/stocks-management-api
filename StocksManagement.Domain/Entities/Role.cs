using StocksManagement.Application.RepositoryInterfaces.Generic;

namespace StocksManagement.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
