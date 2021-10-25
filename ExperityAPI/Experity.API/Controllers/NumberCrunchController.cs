using Experity.API.Models;
using Experity.Business.DTOs;
using Experity.Business.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experity.API.Controllers
{
    public class NumberCrunchController : BootstrapControllerBase
    {
        private INumberCrunchService _numberCrunchService;

        public NumberCrunchController(INumberCrunchService numberCrunchService)
        {
            _numberCrunchService = numberCrunchService;
        }
        [HttpPost]
        public async Task<JsonActionResult> Add(NumberCrunchDto numberCrunchDto)
        {
            try
            {
                if (!ModelState.IsValid || numberCrunchDto.Id > 0)
                {
                    return JsonUtility.Error("Invalid Data");
                }

                var sectionId = await _numberCrunchService.AddNumberCruncAsync(numberCrunchDto);
                return sectionId > 0
                    ? JsonUtility.Success(sectionId)
                    : JsonUtility.Error("Failed To Add");
            }
            catch (Exception ex)
            {
                return JsonUtility.Error(ex);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<JsonActionResult> GetNumberCrunchList(long id)
        {
            try
            {
                var list =  await _numberCrunchService.GetNumberCrunchListById(id);
                return list.Count > 0
                    ? JsonUtility.Success(list)
                    : JsonUtility.Error("Failed To Genetate List");
            }
            catch (Exception ex)
            {
                return JsonUtility.Error(ex);
            }
        }
    }
}
