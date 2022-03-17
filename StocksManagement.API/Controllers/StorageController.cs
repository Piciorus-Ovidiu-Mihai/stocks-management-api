using StocksManagement.Application.ServicesInterfaces;

namespace StocksManagement.API.Controllers
{
    public class StorageController : ApiControllerBase
    {
        private readonly IStorageService storageService;

        public StorageController(IStorageService storageService)
        {
            this.storageService = storageService;
        }
    }
}
