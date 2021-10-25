using Experity.Infrastructure.IRepositories;
using Experity.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExperityDBContext dbContext;

        public UnitOfWork(IDatabaseConnectionString databaseConnectionString)
        {
            dbContext = new ExperityDBContext(databaseConnectionString.ConnectionString);
        }

        #region Repositories

        private IOperationRepository operationRepository;
        public IOperationRepository OperationRepository => operationRepository ??= new OperationRepository(dbContext);

        private INumberCrunchRepository numberCrunchRepository;
        public INumberCrunchRepository NumberCrunchRepository => numberCrunchRepository ??= new NumberCrunchRepository(dbContext);

        #endregion

        #region Methods
        public int SaveChanges()
        {
            // logger.LogDebug($"Persisting repository changes to database with {dbContext.ChangeTracker.Entries().Count()} entries");
            var saveChangesResult = dbContext.SaveChanges();
            //  logger.LogDebug($"Persisted repository changes to database successfully. [{saveChangesResult} records changed]");

            return saveChangesResult;
        }

        #endregion
    }
}
