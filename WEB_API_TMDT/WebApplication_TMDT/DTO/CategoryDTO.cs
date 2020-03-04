using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_TMDT.DAL;
using WebApplication_TMDT.DTO.interfaceDTO;
using WebApplication_TMDT.Models;

namespace WebApplication_TMDT.DTO
{
    public class CategoryDTO : ICategory
    {
        private IRepository _repository;
        private IUnitOfWork _unitOfWork;
        public CategoryDTO(IRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public void Add(Category category)
        {
            _repository.Add<Category>(category);
            _unitOfWork.SaveChages();
        }

        public void Delete(string id)
        {
            _repository.Delete<Category>(id);
            _unitOfWork.SaveChages();
        }

        public Category Get(string id)
        {
           return _repository.Get<Category>(id);
        }

        public IEnumerable<Category> getAll()
        {
            return _repository.GetAll<Category>();
        }

        public void Update(Category category)
        {
            _repository.Update<Category>(category);
            _unitOfWork.SaveChages();
        }
    }
}
