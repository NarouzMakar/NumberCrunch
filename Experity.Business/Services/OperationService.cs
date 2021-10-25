using Experity.Business.IServices;
using Experity.Infrastructure;
using Experity.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Business.Services
{
    public class OperationService : ServiceBase, IOperationService
    {

        public OperationService(IUnitOfWork unitOfWork):base(unitOfWork)
        {
        }
       
        public IEnumerable<Operation> GetAll()
        {
          return  _unitOfWork.OperationRepository.GetAll();
        }
        public Operation GetById(long id)
        {
            return _unitOfWork.OperationRepository.GetById(id);
        }
        public void AddOperation(Operation newOperation)
        {
            _unitOfWork.OperationRepository.Add(newOperation);
            _unitOfWork.SaveChanges();
        }
        public void UpdateOperation(long id, string equation)
        {
            Operation opToUpdate = GetById(id);
            opToUpdate.Equation = equation;
            _unitOfWork.OperationRepository.Update(opToUpdate);
            _unitOfWork.SaveChanges();
        }
        public void DeleteOperation(long id)
        {
            Operation opToDelete = GetById(id);
            _unitOfWork.OperationRepository.Remove(opToDelete);
            _unitOfWork.SaveChanges();
        }
    }
}
