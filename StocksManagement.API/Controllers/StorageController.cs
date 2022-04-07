using Microsoft.AspNetCore.Mvc;
using StocksManagement.Application.ServicesInterfaces;
using StocksManagement.Domain.Models.Storage.Request;

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

        [HttpGet("{storageId}")]
        public async Task<ActionResult> GetStorageById(int storageId)
        {
            var result = await storageService.GetStorageById(storageId);
            return Ok(result);
        }

        [HttpPost]
        public void Create(StorageCreateRequest storageCreateRequest)
        {
            storageService.Create(storageCreateRequest);
        }

        [HttpPut]
        public void Update(StorageUpdateRequest storageUpdateRequest)
        {
            storageService.Update(storageUpdateRequest);
        }

        [HttpDelete("{storageId}")]
        public void DeleteStorageById(int storageId)
        {
            storageService.DeleteById(storageId);
        }

    }
}
