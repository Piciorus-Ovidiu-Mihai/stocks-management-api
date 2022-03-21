﻿namespace StocksManagement.Domain.Models.Storage.Request
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ActualStock { get; set; }
    }
}
