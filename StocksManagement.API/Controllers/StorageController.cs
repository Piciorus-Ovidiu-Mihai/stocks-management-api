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

        [HttpGet("GetAllStorages")]
        public async Task<ActionResult> GetAllStorages()
        {
            var result = await storageService.GetAllStorages();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetStorageById(int storageId)
        {
            var result = await storageService.GetStorageById(storageId);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public void DeleteStorageById(int storageId)
        {
            storageService.DeleteById(storageId);
        }

        [HttpPut]
        public void Update(Storage storage)
        {
            storageService.Update(storage);
        }

        [HttpPost]
        public void Create(Storage storage)
        {
            storageService.Create(storage);
        }
        
    }
}
