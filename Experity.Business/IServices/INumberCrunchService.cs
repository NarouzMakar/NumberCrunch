using Experity.Business.DTOs;
using Experity.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Business.IServices
{
    public interface INumberCrunchService
    {
        public Task<long> AddNumberCruncAsync(NumberCrunchDto numberCrunchDto);
        public Task<List<NumberCrunchVm>> GetNumberCrunchListById(long id);

    }
}
