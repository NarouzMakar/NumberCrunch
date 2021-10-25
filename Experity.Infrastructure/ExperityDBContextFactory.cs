using Castle.Core.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Infrastructure
{
    internal class ExperityDBContextFactory : IDesignTimeDbContextFactory<ExperityDBContext>
    {
        /// <summary>
        /// Will be used by ef core migration tools only
        /// For eg: Add-Migration InitialCreate
        /// </summary>
        /// 
        public ExperityDBContext CreateDbContext(string[] args)
        {
            return new ExperityDBContext("Server=LAPTOP-TKMLPI2Q\\SQLEXPRESS;Database=Experity;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
    }
}
