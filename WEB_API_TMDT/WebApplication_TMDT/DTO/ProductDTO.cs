using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.DAL;
using WebApplication_TMDT.DTO.interfaceDTO;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO
{
    public class ProductDTO:IProduct
    {
        private IRepository _repository;
        private IUnitOfWork _unitOfWork;

        public ProductDTO(IRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Product product)
        {
            _repository.Add<Product>(product);
            _unitOfWork.SaveChages();
        }

        public void Delete(string id)
        {
            _repository.Delete<Product>(id);
            _unitOfWork.SaveChages();
        }

        public Product Get(string id)
        {
            return _repository.Get<Product>(id);
        }

        public IEnumerable<Product> getAll()
        {
            return _repository.GetAll<Product>();
        }

        public void Update(Product product)
        {
            _repository.Update<Product>(product);
            _unitOfWork.SaveChages();
        }
    }
}
