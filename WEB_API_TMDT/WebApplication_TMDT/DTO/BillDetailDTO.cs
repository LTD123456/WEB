using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.DAL;
using WebApplication_TMDT.DTO.interfaceDTO;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO
{
    public class BillDetailDTO: IBillDetail
    {
        private IRepository _repository;
        private IUnitOfWork _uniOfWork;

        public BillDetailDTO(IRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _uniOfWork = unitOfWork;
        }

        public void Add(BillDetail billDetail)
        {
            _repository.Add<BillDetail>(billDetail);
            _uniOfWork.SaveChages();
        }

        public void Delete(string id)
        {
            _repository.Delete<BillDetail>(id);
            _uniOfWork.SaveChages();
        }

        public BillDetail Get(string id)
        {
            return _repository.Get<BillDetail>(id);
        }

        public IEnumerable<BillDetail> getAll()
        {
            return _repository.GetAll<BillDetail>();
        }

        public void Update(BillDetail billDetail)
        {
            _repository.Update<BillDetail>(billDetail);
            _uniOfWork.SaveChages();
        }
    }
}
