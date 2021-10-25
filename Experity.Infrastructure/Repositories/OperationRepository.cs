using Experity.Infrastructure.Domain;
using Experity.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Infrastructure.Repositories
{
    internal class OperationRepository : Repository<Operation>, IOperationRepository
    {
        public OperationRepository(ExperityDBContext dbContext) : base(dbContext)
        {
        }
    }
}
