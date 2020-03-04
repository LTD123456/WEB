using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO.interfaceDTO
{
    public interface ICart
    {
        IEnumerable<Cart> getAll();
        void Add(Cart cart);
        void Update(Cart cart);
        void Delete(string id);
        Cart Get(string id);
    }
}
