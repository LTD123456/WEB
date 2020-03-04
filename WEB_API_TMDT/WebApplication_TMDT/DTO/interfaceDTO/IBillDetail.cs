using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO.interfaceDTO
{
    public interface IBillDetail
    {
        IEnumerable<BillDetail> getAll();
        void Add(BillDetail billDetail);
        void Update(BillDetail billDetail);
        void Delete(string id);
        BillDetail Get(string id);
    }
}
