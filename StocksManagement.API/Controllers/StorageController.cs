using Microsoft.AspNetCore.Mvc;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Entities;

namespace StocksManagement.API.Controllers
{
    public class StorageController : ApiControllerBase
    {
        private readonly IStorageService storageService;

        public StorageController(IStorageService storageService)
        {
            this.storageService = storageService;
        }

        public async Task<ActionResult> GetAllStorages()
        {
            var result = await storageService.GetAllStorages();
            return Ok(result);
        }

        public async Task<ActionResult> GetStorageById(int storageId)
        {
            var result = await storageService.GetStorageById(storageId);
            return Ok(result);
        }

        public void DeleteStorageById(int storageId)
        {
            storageService.DeleteById(storageId);
        }

        public void UpdateById(int storageId)
        {
            storageService.UpdateById(storageId);
        }

        public void Create(Storage storage)
        {
            storageService.Create(storage);
        }
        
    }
}
