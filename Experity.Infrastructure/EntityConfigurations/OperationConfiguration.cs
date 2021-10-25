using Experity.Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experity.Infrastructure.EntityConfigurations
{
    internal class OperationConfiguration : AggregateRootConfiguration<Operation>, IEntityTypeConfiguration<Operation>
    {
        public override void Configure(EntityTypeBuilder<Operation> builder)
        {
            base.Configure(builder);
            builder.ToTable("operations");
            builder.HasKey(e => e.Id);
        }
    }
}
