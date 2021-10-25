using Experity.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Business.IServices
{
    public interface IOperationService
    {
        public IEnumerable<Operation> GetAll();
        public Operation GetById(long id);
        public void AddOperation(Operation newOperation);
        public void UpdateOperation(long id, string value);
        public void DeleteOperation(long id);


    }
}
