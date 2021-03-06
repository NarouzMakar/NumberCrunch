using Experity.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Infrastructure
{
   public interface IUnitOfWork
    {
        INumberCrunchRepository NumberCrunchRepository { get; }

        int SaveChanges();
    }
}
