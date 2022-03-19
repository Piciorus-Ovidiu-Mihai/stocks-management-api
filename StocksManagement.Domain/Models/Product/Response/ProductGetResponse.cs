using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksManagement.Domain.Models.Storage.Response
{
    public class ProductGetResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ActualStock { get; set; }
    }
}
