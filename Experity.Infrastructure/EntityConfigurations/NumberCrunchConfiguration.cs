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
    class NumberCrunchConfiguration : AggregateRootConfiguration<NumberCrunch>, IEntityTypeConfiguration<NumberCrunch>
    {
        public override void Configure(EntityTypeBuilder<NumberCrunch> builder)
        {
            base.Configure(builder);
            builder.ToTable("numberCrunch");
        }
    }
}