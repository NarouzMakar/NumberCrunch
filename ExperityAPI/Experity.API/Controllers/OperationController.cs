using Experity.Business.IServices;
using Experity.Infrastructure.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Experity.API.Controllers
{
    public class OperationController : BootstrapControllerBase
    {
        private IOperationService _operationService;

        public OperationController(IOperationService operationService)
        {
            _operationService = operationService;
        }

        [HttpGet]
        public IEnumerable<Operation> Get()
        {
            return _operationService.GetAll();
        }

        [HttpGet("{id}")]
        public Operation Get(long id)
        {
            return _operationService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Operation operation)
        {
            _operationService.AddOperation(operation);
        }

        [HttpPut("{id}")]
        public void Put(long id, string value)
        {
            _operationService.UpdateOperation(id, value);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _operationService.DeleteOperation(id);
        }
    }
}
