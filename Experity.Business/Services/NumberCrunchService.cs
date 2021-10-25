using Experity.Business.DTOs;
using Experity.Business.IServices;
using Experity.Business.ViewModels;
using Experity.Infrastructure;
using Experity.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Business.Services
{
    public class NumberCrunchService : ServiceBase, INumberCrunchService
    {
        public NumberCrunchService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<long> AddNumberCruncAsync(NumberCrunchDto numberCrunchDto)
        {
            // add Mapper
            NumberCrunch numberCrunch = await _unitOfWork.NumberCrunchRepository.AddAsync(new NumberCrunch()
            {
                MaxCount = numberCrunchDto.MaxCount,
                PatientScore = numberCrunchDto.PatientScore,
                DoctorScore = numberCrunchDto.DoctorScore,
                IsDeleted = false
            });
            return numberCrunch.Id;
        }

        public async Task<List<NumberCrunchVm>> GetNumberCrunchListById(long id)
        {
            List<NumberCrunchVm> result = new List<NumberCrunchVm>();
            NumberCrunch numberCrunch =  await _unitOfWork.NumberCrunchRepository.GetByIdAsync(id);
            if(numberCrunch != null)
            for (int i = 1; i <= numberCrunch.MaxCount; i++)
            {
                    result.Add(new NumberCrunchVm() {SampleNumber = i,
                    Score = GetScore(numberCrunch, i)
                    });
            }
            return result;
        }

        private string GetScore(NumberCrunch numberCrunch, int sambleNumber)
        {
            if (sambleNumber % numberCrunch.PatientScore == 0 && sambleNumber % numberCrunch.DoctorScore == 0)
            {
                return "Both";
            }
            if (sambleNumber % numberCrunch.PatientScore == 0)
            {
                return "Patient";
            }
            if (sambleNumber % numberCrunch.DoctorScore == 0)
            {
                return "Doctor";
            }
            return "None";
        }
    }
}
