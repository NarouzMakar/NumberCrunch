using Experity.Infrastructure.Domain;
using Experity.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Infrastructure.Repositories
{
    class NumberCrunchRepository : Repository<NumberCrunch>, INumberCrunchRepository
    {
        public NumberCrunchRepository(ExperityDBContext dbContext) : base(dbContext)
        {
        }
    }
}
