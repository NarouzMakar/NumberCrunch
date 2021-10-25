using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Business.DTOs
{
   public class NumberCrunchDto: DtoBase
    {
        public int MaxCount { get; set; }
        public int PatientScore { get; set; }
        public int DoctorScore { get; set; }

    }
}
