using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Infrastructure.Domain
{
    public class NumberCrunch : Entity
    {
        public int MaxCount { get; set; }
        public int PatientScore { get; set; }
        public int DoctorScore { get; set; }
        public string Message { get; set; }


    }
}
