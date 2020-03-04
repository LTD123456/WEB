using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.DAL;
using WebApplication_TMDT.DTO.interfaceDTO;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO
{
    public class CartDTO : ICart
    {
        private IRepository _repository;
        private IUnitOfWork _unitOfWork;
        public CartDTO(IRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public void Add(Cart cart)
        {

            _repository.Add<Cart>(cart);
            _unitOfWork.SaveChages();
        }

        public void Delete(string id)
        {
            _repository.Delete<Cart>(id);
            _unitOfWork.SaveChages();
        }

        public Cart Get(string id)
        {
            return _repository.Get<Cart>(id);
        }

        public IEnumerable<Cart> getAll()
        {
            return _repository.GetAll<Cart>();
        }

        public void Update(Cart cart)
        {
            _repository.Update<Cart>(cart);
            _unitOfWork.SaveChages();
        }
    }
}
