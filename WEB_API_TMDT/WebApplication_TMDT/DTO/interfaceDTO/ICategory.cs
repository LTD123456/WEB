using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO.interfaceDTO
{
    public interface ICategory
    {
        IEnumerable<Category> getAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(string id);
        Category Get(string id);
    }
}
