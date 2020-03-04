using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO.interfaceDTO
{
    public interface IProduct
    {
        IEnumerable<Product> getAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(string id);
        Product Get(string id);
    }
}
